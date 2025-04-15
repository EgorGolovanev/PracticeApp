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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace PracticeApp
{
    public partial class AddContractorForm : Form
    {
        private readonly string constring = "Host=localhost;Username=postgres;Password=admin;Database=postgres";

        public AddContractorForm()
        {
            InitializeComponent();
        }

        private void addContractorBtn_Click(object sender, EventArgs e)
        {
            // Проверка на заполненность всех полей
            if (string.IsNullOrWhiteSpace(contractorNameTextBox.Text) ||
                string.IsNullOrWhiteSpace(contractorPhoneTextBox.Text) ||
                string.IsNullOrWhiteSpace(contractorEmailTextBox.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string contractorName = contractorNameTextBox.Text;
            string contractorPhone = contractorPhoneTextBox.Text;
            string contractorEmail = contractorEmailTextBox.Text;
            bool isSupplier = isSupplierRadioBtn.Checked;
            bool isClient = isSupplierRadioBtn.Checked ? false : true;

            NpgsqlConnection con = new NpgsqlConnection(constring);
            con.Open();
            string addStoreQuery = "INSERT INTO contractor (contractor_name, phone, email, is_supplier, is_client) VALUES " +
                "(@ContractorName, @ContractorPhone, @ContractorEmail, @IsSupplier, @IsClient)";
            NpgsqlCommand addStoreCommand = new NpgsqlCommand(addStoreQuery, con);
            addStoreCommand.Parameters.AddWithValue("@ContractorName", contractorName);
            addStoreCommand.Parameters.AddWithValue("@ContractorPhone", contractorPhone);
            addStoreCommand.Parameters.AddWithValue("@ContractorEmail", contractorEmail);
            addStoreCommand.Parameters.AddWithValue("@IsSupplier", isSupplier);
            addStoreCommand.Parameters.AddWithValue("@IsClient", isClient);
            addStoreCommand.ExecuteNonQuery();
            con.Close();

            contractorNameTextBox.Clear();
            contractorPhoneTextBox.Clear();
            contractorEmailTextBox.Clear();
            isClientRadioBtn.Checked = false;
            isSupplierRadioBtn.Checked = false;
            MessageBox.Show("Контрагент добавлен!");
        }
    }
}
