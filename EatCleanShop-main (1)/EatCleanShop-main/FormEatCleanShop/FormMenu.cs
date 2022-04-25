using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormEatCleanShop
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCategory category = new FormCategory();
            category.Show();
            this.Hide();
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProduct product = new FormProduct();
            product.Show();
            this.Hide();
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUser user = new FormUser();
            user.Show();
            this.Hide();
        }

        private void reviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReview review = new FormReview();
            review.Show();
            this.Hide();
        }

        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDetail detail = new FormDetail();
            detail.Show();
            this.Hide();
        }
    }
}
