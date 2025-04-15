using Npgsql;
using System.Configuration;
using System.Data;
using System.Drawing;

/*
 ������� � �������� �������� �������� �� ��:
    1. ExecuteScalar() - ����� ���� ������� ������ ���� �������� (���� ���). ���� ������������ ��������� �����, �� ������� ���������� ������������
        ������ ������ ������� ������� ���� (��������, SELECT id FROM some_table)
    2. ExecuteReader() - ����� ���� ������� ��������� �������� (�����/�������) (��������, SELECT id, name FROM some_table)
    3. ExecuteNonQuery() - ����� ���� ��������� SQL �� �������������� �������� ���������� (��������, INSERT/UPDATE � �.�.)
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
            //string testPath = 
            //    "C:\\Users\\User\\Documents\\1_�������_���_��������\\�������_��������_��������\\�������\\PracticeApp\\bin\\Debug\\" +
            //    "net6.0-windows\\Product_Images\\������.jpg";

            //string conString = "Host=localhost;Username=postgres;Password=admin;Database=postgres";

            //NpgsqlConnection con = new NpgsqlConnection(conString);
            //con.Open();

            ////string getProductGroupNames = "SELECT image_path FROM product_image WHERE image_path = @ImagePath RETURNING id";
            //string getProductGroupNames = "SELECT CASE WHEN EXISTS (SELECT 1 FROM product_image WHERE image_path = @ImagePath) THEN (SELECT id FROM product_image WHERE image_path = @ImagePath) ELSE NULL END AS id";
            //NpgsqlCommand cmd = new NpgsqlCommand(getProductGroupNames, con);
            //cmd.Parameters.AddWithValue("@ImagePath", testPath);
            //var rest = cmd.ExecuteScalar(); // ����� ������� ���� ����� ���������� � testPath � NULL � ��������� ������

            //int a = 2;
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
