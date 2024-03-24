namespace ABC_Car_Traders
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            RadioCustomer = new RadioButton();
            RadioAdmin = new RadioButton();
            BtnExit = new Button();
            BtnCreateUser = new Button();
            BtnLogin = new Button();
            panel2 = new Panel();
            label4 = new Label();
            TxtPassword = new TextBox();
            label3 = new Label();
            TxtUsername = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Snow;
            panel1.Controls.Add(RadioCustomer);
            panel1.Controls.Add(RadioAdmin);
            panel1.Controls.Add(BtnExit);
            panel1.Controls.Add(BtnCreateUser);
            panel1.Controls.Add(BtnLogin);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(TxtPassword);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(TxtUsername);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(25, 21);
            panel1.Name = "panel1";
            panel1.Size = new Size(628, 418);
            panel1.TabIndex = 0;
            // 
            // RadioCustomer
            // 
            RadioCustomer.AutoSize = true;
            RadioCustomer.Font = new Font("Palatino Linotype", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RadioCustomer.Location = new Point(442, 226);
            RadioCustomer.Name = "RadioCustomer";
            RadioCustomer.Size = new Size(85, 22);
            RadioCustomer.TabIndex = 11;
            RadioCustomer.TabStop = true;
            RadioCustomer.Text = "Customer";
            RadioCustomer.UseVisualStyleBackColor = true;
            // 
            // RadioAdmin
            // 
            RadioAdmin.AutoSize = true;
            RadioAdmin.Font = new Font("Palatino Linotype", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RadioAdmin.Location = new Point(338, 226);
            RadioAdmin.Name = "RadioAdmin";
            RadioAdmin.Size = new Size(68, 22);
            RadioAdmin.TabIndex = 1;
            RadioAdmin.TabStop = true;
            RadioAdmin.Text = "Admin";
            RadioAdmin.UseVisualStyleBackColor = true;
            RadioAdmin.CheckedChanged += RadioAdmin_CheckedChanged;
            // 
            // BtnExit
            // 
            BtnExit.BackColor = Color.LightSkyBlue;
            BtnExit.Cursor = Cursors.Hand;
            BtnExit.FlatStyle = FlatStyle.Flat;
            BtnExit.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnExit.Location = new Point(523, 337);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new Size(80, 42);
            BtnExit.TabIndex = 10;
            BtnExit.Text = "Exit";
            BtnExit.UseVisualStyleBackColor = false;
            BtnExit.Click += BtnExit_Click;
            // 
            // BtnCreateUser
            // 
            BtnCreateUser.BackColor = Color.LightSkyBlue;
            BtnCreateUser.Cursor = Cursors.Hand;
            BtnCreateUser.FlatStyle = FlatStyle.Flat;
            BtnCreateUser.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnCreateUser.Location = new Point(393, 271);
            BtnCreateUser.Name = "BtnCreateUser";
            BtnCreateUser.Size = new Size(210, 42);
            BtnCreateUser.TabIndex = 9;
            BtnCreateUser.Text = "Create New User";
            BtnCreateUser.UseVisualStyleBackColor = false;
            BtnCreateUser.Click += BtnCreateUser_Click;
            // 
            // BtnLogin
            // 
            BtnLogin.BackColor = Color.LightSkyBlue;
            BtnLogin.Cursor = Cursors.Hand;
            BtnLogin.FlatStyle = FlatStyle.Flat;
            BtnLogin.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnLogin.Location = new Point(274, 271);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(75, 42);
            BtnLogin.TabIndex = 8;
            BtnLogin.Text = "Login";
            BtnLogin.UseVisualStyleBackColor = false;
            BtnLogin.Click += BtnLogin_Click;
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.None;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(192, 416);
            panel2.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(243, 180);
            label4.Name = "label4";
            label4.Size = new Size(89, 22);
            label4.TabIndex = 6;
            label4.Text = "Password :";
            // 
            // TxtPassword
            // 
            TxtPassword.Location = new Point(338, 182);
            TxtPassword.Name = "TxtPassword";
            TxtPassword.PasswordChar = '*';
            TxtPassword.Size = new Size(239, 23);
            TxtPassword.TabIndex = 5;
            TxtPassword.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Palatino Linotype", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(331, 78);
            label3.Name = "label3";
            label3.Size = new Size(64, 26);
            label3.TabIndex = 4;
            label3.Text = "Login";
            // 
            // TxtUsername
            // 
            TxtUsername.Location = new Point(338, 134);
            TxtUsername.Name = "TxtUsername";
            TxtUsername.Size = new Size(239, 23);
            TxtUsername.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(239, 132);
            label2.Name = "label2";
            label2.Size = new Size(93, 22);
            label2.TabIndex = 2;
            label2.Text = "Username :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Palatino Linotype", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(274, 33);
            label1.Name = "label1";
            label1.Size = new Size(216, 28);
            label1.TabIndex = 1;
            label1.Text = "ABC CAR TRADERS";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(679, 464);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label4;
        private TextBox TxtPassword;
        private Label label3;
        private TextBox TxtUsername;
        private Label label2;
        private Label label1;
        private Button BtnExit;
        private Button BtnCreateUser;
        private Button BtnLogin;
        private Panel panel2;
        private RadioButton RadioCustomer;
        private RadioButton RadioAdmin;
    }
}