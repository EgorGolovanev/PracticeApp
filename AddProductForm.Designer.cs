namespace PracticeApp
{
    partial class AddProductForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            codeLabel = new Label();
            nameLabel = new Label();
            brandLabel = new Label();
            productGroupLabel = new Label();
            addProductLabel = new Label();
            textBoxProductCode = new TextBox();
            textBoxProductName = new TextBox();
            textBoxProductBrand = new TextBox();
            comboBox1 = new ComboBox();
            addProductBtn = new Button();
            imageLabel = new Label();
            openFileDialog1 = new OpenFileDialog();
            pictureBox1 = new PictureBox();
            loadProductImageBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // codeLabel
            // 
            codeLabel.AutoSize = true;
            codeLabel.Location = new Point(12, 67);
            codeLabel.Name = "codeLabel";
            codeLabel.Size = new Size(56, 15);
            codeLabel.TabIndex = 0;
            codeLabel.Text = "Артикул:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(12, 121);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(62, 15);
            nameLabel.TabIndex = 1;
            nameLabel.Text = "Название:";
            // 
            // brandLabel
            // 
            brandLabel.AutoSize = true;
            brandLabel.Location = new Point(12, 175);
            brandLabel.Name = "brandLabel";
            brandLabel.Size = new Size(43, 15);
            brandLabel.TabIndex = 2;
            brandLabel.Text = "Бренд:";
            // 
            // productGroupLabel
            // 
            productGroupLabel.AutoSize = true;
            productGroupLabel.Location = new Point(12, 227);
            productGroupLabel.Name = "productGroupLabel";
            productGroupLabel.Size = new Size(89, 15);
            productGroupLabel.TabIndex = 3;
            productGroupLabel.Text = "Группа товара:";
            // 
            // addProductLabel
            // 
            addProductLabel.AutoSize = true;
            addProductLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            addProductLabel.Location = new Point(56, 18);
            addProductLabel.Name = "addProductLabel";
            addProductLabel.Size = new Size(196, 25);
            addProductLabel.TabIndex = 4;
            addProductLabel.Text = "Добавление товара";
            // 
            // textBoxProductCode
            // 
            textBoxProductCode.Location = new Point(116, 64);
            textBoxProductCode.Name = "textBoxProductCode";
            textBoxProductCode.Size = new Size(181, 23);
            textBoxProductCode.TabIndex = 5;
            // 
            // textBoxProductName
            // 
            textBoxProductName.Location = new Point(116, 118);
            textBoxProductName.Name = "textBoxProductName";
            textBoxProductName.Size = new Size(181, 23);
            textBoxProductName.TabIndex = 6;
            // 
            // textBoxProductBrand
            // 
            textBoxProductBrand.Location = new Point(116, 172);
            textBoxProductBrand.Name = "textBoxProductBrand";
            textBoxProductBrand.Size = new Size(181, 23);
            textBoxProductBrand.TabIndex = 7;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(116, 224);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(181, 23);
            comboBox1.TabIndex = 8;
            // 
            // addProductBtn
            // 
            addProductBtn.Location = new Point(93, 434);
            addProductBtn.Name = "addProductBtn";
            addProductBtn.Size = new Size(115, 42);
            addProductBtn.TabIndex = 9;
            addProductBtn.Text = "Добавить";
            addProductBtn.UseVisualStyleBackColor = true;
            addProductBtn.Click += addProductBtn_Click;
            // 
            // imageLabel
            // 
            imageLabel.AutoSize = true;
            imageLabel.Location = new Point(12, 279);
            imageLabel.Name = "imageLabel";
            imageLabel.Size = new Size(86, 15);
            imageLabel.TabIndex = 10;
            imageLabel.Text = "Изображение:";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(155, 314);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // loadProductImageBtn
            // 
            loadProductImageBtn.Location = new Point(167, 275);
            loadProductImageBtn.Name = "loadProductImageBtn";
            loadProductImageBtn.Size = new Size(75, 23);
            loadProductImageBtn.TabIndex = 12;
            loadProductImageBtn.Text = "...";
            loadProductImageBtn.UseVisualStyleBackColor = true;
            loadProductImageBtn.Click += loadProductImageBtn_Click;
            // 
            // AddProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(309, 490);
            Controls.Add(loadProductImageBtn);
            Controls.Add(pictureBox1);
            Controls.Add(imageLabel);
            Controls.Add(addProductBtn);
            Controls.Add(comboBox1);
            Controls.Add(textBoxProductBrand);
            Controls.Add(textBoxProductName);
            Controls.Add(textBoxProductCode);
            Controls.Add(addProductLabel);
            Controls.Add(productGroupLabel);
            Controls.Add(brandLabel);
            Controls.Add(nameLabel);
            Controls.Add(codeLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "AddProductForm";
            Text = "AddProductForm";
            Load += AddProductForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label codeLabel;
        private Label nameLabel;
        private Label brandLabel;
        private Label productGroupLabel;
        private Label addProductLabel;
        private TextBox textBoxProductCode;
        private TextBox textBoxProductName;
        private TextBox textBoxProductBrand;
        private ComboBox comboBox1;
        private Button addProductBtn;
        private Label imageLabel;
        private OpenFileDialog openFileDialog1;
        private PictureBox pictureBox1;
        private Button loadProductImageBtn;
    }
}