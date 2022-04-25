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
    public partial class FormDetail : Form
    {

        public FormDetail()
        {
            InitializeComponent();
        }
        public void LoadDataGridView()
        {
            string constr = ConfigurationManager.ConnectionStrings["btl_hsk"].ConnectionString;
            SqlConnection sp = new SqlConnection(constr);
            sp.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select *from viewDetailOrderInfor", sp);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            dgvDetailOrderInfor.DataSource = dt;
            sqlDataAdapter.Dispose();
        }

        public void LoadDataUser()
        {
            string constr = ConfigurationManager.ConnectionStrings["btl_hsk"].ConnectionString;
            SqlConnection sp = new SqlConnection(constr);
            sp.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select *from tbl_user", sp);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            cboNameUser.DataSource = dt;
            cboNameUser.DisplayMember = "name_user";
            cboNameUser.ValueMember = "id_user";
            sqlDataAdapter.Dispose();
        }

        private void LoadProduct()
        {
            string constr = ConfigurationManager.ConnectionStrings["btl_hsk"].ConnectionString;
            SqlConnection sp = new SqlConnection(constr);
            sp.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select *from tbl_product", sp);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            cboNameProduct.DataSource = dt;
            cboNameProduct.DisplayMember = "name_product";
            cboNameProduct.ValueMember = "id_product";
            sqlDataAdapter.Dispose();
        }

        private static bool checkmahd(string id_order)
        {
            string constr = ConfigurationManager.ConnectionStrings["btl_hsk"].ConnectionString;
            SqlConnection sp = new SqlConnection(constr);
            string sql = "select * from tbl_order where id_order='" + id_order + "'";
            sp.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sp;
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = sql;
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                sp.Close();
                return true;
            }
            else
            {
                sp.Close();
                return false;
            }
        }
        private void FormDetail_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
            LoadDataUser();
            LoadProduct();
        }

        private void cboNameUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            string constr = ConfigurationManager.ConnectionStrings["btl_hsk"].ConnectionString;
            SqlConnection sp = new SqlConnection(constr);
            sp.Open();

            string sql = "Select address_user,numberphone from tbl_user where id_user='" + cboNameUser.SelectedValue.ToString() + "'";
            SqlCommand cmd = new SqlCommand(sql, sp);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txtAddress.Text = dr["address_user"].ToString();
                txtPhonenumber.Text = dr["numberphone"].ToString();
            }
            dr.Close();
            dr.Dispose();

        }
        private void cboNameProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            string constr = ConfigurationManager.ConnectionStrings["btl_hsk"].ConnectionString;
            SqlConnection sp = new SqlConnection(constr);
            sp.Open();

            string sql = "select price from tbl_product where id_product='" + cboNameProduct.SelectedValue.ToString() + "'";
            SqlCommand cmd = new SqlCommand(sql, sp);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Price.Text = dr["price"].ToString();
            }
            dr.Close();
            dr.Dispose();
        }

        private void btnAddBI_Click(object sender, EventArgs e)
        {
            double tong, tongmoi, pr;
            if (txtsum.Text == "")
                tong = 0;
            else
                tong = Convert.ToDouble(txtsum.Text);
            pr = Convert.ToDouble(txtTotal.Text);
            tongmoi = tong + pr;

            string mahd = txtIdDetail.Text;
            if (checkmahd(mahd))
            {
                string constr = ConfigurationManager.ConnectionStrings["btl_hsk"].ConnectionString;
                SqlConnection sp = new SqlConnection(constr);
                sp.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sp;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = @"add_cthd";
                cmd.Parameters.AddWithValue("@mactdh", txtIdDetail.Text);
                cmd.Parameters.AddWithValue("@masp", cboNameProduct.SelectedValue);
                cmd.Parameters.AddWithValue("@soluong", int.Parse(Amount.Text));
                cmd.Parameters.AddWithValue("@ttien", int.Parse(txtTotal.Text));
                cmd.Parameters.AddWithValue("@sum", tongmoi);
                txtsum.Text = tongmoi.ToString();

                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Add success!", "Notification");
                    LoadDataGridView();

                }
                else
                {
                    MessageBox.Show("Error!");
                }
            }
            else
            {
                string constr = ConfigurationManager.ConnectionStrings["btl_hsk"].ConnectionString;
                SqlConnection sp = new SqlConnection(constr);
                sp.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sp;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = @"add_dh";
                cmd.Parameters.AddWithValue("@madh", txtIDOrder.Text);
                cmd.Parameters.AddWithValue("@makh", cboNameUser.SelectedValue);
                cmd.Parameters.AddWithValue("@dateorder", txtDateCreate.Text);
                cmd.Parameters.AddWithValue("@sum", tongmoi);
                cmd.Parameters.AddWithValue("@mactdh", txtIdDetail.Text);

                cmd.Parameters.AddWithValue("@masp", cboNameProduct.SelectedValue);
                cmd.Parameters.AddWithValue("@soluong", int.Parse(Amount.Text));
                cmd.Parameters.AddWithValue("@ttien", int.Parse(txtTotal.Text));

                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Add success!", "Notification");
                    LoadDataGridView();
                    //Load_Order();
                }
                else
                {
                    MessageBox.Show("Error!");
                }
            }

        }
        private void dgvDetailOrderInfor_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            txtIdDetail.Text = dgvDetailOrderInfor.CurrentRow.Cells["ID"].Value.ToString();
            txtIDOrder.Text = dgvDetailOrderInfor.CurrentRow.Cells["Order"].Value.ToString();
            txtDateCreate.Text = dgvDetailOrderInfor.CurrentRow.Cells["Date Create"].Value.ToString();
            cboNameUser.Text = dgvDetailOrderInfor.CurrentRow.Cells["Name User"].Value.ToString();
            cboNameProduct.Text = dgvDetailOrderInfor.CurrentRow.Cells["Product"].Value.ToString();
            Amount.Text = dgvDetailOrderInfor.CurrentRow.Cells["Amount"].Value.ToString();
            txtTotal.Text = dgvDetailOrderInfor.CurrentRow.Cells["Total price"].Value.ToString();

        }

        private void Amount_TextChanged(object sender, EventArgs e)
        {
            double sl, dg, tt;
            if (Amount.Text == "")
                sl = 0;
            else
                sl = Convert.ToDouble(Amount.Text);
            if (Price.Text == "")
                dg = 0;
            else
                dg = Convert.ToDouble(Price.Text);
            tt = sl * dg;
            txtTotal.Text = tt.ToString();
        }

        private void txtIDOrder_TextChanged(object sender, EventArgs e)
        {
            string constr = ConfigurationManager.ConnectionStrings["btl_hsk"].ConnectionString;
            SqlConnection sp = new SqlConnection(constr);
            sp.Open();

            string sql = "select total_price from tbl_order where id_order='" + txtIDOrder.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, sp);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txtsum.Text = dr["total_price"].ToString();
            }
            dr.Close();
            dr.Dispose();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string constr = ConfigurationManager.ConnectionStrings["btl_hsk"].ConnectionString;
            SqlConnection sp = new SqlConnection(constr);
            sp.Open();
            string idorder = txtIDOrder.Text;
            DateTime date = DateTime.Parse(txtDateCreate.Text);
            string sql = "select *from viewDetailOrderInfor where [Order]='" + idorder + "'";
            SqlDataAdapter ad = new SqlDataAdapter(sql, sp);
            DataTable data = new DataTable();
            ad.Fill(data);
            if (data.Rows.Count > 0)
            {
                dgvDetailOrderInfor.DataSource = data;
            }
            else
            {
                MessageBox.Show("Nothing!");
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintDetail print = new PrintDetail();
            print.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            double tong, tongmoi, pr;
            if (txtsum.Text == "")
                tong = 0;
            else
                tong = Convert.ToDouble(txtsum.Text);
            pr = Convert.ToDouble(txtTotal.Text);
            tongmoi = tong - pr;

            if (dgvDetailOrderInfor.Rows.Count <= 0)
                return;
            if (MessageBox.Show("Do you want to delete this detail ?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            string constr = ConfigurationManager.ConnectionStrings["btl_hsk"].ConnectionString;
            SqlConnection sp = new SqlConnection(constr);
            sp.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sp;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "xoa_ctdh";
            cmd.Parameters.AddWithValue("@madh", txtIDOrder.Text);
            cmd.Parameters.AddWithValue("@mactdh", txtIdDetail.Text);
            cmd.Parameters.AddWithValue("@sum", tongmoi);
            int i = cmd.ExecuteNonQuery();
            if (i > 0)
            {
                MessageBox.Show("Delete success!");
                LoadDataGridView();

            }
            else
            {
                MessageBox.Show("Error!");

            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            FormMenu menu = new FormMenu();
            menu.Show();
            this.Hide();
        }
    }
            
}
