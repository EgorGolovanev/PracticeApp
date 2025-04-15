namespace PracticeApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            ProductsToolStripMenuItem = new ToolStripMenuItem();
            AddProductToolStripMenuItem = new ToolStripMenuItem();
            viewProductsToolStripMenuItem = new ToolStripMenuItem();
            setPricesToolStripMenuItem = new ToolStripMenuItem();
            магазиныСкладыToolStripMenuItem = new ToolStripMenuItem();
            addStoreToolStripMenuItem = new ToolStripMenuItem();
            контрагентыToolStripMenuItem = new ToolStripMenuItem();
            addContractorToolStripMenuItem1 = new ToolStripMenuItem();
            сотрудникиToolStripMenuItem = new ToolStripMenuItem();
            addEmployeeToolStripMenuItem2 = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { ProductsToolStripMenuItem, магазиныСкладыToolStripMenuItem, контрагентыToolStripMenuItem, сотрудникиToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // ProductsToolStripMenuItem
            // 
            ProductsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { AddProductToolStripMenuItem, viewProductsToolStripMenuItem, setPricesToolStripMenuItem });
            ProductsToolStripMenuItem.Name = "ProductsToolStripMenuItem";
            ProductsToolStripMenuItem.Size = new Size(60, 20);
            ProductsToolStripMenuItem.Text = "Товары";
            // 
            // AddProductToolStripMenuItem
            // 
            AddProductToolStripMenuItem.Name = "AddProductToolStripMenuItem";
            AddProductToolStripMenuItem.Size = new Size(191, 22);
            AddProductToolStripMenuItem.Text = "Добавить товар";
            AddProductToolStripMenuItem.Click += AddProductToolStripMenuItem_Click;
            // 
            // viewProductsToolStripMenuItem
            // 
            viewProductsToolStripMenuItem.Name = "viewProductsToolStripMenuItem";
            viewProductsToolStripMenuItem.Size = new Size(191, 22);
            viewProductsToolStripMenuItem.Text = "Просмотреть товары";
            viewProductsToolStripMenuItem.Click += viewProductsToolStripMenuItem_Click;
            // 
            // setPricesToolStripMenuItem
            // 
            setPricesToolStripMenuItem.Name = "setPricesToolStripMenuItem";
            setPricesToolStripMenuItem.Size = new Size(191, 22);
            setPricesToolStripMenuItem.Text = "Установить цены";
            setPricesToolStripMenuItem.Click += setPricesToolStripMenuItem_Click;
            // 
            // магазиныСкладыToolStripMenuItem
            // 
            магазиныСкладыToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addStoreToolStripMenuItem });
            магазиныСкладыToolStripMenuItem.Name = "магазиныСкладыToolStripMenuItem";
            магазиныСкладыToolStripMenuItem.Size = new Size(122, 20);
            магазиныСкладыToolStripMenuItem.Text = "Магазины/Склады";
            // 
            // addStoreToolStripMenuItem
            // 
            addStoreToolStripMenuItem.Name = "addStoreToolStripMenuItem";
            addStoreToolStripMenuItem.Size = new Size(126, 22);
            addStoreToolStripMenuItem.Text = "Добавить";
            addStoreToolStripMenuItem.Click += addStoreToolStripMenuItem_Click;
            // 
            // контрагентыToolStripMenuItem
            // 
            контрагентыToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addContractorToolStripMenuItem1 });
            контрагентыToolStripMenuItem.Name = "контрагентыToolStripMenuItem";
            контрагентыToolStripMenuItem.Size = new Size(90, 20);
            контрагентыToolStripMenuItem.Text = "Контрагенты";
            // 
            // addContractorToolStripMenuItem1
            // 
            addContractorToolStripMenuItem1.Name = "addContractorToolStripMenuItem1";
            addContractorToolStripMenuItem1.Size = new Size(180, 22);
            addContractorToolStripMenuItem1.Text = "Добавить";
            addContractorToolStripMenuItem1.Click += addContractorToolStripMenuItem1_Click;
            // 
            // сотрудникиToolStripMenuItem
            // 
            сотрудникиToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addEmployeeToolStripMenuItem2 });
            сотрудникиToolStripMenuItem.Name = "сотрудникиToolStripMenuItem";
            сотрудникиToolStripMenuItem.Size = new Size(85, 20);
            сотрудникиToolStripMenuItem.Text = "Сотрудники";
            // 
            // addEmployeeToolStripMenuItem2
            // 
            addEmployeeToolStripMenuItem2.Name = "addEmployeeToolStripMenuItem2";
            addEmployeeToolStripMenuItem2.Size = new Size(126, 22);
            addEmployeeToolStripMenuItem2.Text = "Добавить";
            addEmployeeToolStripMenuItem2.Click += addEmployeeToolStripMenuItem2_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "Учёт товаров";
            Load += MainForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem ProductsToolStripMenuItem;
        private ToolStripMenuItem AddProductToolStripMenuItem;
        private ToolStripMenuItem viewProductsToolStripMenuItem;
        private ToolStripMenuItem магазиныСкладыToolStripMenuItem;
        private ToolStripMenuItem addStoreToolStripMenuItem;
        private ToolStripMenuItem контрагентыToolStripMenuItem;
        private ToolStripMenuItem addContractorToolStripMenuItem1;
        private ToolStripMenuItem сотрудникиToolStripMenuItem;
        private ToolStripMenuItem addEmployeeToolStripMenuItem2;
        private ToolStripMenuItem setPricesToolStripMenuItem;
    }
}
