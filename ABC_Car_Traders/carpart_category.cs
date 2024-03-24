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
    public partial class carpart_category : Form
    {
        public carpart_category()
        {
            InitializeComponent();
            LoadCarparts();
        }

        public void LoadCarparts()
        {
            int i = 0;
            Dgv.Rows.Clear();
            db.cn.Open();
            db.cm = new System.Data.SqlClient.SqlCommand("select * from tbl_carparts", db.cn);
            db.dr = db.cm.ExecuteReader();
            while (db.dr.Read())
            {
                i++;
                Dgv.Rows.Add(db.dr[0], i, db.dr[1], db.dr[2], db.dr[3], db.dr[4]);
                //add to 7nth col
                Dgv.Rows[Dgv.Rows.Count - 1].Cells[7].Value = db.dr[5];
            }
            LblCount.Text = "Total Car Parts" + "(" + i.ToString() + ")";
            db.cn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add_Carparts add_Carparts = new Add_Carparts(this);
            add_Carparts.ShowDialog();

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void Dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void Dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string ColName = Dgv.Columns[e.ColumnIndex].Name;
            if (ColName == "ColEdit")
            {
                Add_Carparts f = new Add_Carparts(this);
                db._id = (int)Dgv.CurrentRow.Cells[1].Value;
                f.TxtCarname.Text = Dgv.CurrentRow.Cells[2].Value.ToString();//car name
                f.TxtCarmodel.Text = Dgv.CurrentRow.Cells[4].Value.ToString();
                f.textprice.Text = Dgv.CurrentRow.Cells[7].Value.ToString();
                db.ShowImageinPictureBox(f.pic, Dgv, 4);
                f.BtnUpdate.Enabled = true;
                f.BtnCreate.Enabled = false;
                f.ShowDialog();

            }
            else if (ColName == "ColDelete")
            {
                db.cn.Open();
                db.cm = new System.Data.SqlClient.SqlCommand("delete from tbl_carparts where id like '" + Dgv.CurrentRow.Cells[0].Value + "'", db.cn);
                db.cm.ExecuteNonQuery();
                MessageBox.Show("Car Deleted Successfully");
                db.cn.Close();
                LoadCarparts();
            }
        }
    }
}
