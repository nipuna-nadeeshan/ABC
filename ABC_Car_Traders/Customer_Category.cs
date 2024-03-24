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
    public partial class Customer_Category : Form
    {
        public Customer_Category()
        {
            InitializeComponent();
            LoadCustomer();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add_Customer f = new Add_Customer(this);
            f.ShowDialog();
            Dispose();
        }
        public void LoadCustomer()
        {
            int i = 0;
            Dgv.Rows.Clear();
            db.cn.Open();
            db.cm = new System.Data.SqlClient.SqlCommand("select * from tbl_customer", db.cn);
            db.dr = db.cm.ExecuteReader();
            while (db.dr.Read())
            {
                i++;
                Dgv.Rows.Add(db.dr[0], i, db.dr[1], db.dr[2], db.dr[3], db.dr[4], db.dr[5]);
            }
            LblCount.Text = "Total Customers " + "(" + i.ToString() + ")";
            db.cn.Close();


        }

        private void Customer_Category_Load(object sender, EventArgs e)
        {
            LoadCustomer();
        }

        private void Dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string ColName = Dgv.Columns[e.ColumnIndex].Name;
            if (ColName == "ColEdit")
            {
                db._id = (int)Dgv.CurrentRow.Cells[0].Value;
                Add_Customer f = new Add_Customer(this);
                f.TxtAddress.Text = Dgv.CurrentRow.Cells[2].Value.ToString();//TxtName
                f.TxtAddress.Text = Dgv.CurrentRow.Cells[2].Value.ToString();//TxtId
                f.TxtCusCon.Text = Dgv.CurrentRow.Cells[2].Value.ToString();
                f.TxtAddress.Text = Dgv.CurrentRow.Cells[2].Value.ToString();
                db.ShowImageinPictureBox(f.pic, Dgv, 6);
                f.BtnCreate.Enabled = false;
                f.BtnUpdate.Enabled = true;
                f.ShowDialog();
            }
            else if (ColName == "ColDelete")
            {
                db.cn.Open();
                db.cm = new System.Data.SqlClient.SqlCommand("Delete from tbl_customer where id=@id", db.cn);
                db.cm.Parameters.AddWithValue("@id", Dgv.CurrentRow.Cells[0].Value);
                db.cm.ExecuteNonQuery();
                MessageBox.Show("Customer Deleted Successfully");
                db.cn.Close();
                LoadCustomer();
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
