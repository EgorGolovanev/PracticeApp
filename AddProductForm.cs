using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace PracticeApp
{
    public partial class AddProductForm : Form
    {
        private string imagePath;
        private readonly string constring = "Host=localhost;Username=postgres;Password=admin;Database=postgres";

        public AddProductForm()
        {
            InitializeComponent();
        }

        private void AddProductForm_Load(object sender, EventArgs e)
        {
            // Заполнение ComboBox группами товаров из БД при загрузке формы
            NpgsqlConnection con = new NpgsqlConnection(constring);
            con.Open();

            string getProductGroupNames = "SELECT group_name FROM product_group";
            NpgsqlCommand cmd = new NpgsqlCommand(getProductGroupNames, con);

            var dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                comboBox1.Items.Add(dataReader.GetString(0));
            }
            con.Close();
        }

        private void loadProductImageBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    imagePath = openFileDialog.FileName;
                    pictureBox1.ImageLocation = imagePath;
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }

        private void addProductBtn_Click(object sender, EventArgs e)
        {
            // Проверка на заполненность всех полей
            if (string.IsNullOrWhiteSpace(textBoxProductCode.Text) ||
                string.IsNullOrWhiteSpace(textBoxProductName.Text) ||
                string.IsNullOrWhiteSpace(textBoxProductBrand.Text) ||
                comboBox1.SelectedIndex == -1 ||
                string.IsNullOrEmpty(imagePath))
            {
                MessageBox.Show("Пожалуйста, заполните все поля и выберите изображение.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Получаем данные пользователя из полей
            int productCode = Int32.Parse(textBoxProductCode.Text);
            string productName = textBoxProductName.Text;
            string productBrand = textBoxProductBrand.Text;
            int productGroup = comboBox1.SelectedIndex + 1;

            // Создание папки для изображений, если она не существует
            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Product_Images");
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            // Копирование изображения в папку
            string imageFileName = Path.GetFileName(imagePath);
            string newImagePath = Path.Combine(directoryPath, imageFileName);
            File.Copy(imagePath, newImagePath, true); // Копирование с перезаписью

            int imageId;

            // Проверка наличия загружаемого изображения в БД
            NpgsqlConnection con = new NpgsqlConnection(constring);
            con.Open();

            string checkImagePathQuery = "SELECT CASE WHEN EXISTS (SELECT 1 FROM product_image WHERE image_path = @ImagePath) " +
                "THEN (SELECT id FROM product_image WHERE image_path = @ImagePath) ELSE 0 END AS id";
            NpgsqlCommand checkImagePathCommand = new NpgsqlCommand(checkImagePathQuery, con);
            checkImagePathCommand.Parameters.AddWithValue("@ImagePath", newImagePath);
            var result = (int)checkImagePathCommand.ExecuteScalar();

            if (result != 0) // Изображение уже есть в БД, получаем его id и связываем с добавляемым продуктом
            {
                // Добавляем продукт
                string addProductQuery = "INSERT INTO product (code, product_name, brand, product_group_id, product_image_id) VALUES (@Code, @ProductName, @Brand, @ProductGroupId, @ProductImageId)";

                try
                {
                    NpgsqlCommand insertProductCommand = new NpgsqlCommand(addProductQuery, con);
                    insertProductCommand.Parameters.AddWithValue("@Code", productCode);
                    insertProductCommand.Parameters.AddWithValue("@ProductName", productName);
                    insertProductCommand.Parameters.AddWithValue("@Brand", productBrand);
                    insertProductCommand.Parameters.AddWithValue("@ProductGroupId", productGroup);
                    insertProductCommand.Parameters.AddWithValue("@ProductImageId", result);
                    insertProductCommand.ExecuteNonQuery();
                }
                catch (NpgsqlException ex)
                {
                    if (ex.SqlState == "23505")
                    {
                        MessageBox.Show("Ошибка: артикул товара должен быть уникальным!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            else // Изображения пока нет в БД, добавляем, получаем его id и связываем с добавляемым продуктом
            {
                // Получаем id изображения с уже существующим путём
                string addImagePathQuery = "INSERT INTO product_image (image_path) VALUES (@ImagePath) RETURNING id";
                NpgsqlCommand addImagePathCommand = new NpgsqlCommand(addImagePathQuery, con);
                addImagePathCommand.Parameters.AddWithValue("@ImagePath", newImagePath);
                imageId = (int)addImagePathCommand.ExecuteScalar();

                // Добавляем продукт
                string addProductQuery = "INSERT INTO product (code, product_name, brand, product_group_id, product_image_id) " +
                    "VALUES (@Code, @ProductName, @Brand, @ProductGroupId, @ProductImageId)";
                NpgsqlCommand insertProductCommand = new NpgsqlCommand(addProductQuery, con);
                insertProductCommand.Parameters.AddWithValue("@Code", productCode);
                insertProductCommand.Parameters.AddWithValue("@ProductName", productName);
                insertProductCommand.Parameters.AddWithValue("@Brand", productBrand);
                insertProductCommand.Parameters.AddWithValue("@ProductGroupId", productGroup);
                insertProductCommand.Parameters.AddWithValue("@ProductImageId", imageId);

                insertProductCommand.ExecuteNonQuery();
            }

            con.Close();
            MessageBox.Show("Продукт добавлен!");

            textBoxProductCode.Clear();
            textBoxProductName.Clear();
            textBoxProductBrand.Clear();
            comboBox1.SelectedIndex = -1;
            pictureBox1.Image = null;
            pictureBox1.Invalidate();
        }
    }
}
