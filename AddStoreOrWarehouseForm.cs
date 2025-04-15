using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PracticeApp
{
    public partial class AddStoreOrWarehouseForm : Form
    {
        private readonly string constring = "Host=localhost;Username=postgres;Password=admin;Database=postgres";

        public AddStoreOrWarehouseForm()
        {
            InitializeComponent();
        }

        private void addStoreBtn_Click(object sender, EventArgs e)
        {
            // Проверка на заполненность всех полей
            if (string.IsNullOrWhiteSpace(storeNameTextBox.Text) ||
                string.IsNullOrWhiteSpace(storeAddressTextBox.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string storeName = storeNameTextBox.Text;
            string storeAddress = storeAddressTextBox.Text;
            bool isWarehouse = checkBox1.Checked ? true : false;

            NpgsqlConnection con = new NpgsqlConnection(constring);
            con.Open();
            string addStoreQuery = "INSERT INTO store (store_name, store_address, is_warehouse) VALUES (@StoreName, @StoreAddress, @IsWarehouse)";

            try
            {
                NpgsqlCommand addStoreCommand = new NpgsqlCommand(addStoreQuery, con);
                addStoreCommand.Parameters.AddWithValue("@StoreName", storeName);
                addStoreCommand.Parameters.AddWithValue("@StoreAddress", storeAddress);
                addStoreCommand.Parameters.AddWithValue("@IsWarehouse", isWarehouse);
                addStoreCommand.ExecuteNonQuery();

                con.Close();

                storeNameTextBox.Clear();
                storeAddressTextBox.Clear();
                checkBox1.Checked = false;
                MessageBox.Show("Точка добавлена!");
            }
            catch (NpgsqlException ex)
            {
                if (ex.SqlState == "23505")
                {
                    MessageBox.Show("Ошибка: наименование точки должно быть уникальным!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    MessageBox.Show("Ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }
    }
}
