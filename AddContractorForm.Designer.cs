namespace PracticeApp
{
    partial class AddContractorForm
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
            label4 = new Label();
            groupBox1 = new GroupBox();
            isClientRadioBtn = new RadioButton();
            isSupplierRadioBtn = new RadioButton();
            contractorNameTextBox = new TextBox();
            contractorPhoneTextBox = new TextBox();
            contractorEmailTextBox = new TextBox();
            addContractorBtn = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(16, 22);
            label1.Name = "label1";
            label1.Size = new Size(247, 25);
            label1.TabIndex = 0;
            label1.Text = "Добавление контрагента";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 78);
            label2.Name = "label2";
            label2.Size = new Size(93, 15);
            label2.TabIndex = 1;
            label2.Text = "Наименование:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 120);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 2;
            label3.Text = "Телефон:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 162);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 3;
            label4.Text = "Email:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(isClientRadioBtn);
            groupBox1.Controls.Add(isSupplierRadioBtn);
            groupBox1.Location = new Point(12, 188);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(101, 83);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            // 
            // isClientRadioBtn
            // 
            isClientRadioBtn.AutoSize = true;
            isClientRadioBtn.Location = new Point(6, 47);
            isClientRadioBtn.Name = "isClientRadioBtn";
            isClientRadioBtn.Size = new Size(64, 19);
            isClientRadioBtn.TabIndex = 1;
            isClientRadioBtn.TabStop = true;
            isClientRadioBtn.Text = "Клиент";
            isClientRadioBtn.UseVisualStyleBackColor = true;
            // 
            // isSupplierRadioBtn
            // 
            isSupplierRadioBtn.AutoSize = true;
            isSupplierRadioBtn.Location = new Point(6, 22);
            isSupplierRadioBtn.Name = "isSupplierRadioBtn";
            isSupplierRadioBtn.Size = new Size(88, 19);
            isSupplierRadioBtn.TabIndex = 0;
            isSupplierRadioBtn.TabStop = true;
            isSupplierRadioBtn.Text = "Поставщик";
            isSupplierRadioBtn.UseVisualStyleBackColor = true;
            // 
            // contractorNameTextBox
            // 
            contractorNameTextBox.Location = new Point(125, 75);
            contractorNameTextBox.Name = "contractorNameTextBox";
            contractorNameTextBox.Size = new Size(136, 23);
            contractorNameTextBox.TabIndex = 5;
            // 
            // contractorPhoneTextBox
            // 
            contractorPhoneTextBox.Location = new Point(125, 117);
            contractorPhoneTextBox.Name = "contractorPhoneTextBox";
            contractorPhoneTextBox.Size = new Size(136, 23);
            contractorPhoneTextBox.TabIndex = 6;
            // 
            // contractorEmailTextBox
            // 
            contractorEmailTextBox.Location = new Point(125, 159);
            contractorEmailTextBox.Name = "contractorEmailTextBox";
            contractorEmailTextBox.Size = new Size(136, 23);
            contractorEmailTextBox.TabIndex = 7;
            // 
            // addContractorBtn
            // 
            addContractorBtn.Location = new Point(93, 315);
            addContractorBtn.Name = "addContractorBtn";
            addContractorBtn.Size = new Size(101, 42);
            addContractorBtn.TabIndex = 8;
            addContractorBtn.Text = "Добавить";
            addContractorBtn.UseVisualStyleBackColor = true;
            addContractorBtn.Click += addContractorBtn_Click;
            // 
            // AddContractorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(278, 380);
            Controls.Add(addContractorBtn);
            Controls.Add(contractorEmailTextBox);
            Controls.Add(contractorPhoneTextBox);
            Controls.Add(contractorNameTextBox);
            Controls.Add(groupBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "AddContractorForm";
            Text = "Добавление контрагента";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private GroupBox groupBox1;
        private RadioButton isClientRadioBtn;
        private RadioButton isSupplierRadioBtn;
        private TextBox contractorNameTextBox;
        private TextBox contractorPhoneTextBox;
        private TextBox contractorEmailTextBox;
        private Button addContractorBtn;
    }
}