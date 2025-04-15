namespace PracticeApp
{
    partial class ViewCartForm
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
            listBox1 = new ListBox();
            label1 = new Label();
            label2 = new Label();
            selectClientComboBox = new ComboBox();
            selectEmployeeComboBox = new ComboBox();
            makeSellBtn = new Button();
            label3 = new Label();
            selectStoreComboBox = new ComboBox();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.AllowDrop = true;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(11, 155);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(315, 169);
            listBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(130, 15);
            label1.TabIndex = 1;
            label1.Text = "Выберите покупателя:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 111);
            label2.Name = "label2";
            label2.Size = new Size(119, 15);
            label2.TabIndex = 2;
            label2.Text = "Выберите продавца:";
            // 
            // selectClientComboBox
            // 
            selectClientComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            selectClientComboBox.FormattingEnabled = true;
            selectClientComboBox.Location = new Point(159, 20);
            selectClientComboBox.Name = "selectClientComboBox";
            selectClientComboBox.Size = new Size(168, 23);
            selectClientComboBox.TabIndex = 3;
            // 
            // selectEmployeeComboBox
            // 
            selectEmployeeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            selectEmployeeComboBox.FormattingEnabled = true;
            selectEmployeeComboBox.Location = new Point(159, 108);
            selectEmployeeComboBox.Name = "selectEmployeeComboBox";
            selectEmployeeComboBox.Size = new Size(168, 23);
            selectEmployeeComboBox.TabIndex = 4;
            // 
            // makeSellBtn
            // 
            makeSellBtn.Location = new Point(118, 354);
            makeSellBtn.Name = "makeSellBtn";
            makeSellBtn.Size = new Size(107, 43);
            makeSellBtn.TabIndex = 5;
            makeSellBtn.Text = "Оформить продажу";
            makeSellBtn.UseVisualStyleBackColor = true;
            makeSellBtn.Click += makeSellBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 67);
            label3.Name = "label3";
            label3.Size = new Size(112, 15);
            label3.TabIndex = 6;
            label3.Text = "Выберите магазин:";
            // 
            // selectStoreComboBox
            // 
            selectStoreComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            selectStoreComboBox.FormattingEnabled = true;
            selectStoreComboBox.Location = new Point(159, 64);
            selectStoreComboBox.Name = "selectStoreComboBox";
            selectStoreComboBox.Size = new Size(168, 23);
            selectStoreComboBox.TabIndex = 7;
            selectStoreComboBox.SelectedIndexChanged += selectStoreComboBox_SelectedIndexChanged;
            // 
            // ViewCartForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(338, 450);
            Controls.Add(selectStoreComboBox);
            Controls.Add(label3);
            Controls.Add(makeSellBtn);
            Controls.Add(selectEmployeeComboBox);
            Controls.Add(selectClientComboBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "ViewCartForm";
            Text = "Корзина";
            Load += ViewCartForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Label label1;
        private Label label2;
        private ComboBox selectClientComboBox;
        private ComboBox selectEmployeeComboBox;
        private Button makeSellBtn;
        private Label label3;
        private ComboBox selectStoreComboBox;
    }
}