namespace FormEatCleanShop
{
    partial class PrintProduct
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
            this.crystalReportViewerProduct = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // crystalReportViewerProduct
            // 
            this.crystalReportViewerProduct.ActiveViewIndex = -1;
            this.crystalReportViewerProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewerProduct.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewerProduct.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.crystalReportViewerProduct.Location = new System.Drawing.Point(0, 74);
            this.crystalReportViewerProduct.Margin = new System.Windows.Forms.Padding(4);
            this.crystalReportViewerProduct.Name = "crystalReportViewerProduct";
            this.crystalReportViewerProduct.Size = new System.Drawing.Size(1067, 480);
            this.crystalReportViewerProduct.TabIndex = 0;
            this.crystalReportViewerProduct.ToolPanelWidth = 267;
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(232, 24);
            this.txtCategory.Margin = new System.Windows.Forms.Padding(4);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(132, 22);
            this.txtCategory.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(394, 24);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 28);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter type of product";
            // 
            // PrintProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.crystalReportViewerProduct);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PrintProduct";
            this.Text = "PrintProduct";
            this.Load += new System.EventHandler(this.PrintProduct_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewerProduct;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
    }
}