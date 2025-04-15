namespace PracticeApp
{
    partial class AddStoreOrWarehouseForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            storeNameTextBox = new TextBox();
            storeAddressTextBox = new TextBox();
            addStoreBtn = new Button();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(11, 21);
            label1.Name = "label1";
            label1.Size = new Size(289, 25);
            label1.TabIndex = 18;
            label1.Text = "Добавление магазина/склада";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 72);
            label2.Name = "label2";
            label2.Size = new Size(93, 15);
            label2.TabIndex = 19;
            label2.Text = "Наименование:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 125);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 20;
            label3.Text = "Адрес:";
            // 
            // storeNameTextBox
            // 
            storeNameTextBox.Location = new Point(126, 69);
            storeNameTextBox.Name = "storeNameTextBox";
            storeNameTextBox.Size = new Size(174, 23);
            storeNameTextBox.TabIndex = 21;
            // 
            // storeAddressTextBox
            // 
            storeAddressTextBox.Location = new Point(126, 122);
            storeAddressTextBox.Name = "storeAddressTextBox";
            storeAddressTextBox.Size = new Size(174, 23);
            storeAddressTextBox.TabIndex = 22;
            // 
            // addStoreBtn
            // 
            addStoreBtn.Location = new Point(104, 283);
            addStoreBtn.Name = "addStoreBtn";
            addStoreBtn.Size = new Size(103, 39);
            addStoreBtn.TabIndex = 23;
            addStoreBtn.Text = "Добавить";
            addStoreBtn.UseVisualStyleBackColor = true;
            addStoreBtn.Click += addStoreBtn_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(12, 173);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(125, 19);
            checkBox1.TabIndex = 24;
            checkBox1.Text = "Является складом";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // AddStoreOrWarehouseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(312, 355);
            Controls.Add(checkBox1);
            Controls.Add(addStoreBtn);
            Controls.Add(storeAddressTextBox);
            Controls.Add(storeNameTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "AddStoreOrWarehouseForm";
            Text = "Добавление магазина/склада";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addProductBtn;
        private Label addProductLabel;
        private Label brandLabel;
        private Label nameLabel;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox storeNameTextBox;
        private TextBox storeAddressTextBox;
        private Button addStoreBtn;
        private CheckBox checkBox1;
    }
}