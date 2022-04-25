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
    public partial class FormReview : Form
    {
        string flag;
        public FormReview()
        {
            InitializeComponent();
        }
        public void LoadDataGridViewReview()
        {
            string contr = ConfigurationManager.ConnectionStrings["btl_hsk"].ConnectionString;
            SqlConnection danhgia = new SqlConnection(contr);
            danhgia.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = new SqlCommand("select *from viewListReview", danhgia);
            DataTable tb = new DataTable();
            sqlDataAdapter.Fill(tb);
            dgvReview.DataSource = tb;
        }

        public void LoadListProduct()
        {
            string contr = ConfigurationManager.ConnectionStrings["btl_hsk"].ConnectionString;
            SqlConnection sp = new SqlConnection(contr);
            sp.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select *from tbl_product", sp);
            DataTable tb = new DataTable();
            sqlDataAdapter.Fill(tb);
            cboID_product.DataSource = tb;
            cboID_product.DisplayMember = "id_product";
            cboID_product.ValueMember = "name_product";
        }

        public void LoadListUser()
        {
            string contr = ConfigurationManager.ConnectionStrings["btl_hsk"].ConnectionString;
            SqlConnection lstuser = new SqlConnection(contr);
            lstuser.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select *from tbl_user", lstuser);
            DataTable tb = new DataTable();
            sqlDataAdapter.Fill(tb);
            cboID_User.DataSource = tb;
            cboID_User.DisplayMember = "id_user"; 
            cboID_User.ValueMember = "name_user";
        }
        public void LockControl()
        {
            btnAdd.Enabled = true;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            btnExit.Enabled = true;
            btnSave.Enabled = false;

            txtId_review.ReadOnly = true;
            cboID_User.Enabled = false;
            cboID_product.Enabled = false;
            txtcontent_review.ReadOnly = true;
            txtdate_review.Enabled = false;

            txtId_review.Focus();
        }

        public void UnLockControl()
        {
            btnAdd.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnExit.Enabled = false;
            btnSave.Enabled = true;

            txtId_review.ReadOnly = false;
            cboID_User.Enabled = true;
            cboID_product.Enabled = true;
            txtcontent_review.ReadOnly = false;
            txtdate_review.Enabled = true;

            txtId_review.Focus();
        }

        private void FormReview_Load(object sender, EventArgs e)
        {
            LoadDataGridViewReview();
            LoadListProduct();
            LoadListUser();
            LockControl();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            UnLockControl();
            flag = "Add";

            txtId_review.Text = "";
            txtcontent_review.Text = "";

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UnLockControl();
            flag = "Update";
        }

        private void dgvReview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId_review.Text = dgvReview.CurrentRow.Cells["Mã đánh giá"].Value.ToString();
            cboID_User.Text = dgvReview.CurrentRow.Cells["Tên khách hàng"].Value.ToString();
            cboID_product.Text = dgvReview.CurrentRow.Cells["Tên sản phẩm"].Value.ToString();
            txtcontent_review.Text = dgvReview.CurrentRow.Cells["Nội dung đánh giá"].Value.ToString();
            txtdate_review.Text = dgvReview.CurrentRow.Cells["Ngày đánh giá"].Value.ToString();
        }

        public bool check()
        {
            if (string.IsNullOrWhiteSpace(txtId_review.Text))
            {
                MessageBox.Show("You haven't type ID Review yet", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtId_review.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtcontent_review.Text))
            {
                MessageBox.Show("You haven't type Content Review yet", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtcontent_review.Focus();
                return false;
            }
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (flag == "Add")
            {
                if (check())
                {
                    string contr = ConfigurationManager.ConnectionStrings["btl_hsk"].ConnectionString;
                    SqlConnection conn = new SqlConnection(contr);
                    conn.Open();
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "AddReviewUser";
                    cmd.Parameters.AddWithValue("@madg", txtId_review.Text);
                    cmd.Parameters.AddWithValue("@makh", cboID_User.Text);
                    cmd.Parameters.AddWithValue("@nddg", txtcontent_review.Text);
                    cmd.Parameters.AddWithValue("@ndg", Convert.ToDateTime(txtdate_review.Text).ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@masp", cboID_product.Text);
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Add Success");
                        LoadDataGridViewReview();

                    }
                    else
                    {
                        MessageBox.Show("Add Fail");
                    }
                }
            }
            else if (flag == "Update")
            {
                if (check())
                {
                    string id_review = dgvReview.CurrentRow.Cells["Mã đánh giá"].Value.ToString();
                    string contr = ConfigurationManager.ConnectionStrings["btl_hsk"].ConnectionString;
                    SqlConnection conn = new SqlConnection(contr);
                    conn.Open();
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "UpdateReviewUser";
                    cmd.Parameters.AddWithValue("@madg", id_review);
                    cmd.Parameters.AddWithValue("@makh", cboID_User.Text);
                    cmd.Parameters.AddWithValue("@nddg", txtcontent_review.Text);
                    cmd.Parameters.AddWithValue("@ndg", Convert.ToDateTime(txtdate_review.Text).ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@masp", cboID_product.Text);

                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Update Success");
                        LoadDataGridViewReview();
                    }
                    else
                    {
                        MessageBox.Show("Update Fail");
                    }
                }
            }
            LockControl();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string contr = ConfigurationManager.ConnectionStrings["btl_hsk"].ConnectionString;
            SqlConnection conn = new SqlConnection(contr);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "delete from tbl_review where id_review= '" + txtId_review.Text + "'";
            cmd.Parameters.AddWithValue("@madg", txtId_review.Text);
            cmd.Parameters.AddWithValue("@makh", cboID_User.Text);
            cmd.Parameters.AddWithValue("@masp", cboID_product.Text);
            cmd.Parameters.AddWithValue("@nddg", txtcontent_review.Text);
            cmd.Parameters.AddWithValue("@ndg", Convert.ToDateTime(txtdate_review.Text).ToString("yyyy-MM-dd"));

            int i = cmd.ExecuteNonQuery();
            if (i > 0)
            {
                if (MessageBox.Show("Do you want to delete this Review?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    LoadDataGridViewReview();
            }
            else
            {
                MessageBox.Show("Delete Fail");
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit now ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Close();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            string contr = ConfigurationManager.ConnectionStrings["btl_hsk"].ConnectionString;
            SqlConnection conn = new SqlConnection(contr);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select id_review as[Mã đánh giá],tbl_user.name_user as[Tên khách hàng],tbl_product.name_product as[Tên sản phẩm],content as[Nội dung đánh giá],date_review as[Ngày đánh giá] from tbl_review inner join tbl_user on tbl_review.id_user = tbl_user.id_user inner join tbl_product on tbl_review.id_product = tbl_product.id_product where year(tbl_review.date_review) = @ndg";
            cmd.Parameters.AddWithValue("@ndg", txtsearch.Text);
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable tb = new DataTable();
            tb.Load(dr);
            dgvReview.DataSource = tb;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
                FormMenu menu = new FormMenu();
                menu.Show();
                this.Hide();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintReview print = new PrintReview();
            print.Show();
        }
    }
}
