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
    public partial class Carpart_Details : Form
    {
        public Carpart_Details()
        {
            InitializeComponent();
            loadCarParts();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            Dispose();
        }
        public void loadCarParts()
        {

            //if id box is empty
            if (idBox.Text == "")
            {
                db.cn.Open();
                db.cm.CommandText = "SELECT id,Carpart_name,Carpart_Model,price FROM tbl_carparts WHERE Carpart_name LIKE '%" + nameBox.Text + "%' AND Carpart_Model LIKE '%" + modelBox.Text + "%'";
                db.dr = db.cm.ExecuteReader();
                //fill dgv table
                DataTable dt = new DataTable();
                dt.Load(db.dr);
                Dgv.DataSource = dt;
                db.cn.Close();

                return;
            }
            else
            {
                try
                {
                    int id = Convert.ToInt32(idBox.Text);
                    //check if the car exists
                    db.cn.Open();
                    db.cm.CommandText = "SELECT id,Carpart_name,Carpart_Model,price FROM tbl_carparts WHERE ID = " + id;
                    db.dr = db.cm.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(db.dr);
                    Dgv.DataSource = dt;
                    db.cn.Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadCarParts();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //clear fields
            idBox.Text = "";
            nameBox.Text = "";
            modelBox.Text = "";
        }
    }
}
