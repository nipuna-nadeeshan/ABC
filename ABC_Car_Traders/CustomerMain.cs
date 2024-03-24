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
    public partial class CustomerMain : Form
    {
        public CustomerMain()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnNewcar_Click(object sender, EventArgs e)
        {
            Car_Details cardetails = new Car_Details();
            cardetails.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Carpart_Details carpartdetails = new Carpart_Details();
            carpartdetails.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Add_Order add_Order = new Add_Order();
            add_Order.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Order_Status order_Status = new Order_Status();
            order_Status.Show();
        }
    }
}
