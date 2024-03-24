namespace ABC_Car_Traders
{
    partial class CustomerMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerMain));
            label2 = new Label();
            panel2 = new Panel();
            button1 = new Button();
            label1 = new Label();
            panel4 = new Panel();
            BtnNewcar = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Palatino Linotype", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(378, 43);
            label2.Name = "label2";
            label2.Size = new Size(250, 44);
            label2.TabIndex = 7;
            label2.Text = "Customer Panel";
            label2.Click += label2_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Silver;
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(70, 32);
            panel2.Name = "panel2";
            panel2.Size = new Size(987, 108);
            panel2.TabIndex = 1;
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
            // panel4
            // 
            panel4.BackgroundImage = (Image)resources.GetObject("panel4.BackgroundImage");
            panel4.BackgroundImageLayout = ImageLayout.None;
            panel4.Location = new Point(394, 156);
            panel4.Name = "panel4";
            panel4.Size = new Size(666, 406);
            panel4.TabIndex = 9;
            // 
            // BtnNewcar
            // 
            BtnNewcar.BackColor = Color.RoyalBlue;
            BtnNewcar.Cursor = Cursors.Hand;
            BtnNewcar.Font = new Font("Palatino Linotype", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnNewcar.ForeColor = Color.White;
            BtnNewcar.Location = new Point(70, 156);
            BtnNewcar.Name = "BtnNewcar";
            BtnNewcar.Size = new Size(292, 62);
            BtnNewcar.TabIndex = 10;
            BtnNewcar.Text = "Car search";
            BtnNewcar.UseVisualStyleBackColor = false;
            BtnNewcar.Click += BtnNewcar_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.RoyalBlue;
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Palatino Linotype", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(70, 236);
            button2.Name = "button2";
            button2.Size = new Size(292, 62);
            button2.TabIndex = 11;
            button2.Text = "Carparts search";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.RoyalBlue;
            button3.Cursor = Cursors.Hand;
            button3.Font = new Font("Palatino Linotype", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(70, 316);
            button3.Name = "button3";
            button3.Size = new Size(292, 62);
            button3.TabIndex = 12;
            button3.Text = "Place order";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.RoyalBlue;
            button4.Cursor = Cursors.Hand;
            button4.Font = new Font("Palatino Linotype", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(70, 402);
            button4.Name = "button4";
            button4.Size = new Size(292, 62);
            button4.TabIndex = 13;
            button4.Text = "Order status";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // CustomerMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1092, 584);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(BtnNewcar);
            Controls.Add(panel4);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CustomerMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CustomerMain";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label2;
        private Panel panel2;
        private Button button1;
        private Label label1;
        private Panel panel4;
        private Button BtnNewcar;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}