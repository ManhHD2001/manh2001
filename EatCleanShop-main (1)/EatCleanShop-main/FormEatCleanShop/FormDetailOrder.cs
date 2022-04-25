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
    public partial class FormDetailOrder : Form
    {
        public FormDetailOrder()
        {
            InitializeComponent();
        }

        private void Load_DetailOrder()
        {
            string constr = ConfigurationManager.ConnectionStrings["btl_hsk"].ConnectionString;
            SqlConnection sp = new SqlConnection(constr);
            sp.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from viewDetailOrder", sp);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            dgvDetailOrder.DataSource = dt;
            sqlDataAdapter.Dispose();
        }

        private void LoadOrder()
        {
            string constr = ConfigurationManager.ConnectionStrings["btl_hsk"].ConnectionString;
            SqlConnection sp = new SqlConnection(constr);
            sp.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select *from tbl_order", sp);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            cboIDorder.DataSource = dt;
            cboIDorder.DisplayMember = "id_order";
            cboIDorder.ValueMember = "id_order";
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
            cboNameproduct.DataSource = dt;
            cboNameproduct.DisplayMember = "name_product";
            cboNameproduct.ValueMember = "id_product";
            sqlDataAdapter.Dispose();

        }

        private static bool checkmacthd(string id_detail)
        {
            string constr = ConfigurationManager.ConnectionStrings["btl_hsk"].ConnectionString;
            SqlConnection sp = new SqlConnection(constr);
            string sql = "select * from tbl_Order where id_detail='" + id_detail + "'";
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string constr = ConfigurationManager.ConnectionStrings["btl_hsk"].ConnectionString;
            SqlConnection sp = new SqlConnection(constr);
            sp.Open();
            string mahd = txtIdDetail.Text;

            if (checkmacthd(mahd))
            {
                MessageBox.Show("Id already exist!", "Notification");
                return;
            }
            else
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sp;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = @"add_chitietdh";
                cmd.Parameters.AddWithValue("@mactdh", txtIdDetail.Text);
                cmd.Parameters.AddWithValue("@madh", cboIDorder.SelectedValue);
                cmd.Parameters.AddWithValue("@masp", cboNameproduct.SelectedValue);
                cmd.Parameters.AddWithValue("@soluong", int.Parse(amount.Text));
                cmd.Parameters.AddWithValue("@ttien", int.Parse(txttotal.Text));

                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Add success!", "Notification");
                    Load_DetailOrder();
                    //Load_Order();
                }
                else
                {
                    MessageBox.Show("Error!");
                }
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dgvDetailOrder.Rows.Count <= 0)
                return;
            if (MessageBox.Show("Do you want to delete this detail order?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            string constr = ConfigurationManager.ConnectionStrings["btl_hsk"].ConnectionString;
            SqlConnection ctdh = new SqlConnection(constr);
            ctdh.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = ctdh;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = @"xoa_ctdh";
            cmd.Parameters.AddWithValue("@mactdh", txtIdDetail.Text);
            int i = cmd.ExecuteNonQuery();
            if (i > 0)
            {
                MessageBox.Show("Delete success!");
                Load_DetailOrder();
            }
            else
            {
                MessageBox.Show("Error!");

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvDetailOrder.Rows.Count <= 0)
                return;
            if (MessageBox.Show("Do you want update this product?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            string constr = ConfigurationManager.ConnectionStrings["btl_hsk"].ConnectionString;
            SqlConnection ctdh = new SqlConnection(constr);
            ctdh.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = ctdh;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = @"capnhat_ctdh";
            cmd.Parameters.AddWithValue("@mactdh", txtIdDetail.Text);
            cmd.Parameters.AddWithValue("@madh", cboIDorder.SelectedValue);
            cmd.Parameters.AddWithValue("@masp", cboNameproduct.SelectedValue);
            cmd.Parameters.AddWithValue("@soluong", int.Parse(amount.Text));
            cmd.Parameters.AddWithValue("@ttien", int.Parse(txttotal.Text));
            int i = cmd.ExecuteNonQuery();
            if (i > 0)
            {
                MessageBox.Show("Update success!");
                Load_DetailOrder();
            }
            else
            {
                MessageBox.Show("Error!");

            }
        }

        private void FormDetailOrder_Load(object sender, EventArgs e)
        {
            Load_DetailOrder();
            LoadOrder();
            LoadProduct();
        }

        private void cboNameproduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            string constr = ConfigurationManager.ConnectionStrings["btl_hsk"].ConnectionString;
            SqlConnection sp = new SqlConnection(constr);
            sp.Open();

            string sql = "Select price from tbl_product where id_product='" + cboNameproduct.SelectedValue.ToString() + "'";
            SqlCommand cmd = new SqlCommand(sql, sp);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                price.Text = dr["price"].ToString();
            }
            dr.Close();
            dr.Dispose();
        }

        private void amount_TextChanged(object sender, EventArgs e)
        {
            double sl, dg, tt;
            if (amount.Text == "")
                sl = 0;
            else
                sl = Convert.ToDouble(amount.Text);
            if (price.Text == "")
                dg = 0;
            else
                dg = Convert.ToDouble(price.Text);
            tt = sl * dg;
            txttotal.Text = tt.ToString();
        
    }

        private void dgvDetailOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdDetail.Text = dgvDetailOrder.CurrentRow.Cells["ID"].Value.ToString();
            cboIDorder.Text = dgvDetailOrder.CurrentRow.Cells["Order"].Value.ToString();
            cboNameproduct.Text = dgvDetailOrder.CurrentRow.Cells["Product"].Value.ToString();
            amount.Text = dgvDetailOrder.CurrentRow.Cells["Amount"].Value.ToString();
            txttotal.Text = dgvDetailOrder.CurrentRow.Cells["Total price"].Value.ToString();

        }
    }
}
