
namespace FormEatCleanShop
{
    partial class PrintReview
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.crystalReportReview = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtyear = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // crystalReportReview
            // 
            this.crystalReportReview.ActiveViewIndex = -1;
            this.crystalReportReview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportReview.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportReview.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.crystalReportReview.Location = new System.Drawing.Point(0, 80);
            this.crystalReportReview.Name = "crystalReportReview";
            this.crystalReportReview.Size = new System.Drawing.Size(1051, 636);
            this.crystalReportReview.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(444, 35);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtyear
            // 
            this.txtyear.Location = new System.Drawing.Point(296, 35);
            this.txtyear.Name = "txtyear";
            this.txtyear.Size = new System.Drawing.Size(100, 22);
            this.txtyear.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter Year You Need To Search";
            // 
            // PrintReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 716);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtyear);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.crystalReportReview);
            this.Name = "PrintReview";
            this.Text = "PrintReview";
            this.Load += new System.EventHandler(this.PrintReview_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportReview;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtyear;
        private System.Windows.Forms.Label label1;
    }
}