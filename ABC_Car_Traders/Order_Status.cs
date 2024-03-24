using CSharp_ABC_Car_Traders;
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
    public partial class Order_Status : Form
    {
        string[] statusList = new string[100];
        public Order_Status()
        {
            InitializeComponent();
        }
        public void loadOrderIdsByDate()
        {
            //SELECT ALL ORDERS FOR GIVEN DATE

            db.cn.Open();
            db.cm.CommandText = "SELECT order_id,status FROM tbl_order WHERE order_date = '" + dateTimePicker1.Value + "'";
            db.dr = db.cm.ExecuteReader();
            //SET IDS TO COMBOX1
            int i = 0;
            while (db.dr.Read())
            {
                comboBox1.Items.Add(db.dr[0]);
                statusList[i] = db.dr[1].ToString();
            }
            db.cn.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            string status = statusList[comboBox1.SelectedIndex];
            //alert the status to the user
            MessageBox.Show("Status of order is " + status);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            loadOrderIdsByDate();

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void BtnLogin_Click_1(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
