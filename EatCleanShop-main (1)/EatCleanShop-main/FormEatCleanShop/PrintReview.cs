using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;
using System.Configuration;
using System.Data.SqlClient;

namespace FormEatCleanShop
{
    public partial class PrintReview : Form
    {
        public PrintReview()
        {
            InitializeComponent();
        }

        private void PrintReview_Load(object sender, EventArgs e)
        {
            ReportDocument report = new ReportDocument();
            report.Load("F:\\EatCleanShop-main (1)\\EatCleanShop-main\\FormEatCleanShop\\CrystalReportReview.rpt");
            crystalReportReview.ReportSource = report;
            crystalReportReview.Refresh();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ReportDocument report = new ReportDocument();
            report.Load("F:\\EatCleanShop-main (1)\\EatCleanShop-main\\FormEatCleanShop\\CrystalReportReview.rpt");

            string constr = ConfigurationManager.ConnectionStrings["btl_hsk"].ConnectionString;
            SqlConnection sp = new SqlConnection(constr);
            sp.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sp;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = @"Review_by_year";
            cmd.Parameters.AddWithValue("@namtk", int.Parse(txtyear.Text));
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            CrystalReportReviewByYear ReviewbyYear = new CrystalReportReviewByYear();
            ReviewbyYear.SetDataSource(dataTable);
            crystalReportReview.ReportSource = ReviewbyYear;
            crystalReportReview.Refresh();
        }
    }
}
