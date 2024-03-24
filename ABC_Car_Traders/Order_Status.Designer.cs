namespace ABC_Car_Traders
{
    partial class Order_Status
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
            dateTimePicker1 = new DateTimePicker();
            comboBox1 = new ComboBox();
            label6 = new Label();
            BtnCreate = new Button();
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
            panel1.Size = new Size(366, 88);
            panel1.TabIndex = 2;
            // 
            // BtnLogin
            // 
            BtnLogin.BackColor = Color.LightSkyBlue;
            BtnLogin.Cursor = Cursors.Hand;
            BtnLogin.FlatStyle = FlatStyle.Flat;
            BtnLogin.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnLogin.Location = new Point(336, 0);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(30, 30);
            BtnLogin.TabIndex = 10;
            BtnLogin.Text = "X";
            BtnLogin.UseVisualStyleBackColor = false;
            BtnLogin.Click += BtnLogin_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Palatino Linotype", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(17, 20);
            label1.Name = "label1";
            label1.Size = new Size(177, 37);
            label1.TabIndex = 3;
            label1.Text = "Order Status";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Silver;
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(BtnCreate);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(12, 106);
            panel2.Name = "panel2";
            panel2.Size = new Size(366, 196);
            panel2.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(127, 32);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 17;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(127, 74);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(199, 23);
            comboBox1.TabIndex = 15;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(4, 32);
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
            BtnCreate.Location = new Point(125, 106);
            BtnCreate.Name = "BtnCreate";
            BtnCreate.Size = new Size(201, 42);
            BtnCreate.TabIndex = 10;
            BtnCreate.Text = "View Status";
            BtnCreate.UseVisualStyleBackColor = false;
            BtnCreate.Click += BtnCreate_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(17, 72);
            label2.Name = "label2";
            label2.Size = new Size(86, 22);
            label2.TabIndex = 0;
            label2.Text = "Order ID :";
            // 
            // Order_Status
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(390, 331);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Order_Status";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Order_Status";
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
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox1;
        private Label label6;
        public Button BtnCreate;
        private Label label2;
    }
}