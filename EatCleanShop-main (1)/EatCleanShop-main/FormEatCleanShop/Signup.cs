using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace FormEatCleanShop
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }
     
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtPass.Text != txtConf.Text)
            {
                MessageBox.Show("Mật khẩu không giống nhau!", "ERROR");
            }
            else
            {
                SqlConnection conn = new SqlConnection();
                try
                {
                    conn.ConnectionString = ConfigurationManager.ConnectionStrings["btl_hsk"].ConnectionString;
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "them_admin";
                    cmd.Parameters.AddWithValue("@ma_admin", txtIdAdmin.Text);
                    cmd.Parameters.AddWithValue("@hoten", txtFullName.Text);
                    cmd.Parameters.AddWithValue("@tenlogin", txtUserName.Text);
                    cmd.Parameters.AddWithValue("@matkhau", txtPass.Text);
                    cmd.Parameters.AddWithValue("@mail", txtEmail.Text);
                    cmd.Connection = conn;
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Sign up success!", "Notification");
                        Login login = new Login();
                        this.Hide();
                        login.Show();
                    }
                    else
                    {
                        MessageBox.Show("Error!");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

       
    }
}
