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
    public partial class Car_Catagory : Form
    {
        public object Dvg { get; private set; }

        public Car_Catagory()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        public void LoadCars()
        {
            int i = 0;
            Dgv.Rows.Clear();
            db.cn.Open();
            db.cm = new System.Data.SqlClient.SqlCommand("select * from tbl_car", db.cn);
            db.dr = db.cm.ExecuteReader();
            while (db.dr.Read())
            {
                i++;
                Dgv.Rows.Add(db.dr[0], i, db.dr[1], db.dr[2], db.dr[3], db.dr[4]);
                //add data to priceCol
                Dgv.Rows[Dgv.Rows.Count - 1].Cells[8].Value = db.dr[6];
            }
            LblCount.Text = "Total Cars" + "(" + i.ToString() + ")";
            db.cn.Close();
        }
        private void Car_Catagory_Load(object sender, EventArgs e)
        {
            LoadCars();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add_Car f = new Add_Car(this);
            f.ShowDialog();
        }

        private void Dvg_Cellclick(object sender, DataGridViewCellEventArgs e)
        {
            string ColName = Dgv.Columns[e.ColumnIndex].Name;
            if (ColName == "ColEdit")
            {
                Add_Car f = new Add_Car(this);
                db._id = (int)Dgv.CurrentRow.Cells[1].Value;
                f.TxtCarname.Text = Dgv.CurrentRow.Cells[2].Value.ToString();//car name
                f.TxtCarcolor.Text = Dgv.CurrentRow.Cells[3].Value.ToString();//car color
                f.TxtCarmodel.Text = Dgv.CurrentRow.Cells[4].Value.ToString();
                f.textPrice.Text = Dgv.CurrentRow.Cells[8].Value.ToString();
                db.ShowImageinPictureBox(f.pic, Dgv, 5);
                f.BtnUpdate.Enabled = true;
                f.BtnCreate.Enabled = false;
                f.ShowDialog();

            }
            else if (ColName == "ColDelete")
            {
                db.cn.Open();
                db.cm = new System.Data.SqlClient.SqlCommand("delete from tbl_car where id like '" + Dgv.CurrentRow.Cells[0].Value + "'", db.cn);
                db.cm.ExecuteNonQuery();
                MessageBox.Show("Car Deleted Successfully");
                db.cn.Close();
                LoadCars();
            }
        }

        private void Dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
