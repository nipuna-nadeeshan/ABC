namespace ABC_Car_Traders
{
    partial class Add_Order
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
            panel1 = new Panel();
            BtnLogin = new Button();
            label1 = new Label();
            panel2 = new Panel();
            comboBox3 = new ComboBox();
            label7 = new Label();
            dateTimePicker1 = new DateTimePicker();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            label6 = new Label();
            BtnCreate = new Button();
            label5 = new Label();
            qtyBox = new TextBox();
            label4 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(BtnLogin);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(464, 88);
            panel1.TabIndex = 2;
            // 
            // BtnLogin
            // 
            BtnLogin.BackColor = Color.LightSkyBlue;
            BtnLogin.Cursor = Cursors.Hand;
            BtnLogin.FlatStyle = FlatStyle.Flat;
            BtnLogin.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnLogin.Location = new Point(434, 0);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(30, 30);
            BtnLogin.TabIndex = 10;
            BtnLogin.Text = "X";
            BtnLogin.UseVisualStyleBackColor = false;
            BtnLogin.Click += BtnLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Palatino Linotype", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(17, 20);
            label1.Name = "label1";
            label1.Size = new Size(154, 37);
            label1.TabIndex = 3;
            label1.Text = "Add Order";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Silver;
            panel2.Controls.Add(comboBox3);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(comboBox2);
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(BtnCreate);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(qtyBox);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(12, 106);
            panel2.Name = "panel2";
            panel2.Size = new Size(464, 386);
            panel2.TabIndex = 3;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Cash Payments", "Online Online" });
            comboBox3.Location = new Point(129, 185);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(199, 23);
            comboBox3.TabIndex = 19;
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(3, 183);
            label7.Name = "label7";
            label7.Size = new Size(125, 22);
            label7.TabIndex = 18;
            label7.Text = "Payment Type :";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(129, 137);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 17;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(127, 54);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(199, 23);
            comboBox2.TabIndex = 16;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Car", "Car Part" });
            comboBox1.Location = new Point(127, 16);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(199, 23);
            comboBox1.TabIndex = 15;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(9, 137);
            label6.Name = "label6";
            label6.Size = new Size(102, 22);
            label6.TabIndex = 13;
            label6.Text = "Order Date :";
            // 
            // BtnCreate
            // 
            BtnCreate.BackColor = Color.LightSkyBlue;
            BtnCreate.Cursor = Cursors.Hand;
            BtnCreate.FlatAppearance.BorderColor = Color.White;
            BtnCreate.FlatAppearance.BorderSize = 2;
            BtnCreate.FlatAppearance.MouseDownBackColor = Color.Cyan;
            BtnCreate.FlatAppearance.MouseOverBackColor = Color.Cyan;
            BtnCreate.FlatStyle = FlatStyle.Flat;
            BtnCreate.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnCreate.Location = new Point(129, 245);
            BtnCreate.Name = "BtnCreate";
            BtnCreate.Size = new Size(201, 42);
            BtnCreate.TabIndex = 10;
            BtnCreate.Text = "Add Order";
            BtnCreate.UseVisualStyleBackColor = false;
            BtnCreate.Click += BtnCreate_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(38, 54);
            label5.Name = "label5";
            label5.Size = new Size(73, 22);
            label5.TabIndex = 6;
            label5.Text = "Models :";
            // 
            // qtyBox
            // 
            qtyBox.Location = new Point(128, 95);
            qtyBox.Name = "qtyBox";
            qtyBox.Size = new Size(199, 23);
            qtyBox.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(26, 93);
            label4.Name = "label4";
            label4.Size = new Size(85, 22);
            label4.TabIndex = 4;
            label4.Text = "Quantity :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(17, 14);
            label2.Name = "label2";
            label2.Size = new Size(105, 22);
            label2.TabIndex = 0;
            label2.Text = "Order Type :";
            // 
            // Add_Order
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(488, 503);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Add_Order";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add_Order";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button BtnLogin;
        private Label label1;
        private Panel panel2;
        private Label label6;
        public Button BtnCreate;
        private Label label5;
        public TextBox qtyBox;
        private Label label4;
        private Label label2;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private ComboBox comboBox3;
        private Label label7;
        private DateTimePicker dateTimePicker1;
    }
}