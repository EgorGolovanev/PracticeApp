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
    public partial class ViewCartForm : Form
    {
        private Cart cart;
        private readonly string constring = "Host=localhost;Username=postgres;Password=admin;Database=postgres";

        public ViewCartForm(Cart cart)
        {
            InitializeComponent();
            this.cart = cart;
        }

        private void ViewCartForm_Load(object sender, EventArgs e)
        {
            List<StoreItem> storeItems = new List<StoreItem>();

            // Заполняем клиентов
            NpgsqlConnection con = new NpgsqlConnection(constring);
            con.Open();

            string selectClientQuery = "SELECT contractor_name FROM contractor WHERE is_client = true";
            NpgsqlCommand selectClientCommand = new NpgsqlCommand(selectClientQuery, con);
            var dataReader = selectClientCommand.ExecuteReader();
            while (dataReader.Read())
            {
                selectClientComboBox.Items.Add(dataReader.GetString(0));
            }
            con.Close();

            // Заполняем магазины
            con.Open();
            string selectStoreQuery = "SELECT id, store_name FROM store WHERE is_warehouse = false";
            NpgsqlCommand selectStoreCommand = new NpgsqlCommand(selectStoreQuery, con);
            var dataReader1 = selectStoreCommand.ExecuteReader();
            while (dataReader1.Read())
            {
                storeItems.Add(new StoreItem { Id = dataReader1.GetInt32(0), Name = dataReader1.GetString(1) });
            }
            selectStoreComboBox.DataSource = storeItems;
            con.Close();
            // ---------------------------------------------- Заполняем лист корзины
            foreach (var item in cart.GetItems())
            {
                listBox1.Items.Add($"{item.Product.Name} - {item.Quantity} шт. по {item.Product.Price:C} (Итого: {item.Quantity * item.Product.Price:C})");
            }
        }

        private void selectStoreComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<EmployeeItem> employeeItems = new List<EmployeeItem>();

            NpgsqlConnection con = new NpgsqlConnection(constring);
            con.Open();

            if (selectStoreComboBox.SelectedIndex != -1)
            {
                StoreItem selectedItem = (StoreItem)selectStoreComboBox.SelectedItem;
                int selectedId = selectedItem.Id;

                string selectEmployeeQuery = "SELECT id, middle_name, first_name, last_name FROM employee WHERE store_id = @SelectedId";
                NpgsqlCommand selectEmployeeCommand = new NpgsqlCommand(selectEmployeeQuery, con);
                selectEmployeeCommand.Parameters.AddWithValue("@SelectedId", selectedId);
                var dataReader2 = selectEmployeeCommand.ExecuteReader();

                while (dataReader2.Read())
                {
                    employeeItems.Add(new EmployeeItem 
                        { 
                            Id = dataReader2.GetInt32(0), 
                            MiddleName = dataReader2.GetString(1), 
                            FirstName = dataReader2.GetString(2), 
                            LastName = dataReader2.GetString(3) 
                        });
                }

                selectEmployeeComboBox.DataSource = employeeItems;
            }

            con.Close();
        }

        private void makeSellBtn_Click(object sender, EventArgs e)
        {

        }


    }

    public class StoreItem
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }

    public class EmployeeItem
    {
        public int Id {  get; set; }
        public string MiddleName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override string ToString()
        {
            return MiddleName + " " + FirstName + " " + LastName;
        }
    }
}
