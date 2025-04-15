using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticeApp
{
    public partial class SetPricesForm : Form
    {
        private readonly string constring = "Host=localhost;Username=postgres;Password=admin;Database=postgres";

        public SetPricesForm()
        {
            InitializeComponent();
            priceTextBox.TextChanged += priceTextBox_TextChanged;
        }

        private void SetPricesForm_Load(object sender, EventArgs e)
        {
            NpgsqlConnection con = new NpgsqlConnection(constring);
            con.Open();
            string getAllProductsQuery = "SELECT product_name, code FROM product";
            NpgsqlCommand getAllStoresCommand = new NpgsqlCommand(getAllProductsQuery, con);
            var dataReader = getAllStoresCommand.ExecuteReader();

            while (dataReader.Read())
            {
                comboBox1.Items.Add($"{dataReader.GetString(0)} (арт. {dataReader.GetInt16(1)})");
            }
            con.Close();

            //dateTextBox.Text = $"{DateOnly.FromDateTime(DateTime.Today)}";
            dateTextBox.Text = DateTime.Now.ToString();
            dateTextBox.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(priceTextBox.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //string code = comboBox1.Text;
            Regex regex = new Regex(@"[0-9]{3}"); // Выбрать из ComboBox артикул товара
            Match match = regex.Match(comboBox1.Text);
            int productCode = Int32.Parse(match.Value);

            float price = float.Parse(priceTextBox.Text);
            string dateText = dateTextBox.Text;
            DateTime currentDate = DateTime.Parse(dateTextBox.Text);


            NpgsqlConnection con = new NpgsqlConnection(constring);
            con.Open();
            string setProductPriceQuery = "INSERT INTO sell_price (product_id, price, sell_date) VALUES ((SELECT id FROM product WHERE code = @ProductCode), @Price, @SetDate)";
            NpgsqlCommand setProductPricesCommand = new NpgsqlCommand(setProductPriceQuery, con);
            setProductPricesCommand.Parameters.AddWithValue("@ProductCode", productCode);
            setProductPricesCommand.Parameters.AddWithValue("@Price", price);
            setProductPricesCommand.Parameters.AddWithValue("@SetDate", currentDate);
            setProductPricesCommand.ExecuteNonQuery();
            con.Close();

            comboBox1.SelectedIndex = -1;
            priceTextBox.Clear();
            dateTextBox.Text = DateTime.Now.ToString();
            MessageBox.Show("Цена добавлена!");
        }

        private void priceTextBox_TextChanged(object sender, EventArgs e)
        {
            // Получаем текущий текст из TextBox
            string currentText = priceTextBox.Text;

            // Заменяем точки на запятые
            string updatedText = currentText.Replace('.', ',');

            // Проверяем, если текст изменился, обновляем его
            if (currentText != updatedText)
            {
                priceTextBox.Text = updatedText;
                // Устанавливаем курсор в конец текста
                priceTextBox.SelectionStart = updatedText.Length;
            }
        }
    }
}
