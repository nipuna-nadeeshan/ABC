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
    public partial class Add_Car : Form
    {
        Car_Catagory f = new Car_Catagory();
        public Add_Car(Car_Catagory f)
        {
            InitializeComponent();
            this.f = f;
        }

        public Add_Car()
        {
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            db.OpenImage(pic);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            db.cn.Open();
            db.cm = new System.Data.SqlClient.SqlCommand("insert into tbl_car(Car_name,Car_color,Car_model,Car_img , price) values (@Car_name,@Car_color,@Car_model,@Car_img , @price)", db.cn);
            db.cm.Parameters.AddWithValue("@Car_name", TxtCarname.Text);
            db.cm.Parameters.AddWithValue("@Car_color", TxtCarcolor.Text);
            db.cm.Parameters.AddWithValue("@Car_model", TxtCarmodel.Text);
            double price = Convert.ToDouble(textPrice.Text);
            db.cm.Parameters.AddWithValue("@price", price);
            db.ConvertImageToSave(pic);
            db.cm.Parameters.AddWithValue("@Car_img", db._img);
            db.cm.ExecuteNonQuery();
            MessageBox.Show("Car Added Successfully");
            db.cn.Close();
            TxtCarcolor.Clear();
            TxtCarmodel.Clear();
            TxtCarname.Clear();
            TxtCarname.Select();
            f.LoadCars();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            db.cn.Open();
            db.cm = new System.Data.SqlClient.SqlCommand("update tbl_car set Car_name=@Car_Name,Car_color=@Car_color,Car_model=@Car_model,Car_img=@Car_img , price=@price where id=@id", db.cn);
            db.cm.Parameters.AddWithValue("@id",db._id);
            db.cm.Parameters.AddWithValue("@Car_name", TxtCarname.Text);
            db.cm.Parameters.AddWithValue("@Car_color", TxtCarcolor.Text);
            db.cm.Parameters.AddWithValue("@Car_model", TxtCarmodel.Text);
            double price = Convert.ToDouble(textPrice.Text);
            db.cm.Parameters.AddWithValue("@price", price);
            db.ConvertImageToSave(pic);
            db.cm.Parameters.AddWithValue("@Car_img", db._img);
            db.cm.ExecuteNonQuery();
            MessageBox.Show("Car Updated Successfully");
            db.cn.Close();
            TxtCarcolor.Clear();
            TxtCarmodel.Clear();
            TxtCarname.Clear();
            TxtCarname.Select();
            f.LoadCars();
            Dispose();
        }
    }
}
