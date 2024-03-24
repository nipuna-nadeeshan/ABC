namespace ABC_Car_Traders
{
    partial class Carpart_Details
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
            panel2 = new Panel();
            Dgv = new DataGridView();
            modelBox = new TextBox();
            label4 = new Label();
            button2 = new Button();
            button1 = new Button();
            nameBox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            idBox = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Dgv).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(BtnLogin);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 549);
            panel1.TabIndex = 2;
            // 
            // BtnLogin
            // 
            BtnLogin.BackColor = Color.LightSkyBlue;
            BtnLogin.Cursor = Cursors.Hand;
            BtnLogin.FlatStyle = FlatStyle.Flat;
            BtnLogin.Font = new Font("Palatino Linotype", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnLogin.Location = new Point(749, 0);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(27, 26);
            BtnLogin.TabIndex = 9;
            BtnLogin.Text = "X";
            BtnLogin.UseVisualStyleBackColor = false;
            BtnLogin.Click += BtnLogin_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(Dgv);
            panel2.Controls.Add(modelBox);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(nameBox);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(idBox);
            panel2.Location = new Point(0, 46);
            panel2.Name = "panel2";
            panel2.Size = new Size(776, 500);
            panel2.TabIndex = 3;
            // 
            // Dgv
            // 
            Dgv.AllowUserToAddRows = false;
            Dgv.AllowUserToDeleteRows = false;
            Dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            Dgv.BackgroundColor = Color.White;
            Dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Dgv.Location = new Point(3, 128);
            Dgv.Name = "Dgv";
            Dgv.ReadOnly = true;
            Dgv.RowHeadersVisible = false;
            Dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Dgv.Size = new Size(773, 372);
            Dgv.TabIndex = 11;
            // 
            // modelBox
            // 
            modelBox.Location = new Point(109, 81);
            modelBox.Name = "modelBox";
            modelBox.Size = new Size(217, 23);
            modelBox.TabIndex = 9;
            modelBox.TextChanged += textBox3_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Palatino Linotype", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(0, 81);
            label4.Name = "label4";
            label4.Size = new Size(105, 18);
            label4.TabIndex = 7;
            label4.Text = "Car Part Model :";
            // 
            // button2
            // 
            button2.BackColor = Color.DeepSkyBlue;
            button2.FlatAppearance.BorderColor = Color.White;
            button2.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(454, 71);
            button2.Name = "button2";
            button2.Size = new Size(75, 38);
            button2.TabIndex = 6;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.DeepSkyBlue;
            button1.FlatAppearance.BorderColor = Color.White;
            button1.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(359, 71);
            button1.Name = "button1";
            button1.Size = new Size(74, 38);
            button1.TabIndex = 5;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // nameBox
            // 
            nameBox.Location = new Point(112, 48);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(214, 23);
            nameBox.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Palatino Linotype", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 48);
            label3.Name = "label3";
            label3.Size = new Size(104, 18);
            label3.TabIndex = 3;
            label3.Text = "Car Part Name :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Palatino Linotype", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(26, 17);
            label2.Name = "label2";
            label2.Size = new Size(81, 18);
            label2.TabIndex = 2;
            label2.Text = "Car Part ID :";
            // 
            // idBox
            // 
            idBox.Location = new Point(113, 16);
            idBox.Name = "idBox";
            idBox.Size = new Size(213, 23);
            idBox.TabIndex = 1;
            idBox.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Palatino Linotype", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(18, 11);
            label1.Name = "label1";
            label1.Size = new Size(163, 28);
            label1.TabIndex = 2;
            label1.Text = "Car Part Details";
            // 
            // Carpart_Details
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(800, 581);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Carpart_Details";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Carpart_Details";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Dgv).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button BtnLogin;
        private Panel panel2;
        private TextBox modelBox;
        private Label label4;
        private Button button2;
        private Button button1;
        private TextBox nameBox;
        private Label label3;
        private Label label2;
        private TextBox idBox;
        private Label label1;
        private DataGridView Dgv;
    }
}