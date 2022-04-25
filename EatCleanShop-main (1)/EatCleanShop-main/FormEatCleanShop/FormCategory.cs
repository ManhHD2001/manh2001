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
    public partial class FormCategory : Form
    {
        string flag;
        public FormCategory()
        {
            InitializeComponent();
        }

        private void FormCategory_Load(object sender, EventArgs e)
        {
            LoadCategory();
            LockControl();
        }
        private void LoadCategory()
        {
            string constr = ConfigurationManager.ConnectionStrings["btl_hsk"].ConnectionString;
            SqlConnection sp = new SqlConnection(constr);
            sp.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select *from viewCategory", sp);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            gvCategory.DataSource = dt;
            sqlDataAdapter.Dispose();
        }

        public void LockControl()
        {
            btAdd.Enabled = true;
            btDel.Enabled = true;
            btnSave.Enabled = false;
            btBack.Enabled = true;

            txtIDCategory.ReadOnly = true;
            txtNameCategory.ReadOnly = true;
            
            txtIDCategory.Focus();
        }

        public void UnLockControl()
        {
            btAdd.Enabled = false;
            btDel.Enabled = false;
            btnSave.Enabled = true;
            btBack.Enabled = false;

            txtIDCategory.ReadOnly = false;
            txtNameCategory.ReadOnly = false;

            txtIDCategory.Focus();
        }

        private void gvCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIDCategory.Text = gvCategory.CurrentRow.Cells["ID"].Value.ToString();
            txtNameCategory.Text = gvCategory.CurrentRow.Cells["Category"].Value.ToString();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            UnLockControl();
            flag = "Them";

            txtIDCategory.Text = "";
            txtNameCategory.Text = "";

        }

        public bool check()
        {
            if (string.IsNullOrWhiteSpace(txtIDCategory.Text))
            {
                MessageBox.Show("You haven't typed ID Category yet ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtIDCategory.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtNameCategory.Text))
            {
                MessageBox.Show("You haven't typed Name Category yet", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNameCategory.Focus();
                return false;
            }
            return true;
        }

            private void btDel_Click(object sender, EventArgs e)
        {
            if (gvCategory.Rows.Count <= 0)
                return;
            if (MessageBox.Show("Do you want to delete this category?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            string constr = ConfigurationManager.ConnectionStrings["btl_hsk"].ConnectionString;
            SqlConnection sp = new SqlConnection(constr);
            sp.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sp;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "xoa_loai";
            cmd.Parameters.AddWithValue("@id", int.Parse(txtIDCategory.Text));
            cmd.Parameters.AddWithValue("@tenloai", txtNameCategory.Text);
            int i = cmd.ExecuteNonQuery();
            if (i > 0)
            {
                MessageBox.Show("Delete success!");
                LoadCategory();
            }
            else
            {
                MessageBox.Show("Error!");

            }
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            FormMenu menu = new FormMenu();
            menu.Show();
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (flag == "Them")
            {
                if (check())
                {
                    string constr = ConfigurationManager.ConnectionStrings["btl_hsk"].ConnectionString;
                    SqlConnection sp = new SqlConnection(constr);
                    sp.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = sp;
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "them_loai";
                    cmd.Parameters.AddWithValue("@id", int.Parse(txtIDCategory.Text));
                    cmd.Parameters.AddWithValue("@tenloai", txtNameCategory.Text);
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Add success!", "Notification");
                        LoadCategory();
                    }
                    else
                    {
                        MessageBox.Show("Error!");
                    }
                }
            }
            LockControl();
        }
    }
}
