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
    public partial class Add_Order : Form
    {   
        int[] priceList = new int[100];
        public Add_Order()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            //getselectedindex from combobox2
            int index = comboBox2.SelectedIndex;
            double price = priceList[index];
            int qty  = Convert.ToInt32(qtyBox.Text);
            //create order and get id of created order
            
            int id = -1;
            db.cn.Open();
            db.cm.CommandText = "INSERT INTO tbl_order (order_date,status,order_amount,description) VALUES ('" + dateTimePicker1.Value + "','pending'," + (price*qty) + ",'"+comboBox2.SelectedItem+" X "+qty+"')";
            db.cm.ExecuteNonQuery();
            db.cm.CommandText = "SELECT MAX(order_id) FROM tbl_order";
            db.dr = db.cm.ExecuteReader();
            if (db.dr.Read())
            {
                id = Convert.ToInt32(db.dr[0]);
                //crearte a record in table payment
                db.cm.CommandText = "INSERT INTO tbl_payment (order_id,payment_amount,payment_type) VALUES (" + id + "," +(price*qty)+ ",'" + comboBox3.SelectedItem + "')";

            }
            db.cn.Close();
   

        }
        public void loadModels()
        {

            db.cn.Open();
            db.cm.CommandText = "SELECT * FROM tbl_cars";
            db.dr = db.cm.ExecuteReader();
            int i = 0;
            while (db.dr.Read())
            {
                comboBox1.Items.Add(db.dr["id"].ToString());
                priceList[i] = Convert.ToInt32(db.dr["price"]);
                i++;
            }
            db.cn.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //get if the value is car or carpart
            if(comboBox1.Text == "Car")
            {
                db.cn.Open();
                db.cm.CommandText = "SELECT * FROM tbl_car";
                db.dr = db.cm.ExecuteReader();
                int i = 0;
                while (db.dr.Read())
                {
                    comboBox2.Items.Add(db.dr["Car_name"].ToString());
                    priceList[i] = Convert.ToInt32(db.dr["price"]);
                    i++;
                }
                db.cn.Close();
            }
            else
            {
                db.cn.Open();
                db.cm.CommandText = "SELECT * FROM tbl_carparts";
                db.dr = db.cm.ExecuteReader();
                int i = 0;
                while (db.dr.Read())
                {
                    comboBox2.Items.Add(db.dr["Carpart_name"].ToString());
                    priceList[i] = Convert.ToInt32(db.dr["price"]);
                    i++;
                }
                db.cn.Close();
            }   
        }
    }
}
