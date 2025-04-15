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

namespace PracticeApp
{
    public partial class AddEmployeeForm : Form
    {
        private readonly string constring = "Host=localhost;Username=postgres;Password=admin;Database=postgres";

        public AddEmployeeForm()
        {
            InitializeComponent();
        }

        private void AddEmployeeForm_Load(object sender, EventArgs e)
        {
            NpgsqlConnection con = new NpgsqlConnection(constring);
            con.Open();
            string getAllStoresQuery = "SELECT store_name FROM store WHERE is_warehouse = false";
            NpgsqlCommand getAllStoresCommand = new NpgsqlCommand(getAllStoresQuery, con);
            var dataReader = getAllStoresCommand.ExecuteReader();

            while (dataReader.Read())
            {
                comboBox1.Items.Add(dataReader.GetString(0));
            }
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Проверка на заполненность всех полей
            if (string.IsNullOrWhiteSpace(middleNameTextBox.Text) ||
                string.IsNullOrWhiteSpace(firstNameTextBox.Text) ||
                string.IsNullOrWhiteSpace(lastNameTextBox.Text) ||
                string.IsNullOrWhiteSpace(positionTextBox.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Получение данных из полей
            string storeName = comboBox1.Text;
            string middleName = middleNameTextBox.Text;
            string firstName = firstNameTextBox.Text;
            string lastName = lastNameTextBox.Text;
            string position = positionTextBox.Text;

            NpgsqlConnection con = new NpgsqlConnection(constring);
            con.Open();
            string insertNewEmployeeQuery = "INSERT INTO employee (store_id, middle_name, first_name, last_name, employee_position) VALUES ((SELECT id FROM store WHERE store_name = @StoreName), @MiddleName, @FirstName, @LastName, @Position)";
            NpgsqlCommand insertNewEmployeeCommand = new NpgsqlCommand(insertNewEmployeeQuery, con);
            insertNewEmployeeCommand.Parameters.AddWithValue("@StoreName", storeName);
            insertNewEmployeeCommand.Parameters.AddWithValue("@MiddleName", middleName);
            insertNewEmployeeCommand.Parameters.AddWithValue("@FirstName", firstName);
            insertNewEmployeeCommand.Parameters.AddWithValue("@LastName", lastName);
            insertNewEmployeeCommand.Parameters.AddWithValue("@Position", position);
            insertNewEmployeeCommand.ExecuteNonQuery();
            con.Close();

            comboBox1.SelectedIndex = -1;
            firstNameTextBox.Clear();
            middleNameTextBox.Clear();
            lastNameTextBox.Clear();
            positionTextBox.Clear();
            MessageBox.Show("Сотрудник добавлен!");
        }
    }
}
