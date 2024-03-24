using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABC_Car_Traders
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Resize(object sender, EventArgs e)
        {
            int height = Screen.PrimaryScreen.Bounds.Height;
            int width = Screen.PrimaryScreen.Bounds.Width;
            this.Width = width;
            this.Height = height;
            Top = 0;
            Left = 0;
            panel1.Width = width;
            panel1.Height = height;

        }

        private void BtnNewcar_Click(object sender, EventArgs e)
        {
            Car_Catagory f = new Car_Catagory();
            f.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMngCustomer_Click(object sender, EventArgs e)
        {
            Customer_Category f = new Customer_Category();
            f.ShowDialog();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void BtnMngparts_Click(object sender, EventArgs e)
        {
            carpart_category f = new carpart_category();
            f.ShowDialog();
        }

        private void BtnMngOrders_Click(object sender, EventArgs e)
        {
            Manage_order manage_Order = new Manage_order();
            manage_Order.ShowDialog();
        }
    }
}
