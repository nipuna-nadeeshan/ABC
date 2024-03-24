namespace ABC_Car_Traders
{
    partial class Add_Car
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Car));
            panel1 = new Panel();
            BtnLogin = new Button();
            label1 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            BtnUpdate = new Button();
            button2 = new Button();
            BtnCreate = new Button();
            pic = new PictureBox();
            TxtCarcolor = new TextBox();
            label5 = new Label();
            TxtCarmodel = new TextBox();
            label4 = new Label();
            label3 = new Label();
            TxtCarname = new TextBox();
            label2 = new Label();
            textPrice = new TextBox();
            label6 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic).BeginInit();
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
            panel1.Size = new Size(573, 88);
            panel1.TabIndex = 0;
            // 
            // BtnLogin
            // 
            BtnLogin.BackColor = Color.LightSkyBlue;
            BtnLogin.Cursor = Cursors.Hand;
            BtnLogin.FlatStyle = FlatStyle.Flat;
            BtnLogin.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnLogin.Location = new Point(537, 0);
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
            label1.Location = new Point(28, 24);
            label1.Name = "label1";
            label1.Size = new Size(124, 37);
            label1.TabIndex = 3;
            label1.Text = "Add Car";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Silver;
            panel2.Controls.Add(label6);
            panel2.Controls.Add(textPrice);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(BtnUpdate);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(BtnCreate);
            panel2.Controls.Add(pic);
            panel2.Controls.Add(TxtCarcolor);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(TxtCarmodel);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(TxtCarname);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(12, 106);
            panel2.Name = "panel2";
            panel2.Size = new Size(570, 388);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.BackgroundImageLayout = ImageLayout.None;
            panel3.Location = new Point(3, 16);
            panel3.Name = "panel3";
            panel3.Size = new Size(201, 171);
            panel3.TabIndex = 2;
            // 
            // BtnUpdate
            // 
            BtnUpdate.BackColor = Color.LightSkyBlue;
            BtnUpdate.Cursor = Cursors.Hand;
            BtnUpdate.FlatAppearance.BorderColor = Color.White;
            BtnUpdate.FlatAppearance.BorderSize = 2;
            BtnUpdate.FlatAppearance.MouseDownBackColor = Color.Cyan;
            BtnUpdate.FlatAppearance.MouseOverBackColor = Color.Cyan;
            BtnUpdate.FlatStyle = FlatStyle.Flat;
            BtnUpdate.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnUpdate.Location = new Point(434, 334);
            BtnUpdate.Name = "BtnUpdate";
            BtnUpdate.Size = new Size(103, 42);
            BtnUpdate.TabIndex = 12;
            BtnUpdate.Text = "Update";
            BtnUpdate.UseVisualStyleBackColor = false;
            BtnUpdate.Click += BtnUpdate_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.LightSkyBlue;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderColor = Color.DarkSlateGray;
            button2.FlatAppearance.BorderSize = 2;
            button2.FlatAppearance.MouseDownBackColor = Color.Cyan;
            button2.FlatAppearance.MouseOverBackColor = Color.Cyan;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Palatino Linotype", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(299, 298);
            button2.Name = "button2";
            button2.Size = new Size(154, 30);
            button2.TabIndex = 11;
            button2.Text = "Load Image";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
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
            BtnCreate.Location = new Point(235, 334);
            BtnCreate.Name = "BtnCreate";
            BtnCreate.Size = new Size(157, 42);
            BtnCreate.TabIndex = 10;
            BtnCreate.Text = "Add New Car";
            BtnCreate.UseVisualStyleBackColor = false;
            BtnCreate.Click += button1_Click;
            // 
            // pic
            // 
            pic.Location = new Point(299, 200);
            pic.Name = "pic";
            pic.Size = new Size(252, 92);
            pic.TabIndex = 8;
            pic.TabStop = false;
            // 
            // TxtCarcolor
            // 
            TxtCarcolor.Location = new Point(299, 62);
            TxtCarcolor.Name = "TxtCarcolor";
            TxtCarcolor.Size = new Size(252, 23);
            TxtCarcolor.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(210, 60);
            label5.Name = "label5";
            label5.Size = new Size(91, 22);
            label5.TabIndex = 6;
            label5.Text = "Car Color :";
            // 
            // TxtCarmodel
            // 
            TxtCarmodel.Location = new Point(299, 108);
            TxtCarmodel.Name = "TxtCarmodel";
            TxtCarmodel.Size = new Size(252, 23);
            TxtCarmodel.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(210, 106);
            label4.Name = "label4";
            label4.Size = new Size(97, 22);
            label4.TabIndex = 4;
            label4.Text = "Car Model :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(210, 214);
            label3.Name = "label3";
            label3.Size = new Size(95, 22);
            label3.TabIndex = 2;
            label3.Text = "Car Image :";
            // 
            // TxtCarname
            // 
            TxtCarname.Location = new Point(299, 16);
            TxtCarname.Name = "TxtCarname";
            TxtCarname.Size = new Size(252, 23);
            TxtCarname.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(210, 14);
            label2.Name = "label2";
            label2.Size = new Size(93, 22);
            label2.TabIndex = 0;
            label2.Text = "Car Name :";
            // 
            // textPrice
            // 
            textPrice.Location = new Point(299, 155);
            textPrice.Name = "textPrice";
            textPrice.Size = new Size(252, 23);
            textPrice.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(219, 156);
            label6.Name = "label6";
            label6.Size = new Size(55, 22);
            label6.TabIndex = 14;
            label6.Text = "Price :";
            // 
            // Add_Car
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(597, 546);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Add_Car";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add_Car";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        public TextBox TxtCarcolor;
        private Label label5;
        private Label label4;
        private Label label3;
        public TextBox TxtCarname;
        private Label label2;
        private Button BtnLogin;
        public Button BtnUpdate;
        public PictureBox pic;
        public TextBox TxtCarmodel;
        public Button BtnCreate;
        public Button button2;
        private Panel panel3;
        private Label label6;
        public TextBox textPrice;
    }
}