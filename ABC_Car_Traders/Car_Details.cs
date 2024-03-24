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
    public partial class Car_Details : Form
    {
        public Car_Details()
        {
            InitializeComponent();
            loadCars();
        }

        public void loadCars()
        {
            //check if id is empty
            if (textID.Text == "")
            {
                db.cn.Open();
                db.cm.CommandText = "SELECT id,Car_name,Car_color,Car_Model,price FROM tbl_car WHERE Car_name LIKE '%" + textName.Text + "%' AND Car_Model LIKE '%" + textModel.Text + "%' AND Car_color LIKE '%" + colorBox.Text + "%'";
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
                    int id = Convert.ToInt32(textID.Text);
                    //check if the car exists
                    db.cn.Open();
                    db.cm.CommandText = "SELECT id,Car_name,Car_color,Car_Model,price FROM tbl_car WHERE ID = " + id;
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

        private void button1_Click(object sender, EventArgs e)
        {
            loadCars();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //clear fields
            textName.Clear();
            textModel.Clear();
            textID.Clear();

        }

        private void textName_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void Dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
