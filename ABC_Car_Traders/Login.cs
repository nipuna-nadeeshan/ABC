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
    public partial class Login : Form
    {
        bool isAdmin = true;
        public Login()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            {
                if (TxtUsername.Text == "")
                {
                    MessageBox.Show("Please Enter Username");
                    TxtUsername.Select();
                    return;
                }
                else if (TxtPassword.Text == "")
                {
                    MessageBox.Show("Please Enter Password");
                    TxtPassword.Select();
                    return;
                }
            }
            db.cn.Open();
            db.cm = new System.Data.SqlClient.SqlCommand("select * from tbl_user where Username like'" + TxtUsername.Text + "' and Password like '" + TxtPassword.Text + "'", db.cn);
            db.dr = db.cm.ExecuteReader();
            if (db.dr.HasRows)
            {
                //check if radio customer button ticked
                
                
                if (RadioAdmin.Checked)
                {
                    Main f = new Main();
                    f.Show();
                    this.Hide();
                }
                else
                {
                    CustomerMain f = new CustomerMain();
                    f.Show();
                    this.Hide();
                }
                
            }
            db.cn.Close();

        }

        private void BtnCreateUser_Click(object sender, EventArgs e)
        {
            Create_User f = new Create_User();
            f.Show();
        }

        private void RadioAdmin_CheckedChanged(object sender, EventArgs e)
        {
            isAdmin = true;
        }

        private void RadioCustomer_CheckedChanged(object sender, EventArgs e)
        {
            //give a alert message
            Console.WriteLine("Customer Login");
            isAdmin = false;
        }
    }
}