namespace PracticeApp
{
    partial class ViewProductsForm
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            shopingCartCostTextBox = new TextBox();
            viewShopingCartBtn = new Button();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(12, 46);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(776, 392);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(436, 16);
            label1.Name = "label1";
            label1.Size = new Size(121, 15);
            label1.TabIndex = 1;
            label1.Text = "Стоимость корзины:";
            // 
            // shopingCartCostTextBox
            // 
            shopingCartCostTextBox.Enabled = false;
            shopingCartCostTextBox.Location = new Point(563, 12);
            shopingCartCostTextBox.Name = "shopingCartCostTextBox";
            shopingCartCostTextBox.Size = new Size(100, 23);
            shopingCartCostTextBox.TabIndex = 2;
            // 
            // viewShopingCartBtn
            // 
            viewShopingCartBtn.Location = new Point(669, 5);
            viewShopingCartBtn.Name = "viewShopingCartBtn";
            viewShopingCartBtn.Size = new Size(119, 36);
            viewShopingCartBtn.TabIndex = 3;
            viewShopingCartBtn.Text = "Открыть корзину";
            viewShopingCartBtn.UseVisualStyleBackColor = true;
            viewShopingCartBtn.Click += viewShopingCartBtn_Click;
            // 
            // ViewProductsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(viewShopingCartBtn);
            Controls.Add(shopingCartCostTextBox);
            Controls.Add(label1);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "ViewProductsForm";
            Text = "Просмотр продуктов";
            Load += ViewProductsForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private TextBox shopingCartCostTextBox;
        private Button viewShopingCartBtn;
    }
}