namespace ABC_Car_Traders
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            panel1 = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            button2 = new Button();
            BtnNewcar = new Button();
            BtnMngparts = new Button();
            BtnMngOrders = new Button();
            BtnMngCustomer = new Button();
            panel2 = new Panel();
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.Azure;
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(990, 1070);
            panel1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackgroundImage = (Image)resources.GetObject("panel4.BackgroundImage");
            panel4.BackgroundImageLayout = ImageLayout.None;
            panel4.Location = new Point(321, 113);
            panel4.Name = "panel4";
            panel4.Size = new Size(666, 406);
            panel4.TabIndex = 8;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(button2);
            panel3.Controls.Add(BtnNewcar);
            panel3.Controls.Add(BtnMngparts);
            panel3.Controls.Add(BtnMngOrders);
            panel3.Controls.Add(BtnMngCustomer);
            panel3.Location = new Point(3, 113);
            panel3.Name = "panel3";
            panel3.Size = new Size(312, 406);
            panel3.TabIndex = 8;
            // 
            // button2
            // 
            button2.BackColor = Color.RoyalBlue;
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Palatino Linotype", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(3, 316);
            button2.Name = "button2";
            button2.Size = new Size(292, 62);
            button2.TabIndex = 7;
            button2.Text = "Reports";
            button2.UseVisualStyleBackColor = false;
            // 
            // BtnNewcar
            // 
            BtnNewcar.BackColor = Color.RoyalBlue;
            BtnNewcar.Cursor = Cursors.Hand;
            BtnNewcar.Font = new Font("Palatino Linotype", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnNewcar.ForeColor = Color.White;
            BtnNewcar.Location = new Point(3, 3);
            BtnNewcar.Name = "BtnNewcar";
            BtnNewcar.Size = new Size(292, 62);
            BtnNewcar.TabIndex = 3;
            BtnNewcar.Text = "Car Category";
            BtnNewcar.UseVisualStyleBackColor = false;
            BtnNewcar.Click += BtnNewcar_Click;
            // 
            // BtnMngparts
            // 
            BtnMngparts.BackColor = Color.RoyalBlue;
            BtnMngparts.Cursor = Cursors.Hand;
            BtnMngparts.Font = new Font("Palatino Linotype", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnMngparts.ForeColor = Color.White;
            BtnMngparts.Location = new Point(3, 71);
            BtnMngparts.Name = "BtnMngparts";
            BtnMngparts.Size = new Size(292, 62);
            BtnMngparts.TabIndex = 4;
            BtnMngparts.Text = "Manage Car Parts";
            BtnMngparts.UseVisualStyleBackColor = false;
            BtnMngparts.Click += BtnMngparts_Click;
            // 
            // BtnMngOrders
            // 
            BtnMngOrders.BackColor = Color.RoyalBlue;
            BtnMngOrders.Cursor = Cursors.Hand;
            BtnMngOrders.Font = new Font("Palatino Linotype", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnMngOrders.ForeColor = Color.White;
            BtnMngOrders.Location = new Point(3, 235);
            BtnMngOrders.Name = "BtnMngOrders";
            BtnMngOrders.Size = new Size(292, 62);
            BtnMngOrders.TabIndex = 6;
            BtnMngOrders.Text = "Manage Orders";
            BtnMngOrders.UseVisualStyleBackColor = false;
            BtnMngOrders.Click += BtnMngOrders_Click;
            // 
            // BtnMngCustomer
            // 
            BtnMngCustomer.BackColor = Color.RoyalBlue;
            BtnMngCustomer.Cursor = Cursors.Hand;
            BtnMngCustomer.Font = new Font("Palatino Linotype", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnMngCustomer.ForeColor = Color.White;
            BtnMngCustomer.Location = new Point(3, 151);
            BtnMngCustomer.Name = "BtnMngCustomer";
            BtnMngCustomer.Size = new Size(292, 62);
            BtnMngCustomer.TabIndex = 5;
            BtnMngCustomer.Text = "Customer Category";
            BtnMngCustomer.UseVisualStyleBackColor = false;
            BtnMngCustomer.Click += BtnMngCustomer_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Silver;
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(987, 108);
            panel2.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.RoyalBlue;
            button1.FlatAppearance.BorderColor = Color.Black;
            button1.Font = new Font("Palatino Linotype", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(960, 0);
            button1.Name = "button1";
            button1.Size = new Size(30, 33);
            button1.TabIndex = 7;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Palatino Linotype", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(378, 43);
            label2.Name = "label2";
            label2.Size = new Size(211, 44);
            label2.TabIndex = 7;
            label2.Text = "Admin Panel";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Palatino Linotype", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(333, 44);
            label1.TabIndex = 2;
            label1.Text = "ABC CAR TRADERS";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(1023, 547);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(1023, 547);
            Name = "Main";
            Text = "Main";
            Resize += Main_Resize;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button BtnNewcar;
        private Label label1;
        private Label label2;
        private Button BtnMngOrders;
        private Button BtnMngCustomer;
        private Button BtnMngparts;
        private Button button1;
        private Panel panel3;
        private Button button2;
        private Panel panel4;
    }
}