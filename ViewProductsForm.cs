using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PracticeApp
{
    public partial class ViewProductsForm : Form
    {
        private readonly string constring = "Host=localhost;Username=postgres;Password=admin;Database=postgres";

        private Cart cart = new Cart();

        public List<Product> LoadProducts()
        {
            var products = new List<Product>();

            NpgsqlConnection con = new NpgsqlConnection(constring);
            con.Open();

            //string getProductsInfoQuery = "SELECT p.code, p.product_name, p.brand, pi.image_path FROM product p JOIN product_image pi ON p.product_image_id = pi.id"; // BACKUP
            string getProductsInfoQuery = "SELECT p.code, p.product_name, p.brand, pi.image_path, sp.price FROM product p JOIN product_image pi ON p.product_image_id = pi.id join sell_price sp on sp.product_id = p.id JOIN (SELECT product_id, MAX(sell_date) AS max_sell_date FROM sell_price GROUP BY product_id) AS latest ON sp.product_id = latest.product_id AND sp.sell_date = latest.max_sell_date";
            NpgsqlCommand getProductsCommand = new NpgsqlCommand(getProductsInfoQuery, con);

            var dataReader = getProductsCommand.ExecuteReader();
            while (dataReader.Read())
            {
                var product = new Product
                {
                    Code = dataReader.GetInt16(0),
                    Name = dataReader.GetString(1),
                    Brand = dataReader.GetString(2),
                    ImagePath = dataReader.GetString(3),
                    Price = dataReader.GetFloat(4),
                };
                products.Add(product);
            }

            return products;
        }

        public ViewProductsForm()
        {
            InitializeComponent();
        }

        private void ViewProductsForm_Load(object sender, EventArgs e)
        {
            var products = LoadProducts();
            DisplayProducts(products);

            shopingCartCostTextBox.Text = "0.00";
        }

        private void DisplayProducts(List<Product> products)
        {
            flowLayoutPanel1.Controls.Clear(); // Очистка предыдущих карточек

            Label emptyProductTemplate = new Label();
            emptyProductTemplate.Text = "Нет продуктов!";
            if (products.Count() == 0)
            {
                flowLayoutPanel1.Controls.Add(emptyProductTemplate);
            }

            foreach (var product in products)
            {
                var card = CreateProductCard(product);
                flowLayoutPanel1.Controls.Add(card);
            }
        }

        private Panel CreateProductCard(Product product)
        {
            var card = new Panel
            {
                Size = new Size(150, 280), // Размер карточки
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(10)
            };

            var pictureBox = new PictureBox
            {
                Image = Image.FromFile(product.ImagePath), // Загрузка изображения
                SizeMode = PictureBoxSizeMode.StretchImage,
                Size = new Size(100, 100),
                Location = new Point(25, 10) // Положение картинки
            };

            var articleLabel = new Label
            {
                Text = product.Code.ToString(),
                Location = new Point(10, 120),
                AutoSize = true
            };

            var nameLabel = new Label
            {
                Text = product.Name,
                Location = new Point(10, 140),
                AutoSize = true
            };

            var brandLabel = new Label
            {
                Text = product.Brand,
                Location = new Point(10, 160),
                AutoSize = true
            };

            var priceLabel = new Label
            {
                Text = product.Price.ToString() + " руб.",
                Location = new Point(10, 180),
                AutoSize = true
            };

            var quantityTextBox = new System.Windows.Forms.TextBox
            {
                Name = "quantityTextBox",
                PlaceholderText = "Введите количество",
                Location = new Point(10, 200),
                Width = card.Width - 20,
                Anchor = AnchorStyles.Left | AnchorStyles.Right
            };

            var addButton = new System.Windows.Forms.Button
            {
                Name = "addToShoppingCartBtn",
                Text = "Добавить",
                Location = new Point(10, 230),
                Width = card.Width - 20,
                Anchor = AnchorStyles.Left | AnchorStyles.Right
            };
            addButton.Click += (sender, e) => addToShoppingCartBtn_Click(product, quantityTextBox);

            card.Controls.Add(pictureBox);
            card.Controls.Add(articleLabel);
            card.Controls.Add(nameLabel);
            card.Controls.Add(brandLabel);
            card.Controls.Add(priceLabel);
            card.Controls.Add(quantityTextBox);
            card.Controls.Add(addButton);

            return card;
        }

        private void AddToCart(Product product, int quantity)
        {
            cart.AddItem(product, quantity);
            UpdateTotalPrice();
        }

        private void UpdateTotalPrice()
        {
            shopingCartCostTextBox.Text = $"{cart.TotalPrice():C}";
        }

        private void addToShoppingCartBtn_Click(Product product, System.Windows.Forms.TextBox quantityTextBox)
        {
            int quantity = 1; // По умолчанию
            if (int.TryParse(quantityTextBox.Text, out int inputQuantity) && inputQuantity > 0)
            {
                quantity = inputQuantity;
            }
            AddToCart(product, quantity);
        }

        private void viewShopingCartBtn_Click(object sender, EventArgs e)
        {
            var cartForm = new ViewCartForm(cart);
            cartForm.ShowDialog();
        }
    }

    // Отдельный экземпляр продукта
    public class Product
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public string ImagePath { get; set; }
        public float Price { get; set; }
    }

    // Позиция в корзине
    public class CartItem
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }

    // Корзина
    public class Cart
    {
        private List<CartItem> items = new List<CartItem>();

        public void AddItem(Product product, int quantity)
        {
            // Если продукт уже есть, то не добавлям новый, а прибавляем количество
            var existingItem = items.FirstOrDefault(i => i.Product.Code == product.Code);
            if (existingItem != null)
            {
                existingItem.Quantity += quantity;
            }
            else
            {
                items.Add(new CartItem { Product = product, Quantity = quantity });
            }
        }

        public float TotalPrice()
        {
            return items.Sum(i => i.Product.Price *  i.Quantity);
        }

        public List<CartItem> GetItems()
        {
            return items;
        }
    }
}
