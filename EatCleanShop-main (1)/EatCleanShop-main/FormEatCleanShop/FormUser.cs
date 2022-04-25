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
    public partial class FormUser : Form
    {
        string flag;
        public FormUser()
        {
            InitializeComponent();
        }

        private void FormUser_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
            LockControl();
        }
        public void LoadDataGridView()
        {

            string contr = ConfigurationManager.ConnectionStrings["btl_hsk"].ConnectionString;
            SqlConnection conn = new SqlConnection(contr);
            conn.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = new SqlCommand("select *from viewListUser", conn);
            DataTable tb = new DataTable();
            sqlDataAdapter.Fill(tb);
            dgvUser.DataSource = tb;
        }

        public void LockControl()
        {
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            btnBack.Enabled = true;

            txtIdUser.ReadOnly = true;
            txtname_user.ReadOnly = true;
            txtdob.Enabled = false;
            txtaddress.ReadOnly = true;
            txtsex.ReadOnly = true;
            txtphone_number.ReadOnly = true;

            txtIdUser.Focus();
        }

        public void UnLockControl()
        {
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnBack.Enabled = false;

            txtIdUser.ReadOnly = false;
            txtname_user.ReadOnly = false;
            txtdob.Enabled = true;
            txtaddress.ReadOnly = false;
            txtsex.ReadOnly = false;
            txtphone_number.ReadOnly = false;

            txtIdUser.Focus();
        }

        public bool check()
        {
            if (string.IsNullOrWhiteSpace(txtIdUser.Text))
            {
                MessageBox.Show("You haven't typed ID User yet ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtIdUser.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtname_user.Text))
            {
                MessageBox.Show("You haven't typed Name User yet", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtname_user.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtaddress.Text))
            {
                MessageBox.Show("You haven't typed Address yet", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtaddress.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtsex.Text))
            {
                MessageBox.Show("You haven't typed Sex yet", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtsex.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtphone_number.Text))
            {
                MessageBox.Show("You haven't typed Phone number yet", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtphone_number.Focus();
                return false;
            }
            return true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            UnLockControl();
            flag = "Add";

            txtIdUser.Text = "";
            txtname_user.Text = "";
            txtsex.Text = "";
            txtaddress.Text = "";
            txtphone_number.Text = "";
        }

        private void dgvUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdUser.Text = dgvUser.CurrentRow.Cells["Mã khách hàng"].Value.ToString();
            txtname_user.Text = dgvUser.CurrentRow.Cells["Tên khách hàng"].Value.ToString();
            txtdob.Text = dgvUser.CurrentRow.Cells["Ngày sinh"].Value.ToString();
            txtaddress.Text = dgvUser.CurrentRow.Cells["Địa chỉ"].Value.ToString();
            txtsex.Text = dgvUser.CurrentRow.Cells["Giới tính"].Value.ToString();
            txtphone_number.Text = dgvUser.CurrentRow.Cells["Số điện thoại"].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            UnLockControl();
            flag = "Update";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string contr = ConfigurationManager.ConnectionStrings["btl_hsk"].ConnectionString;
            SqlConnection conn = new SqlConnection(contr);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "delete from tbl_user where id_user= '" + txtIdUser.Text + "'";
            cmd.Parameters.AddWithValue("@makh", txtIdUser.Text);
            cmd.Parameters.AddWithValue("@tenkh", txtname_user.Text);
            cmd.Parameters.AddWithValue("@ns", Convert.ToDateTime(txtdob.Text).ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@dchi", txtaddress.Text);
            cmd.Parameters.AddWithValue("@gt", txtsex.Text);
            cmd.Parameters.AddWithValue("@sdt", txtphone_number.Text);
            int i = cmd.ExecuteNonQuery();
            if (i > 0)
            {
                if (MessageBox.Show("Do you want to delete User ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    LoadDataGridView();
            }
            else
            {
                MessageBox.Show("Delete Fail");
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
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
                    cmd.CommandText = "Addkh";
                    cmd.Parameters.AddWithValue("@makh", txtIdUser.Text);
                    cmd.Parameters.AddWithValue("@tenkh", txtname_user.Text);
                    cmd.Parameters.AddWithValue("@ns", Convert.ToDateTime(txtdob.Text).ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@dchi", txtaddress.Text);
                    cmd.Parameters.AddWithValue("@gt", txtsex.Text);
                    cmd.Parameters.AddWithValue("@sdt", txtphone_number.Text);

                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Add Success");
                        LoadDataGridView();
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
                    string ma = dgvUser.CurrentRow.Cells["Mã khách hàng"].Value.ToString();
                    string contr = ConfigurationManager.ConnectionStrings["btl_hsk"].ConnectionString;
                    SqlConnection conn = new SqlConnection(contr);
                    conn.Open();
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "UpdateUser";
                    cmd.Parameters.AddWithValue("@makh", ma);
                    cmd.Parameters.AddWithValue("@tenkh", txtname_user.Text);
                    cmd.Parameters.AddWithValue("@ns", Convert.ToDateTime(txtdob.Text).ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@dchi", txtaddress.Text);
                    cmd.Parameters.AddWithValue("@gt", txtsex.Text);
                    cmd.Parameters.AddWithValue("@sdt", txtphone_number.Text);
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Update Success");
                        LoadDataGridView();
                    }
                    else
                    {
                        MessageBox.Show("Update Fail");
                    }
                }
            }
            LockControl();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FormMenu menu = new FormMenu();
            menu.Show();
            this.Hide();
        }
        private void FormUser_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (MessageBox.Show("Do you want to close Form?", "Notification",
                  MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true; //không đóng forrm nữa
        }
    }
}

