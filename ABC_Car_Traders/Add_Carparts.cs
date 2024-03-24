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
    public partial class Add_Carparts : Form
    {
        carpart_category f = new carpart_category();
        public Add_Carparts(carpart_category f)
        {
            InitializeComponent();
            this.f = f;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            db.cn.Open();
            db.cm = new System.Data.SqlClient.SqlCommand("insert into tbl_carparts(Carpart_name,Carpart_model,Carpart_img,price) values (@Carpart_name,@Carpart_model,@Carpart_img,@price)", db.cn);
            db.cm.Parameters.AddWithValue("@Carpart_name", TxtCarname.Text);
            db.cm.Parameters.AddWithValue("@Carpart_model", TxtCarmodel.Text);
            double price = Convert.ToDouble(textprice.Text);
            db.cm.Parameters.AddWithValue("@price", price);
            db.ConvertImageToSave(pic);
            db.cm.Parameters.AddWithValue("@Carpart_img", db._img);
            db.cm.ExecuteNonQuery();
            MessageBox.Show("Car Added Successfully");
            db.cn.Close();

            TxtCarmodel.Clear();
            TxtCarname.Clear();
            TxtCarname.Select();
            f.LoadCarparts();
        }

        private void pic_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            db.OpenImage(pic);
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            //UPDATE CARPART
            db.cn.Open();
            db.cm = new System.Data.SqlClient.SqlCommand("update tbl_carparts set Carpart_name=@Carpart_name,Carpart_model=@Carpart_model,Carpart_img=@Carpart_img,price=@price where id=@id", db.cn);
            db.cm.Parameters.AddWithValue("@id", db._id);
            db.cm.Parameters.AddWithValue("@Carpart_name", TxtCarname.Text);
            db.cm.Parameters.AddWithValue("@Carpart_model", TxtCarmodel.Text);
            double price = Convert.ToDouble(textprice.Text);
            db.cm.Parameters.AddWithValue("@price", price);
            db.ConvertImageToSave(pic);
            db.cm.Parameters.AddWithValue("@Carpart_img", db._img);
            db.cm.ExecuteNonQuery();
            MessageBox.Show("Car Updated Successfully");
            db.cn.Close();
            TxtCarmodel.Clear();
            TxtCarname.Clear();
            TxtCarname.Select();
            f.LoadCarparts();
            Dispose();
        }
    }
}
