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
    public partial class PrintDetail : Form
    {
        public PrintDetail()
        {
            InitializeComponent();
        }

        private void PrintDetail_Load(object sender, EventArgs e)
        {
            ReportDocument report = new ReportDocument();
            report.Load("F:\\EatCleanShop-main (1)\\EatCleanShop-main\\FormEatCleanShop\\CrystalReportDetail.rpt");
            crystalReportDetail.ReportSource = report;
            crystalReportDetail.Refresh();
        }

        private void btnSearchbyName_Click(object sender, EventArgs e)
        {
            ReportDocument report = new ReportDocument();
            report.Load("F:\\EatCleanShop-main (1)\\EatCleanShop-main\\FormEatCleanShop\\CrystalReportDetail.rpt");

            string constr = ConfigurationManager.ConnectionStrings["btl_hsk"].ConnectionString;
            SqlConnection sp = new SqlConnection(constr);
            sp.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sp;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = @"Detail_by_Name";
            cmd.Parameters.AddWithValue("@tenkh",txtnameuser.Text);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            CrystalReportDetailByNameUser dbnuser = new CrystalReportDetailByNameUser();
            dbnuser.SetDataSource(dataTable);
            crystalReportDetail.ReportSource = dbnuser;
            crystalReportDetail.Refresh();
        }

        private void btnSearchbyYear_Click(object sender, EventArgs e)
        {
            ReportDocument report = new ReportDocument();
            report.Load("F:\\EatCleanShop-main (1)\\EatCleanShop-main\\FormEatCleanShop\\CrystalReportDetail.rpt");

            string constr = ConfigurationManager.ConnectionStrings["btl_hsk"].ConnectionString;
            SqlConnection sp = new SqlConnection(constr);
            sp.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sp;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = @"Detail_by_year";
            cmd.Parameters.AddWithValue("@namtk", int.Parse(txtyear.Text));
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            CrystalReportDetailByYear rdbyear = new CrystalReportDetailByYear();
            rdbyear.SetDataSource(dataTable);
            crystalReportDetail.ReportSource = rdbyear;
            crystalReportDetail.Refresh();

        }
    }
}
