
namespace FormEatCleanShop
{
    partial class PrintDetail
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
            this.crystalReportDetail = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.txtnameuser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearchbyName = new System.Windows.Forms.Button();
            this.btnSearchbyYear = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtyear = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // crystalReportDetail
            // 
            this.crystalReportDetail.ActiveViewIndex = -1;
            this.crystalReportDetail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportDetail.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportDetail.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.crystalReportDetail.Location = new System.Drawing.Point(0, 108);
            this.crystalReportDetail.Name = "crystalReportDetail";
            this.crystalReportDetail.Size = new System.Drawing.Size(1168, 635);
            this.crystalReportDetail.TabIndex = 0;
            // 
            // txtnameuser
            // 
            this.txtnameuser.Location = new System.Drawing.Point(290, 22);
            this.txtnameuser.Name = "txtnameuser";
            this.txtnameuser.Size = new System.Drawing.Size(168, 22);
            this.txtnameuser.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Name User here";
            // 
            // btnSearchbyName
            // 
            this.btnSearchbyName.Location = new System.Drawing.Point(486, 22);
            this.btnSearchbyName.Name = "btnSearchbyName";
            this.btnSearchbyName.Size = new System.Drawing.Size(123, 32);
            this.btnSearchbyName.TabIndex = 3;
            this.btnSearchbyName.Text = "Filter by Name ";
            this.btnSearchbyName.UseVisualStyleBackColor = true;
            this.btnSearchbyName.Click += new System.EventHandler(this.btnSearchbyName_Click);
            // 
            // btnSearchbyYear
            // 
            this.btnSearchbyYear.Location = new System.Drawing.Point(486, 69);
            this.btnSearchbyYear.Name = "btnSearchbyYear";
            this.btnSearchbyYear.Size = new System.Drawing.Size(123, 33);
            this.btnSearchbyYear.TabIndex = 6;
            this.btnSearchbyYear.Text = "Filter by year";
            this.btnSearchbyYear.UseVisualStyleBackColor = true;
            this.btnSearchbyYear.Click += new System.EventHandler(this.btnSearchbyYear_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Enter Year of Creation here";
            // 
            // txtyear
            // 
            this.txtyear.Location = new System.Drawing.Point(290, 74);
            this.txtyear.Name = "txtyear";
            this.txtyear.Size = new System.Drawing.Size(130, 22);
            this.txtyear.TabIndex = 4;
            // 
            // PrintDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 743);
            this.Controls.Add(this.btnSearchbyYear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtyear);
            this.Controls.Add(this.btnSearchbyName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtnameuser);
            this.Controls.Add(this.crystalReportDetail);
            this.Name = "PrintDetail";
            this.Text = "PrintDetail";
            this.Load += new System.EventHandler(this.PrintDetail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportDetail;
        private System.Windows.Forms.TextBox txtnameuser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearchbyName;
        private System.Windows.Forms.Button btnSearchbyYear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtyear;
    }
}