namespace PracticeApp
{
    partial class AddEmployeeForm
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
            comboBox1 = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            middleNameTextBox = new TextBox();
            firstNameTextBox = new TextBox();
            lastNameTextBox = new TextBox();
            positionTextBox = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(50, 21);
            label1.Name = "label1";
            label1.Size = new Size(240, 25);
            label1.TabIndex = 0;
            label1.Text = "Добавление сотрудника";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 69);
            label2.Name = "label2";
            label2.Size = new Size(123, 15);
            label2.TabIndex = 1;
            label2.Text = "Магазин сотрудника:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 114);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 2;
            label3.Text = "Фамилия:";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(158, 66);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(168, 23);
            comboBox1.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 157);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 4;
            label4.Text = "Имя:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 194);
            label5.Name = "label5";
            label5.Size = new Size(61, 15);
            label5.TabIndex = 5;
            label5.Text = "Отчество:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 237);
            label6.Name = "label6";
            label6.Size = new Size(72, 15);
            label6.TabIndex = 6;
            label6.Text = "Должность:";
            // 
            // middleNameTextBox
            // 
            middleNameTextBox.Location = new Point(158, 111);
            middleNameTextBox.Name = "middleNameTextBox";
            middleNameTextBox.Size = new Size(168, 23);
            middleNameTextBox.TabIndex = 7;
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(158, 154);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(168, 23);
            firstNameTextBox.TabIndex = 8;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(158, 191);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(168, 23);
            lastNameTextBox.TabIndex = 9;
            // 
            // positionTextBox
            // 
            positionTextBox.Location = new Point(158, 234);
            positionTextBox.Name = "positionTextBox";
            positionTextBox.Size = new Size(168, 23);
            positionTextBox.TabIndex = 10;
            // 
            // button1
            // 
            button1.Location = new Point(119, 333);
            button1.Name = "button1";
            button1.Size = new Size(103, 39);
            button1.TabIndex = 11;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // AddEmployeeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(343, 384);
            Controls.Add(button1);
            Controls.Add(positionTextBox);
            Controls.Add(lastNameTextBox);
            Controls.Add(firstNameTextBox);
            Controls.Add(middleNameTextBox);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "AddEmployeeForm";
            Text = "Добавление сотрудника";
            Load += AddEmployeeForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox comboBox1;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox middleNameTextBox;
        private TextBox firstNameTextBox;
        private TextBox lastNameTextBox;
        private TextBox positionTextBox;
        private Button button1;
    }
}