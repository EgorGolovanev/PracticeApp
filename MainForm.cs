using Npgsql;
using System.Configuration;
using System.Data;
using System.Drawing;

/*
 Отличия в функциях возврата значений из БД:
    1. ExecuteScalar() - когда надо вернуть только одно значение (один ряд). Если возвращается несколько рядов, то функция представит пользователю
        только первую колонку первого ряда (например, SELECT id FROM some_table)
    2. ExecuteReader() - когда надо вернуть несколько значений (рядов/колонок) (например, SELECT id, name FROM some_table)
    3. ExecuteNonQuery() - когда надо выполнить SQL не предполагающий возврата результата (например, INSERT/UPDATE и т.п.)
 */

namespace PracticeApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void AddProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddProductForm addProductForm = new AddProductForm();
            addProductForm.ShowDialog();
        }

        private void viewProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewProductsForm viewProductsForm = new ViewProductsForm();
            viewProductsForm.ShowDialog();
        }

        private void addStoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStoreOrWarehouseForm addStoreOrWarehouseForm = new AddStoreOrWarehouseForm();
            addStoreOrWarehouseForm.ShowDialog();
        }

        private void addContractorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddContractorForm addContractorForm = new AddContractorForm();
            addContractorForm.ShowDialog();
        }

        private void addEmployeeToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AddEmployeeForm addEmployeeForm = new AddEmployeeForm();
            addEmployeeForm.ShowDialog();
        }

        private void setPricesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetPricesForm setPricesForm = new SetPricesForm();
            setPricesForm.ShowDialog();
        }
    }
}
