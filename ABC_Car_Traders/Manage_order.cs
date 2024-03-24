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
    public partial class Manage_order : Form
    {
        public void loadOrders()
        {

            int i = 0;
            //Dgv.Rows.Clear();
            db.cn.Open();
            db.cm = new System.Data.SqlClient.SqlCommand("select * from tbl_order", db.cn);
            db.dr = db.cm.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(db.dr);
            Dgv.DataSource = dt;
            db.cn.Close();
        }
        public Manage_order()
        {
            InitializeComponent();
            loadOrders();
        }

        private void Dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //get the clicked row
            int row = e.RowIndex;
            //get the id of the clicked row
            int id = Convert.ToInt32(Dgv.Rows[row].Cells[0].Value);
            //ask user to approve or decline order or cancel
            DialogResult dr = MessageBox.Show("Do you want to approve this order?", "Approve Order", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                //approve order
                db.cn.Open();
                db.cm.CommandText = "UPDATE tbl_order SET status = 'Approved' WHERE order_id = " + id;
                db.cm.ExecuteNonQuery();
                db.cn.Close();
                loadOrders();
            }
            else if (dr == DialogResult.No)
            {
                //decline order
                db.cn.Open();
                db.cm.CommandText = "UPDATE tbl_order SET status = 'Declined' WHERE order_id = " + id;
                db.cm.ExecuteNonQuery();
                db.cn.Close();
                loadOrders();
            }
            else
            {
                //cancel
                return;
            }

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void Manage_order_Load(object sender, EventArgs e)
        {

        }
    }
}
