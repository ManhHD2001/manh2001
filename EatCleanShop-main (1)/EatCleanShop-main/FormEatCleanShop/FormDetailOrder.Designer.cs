
namespace FormEatCleanShop
{
    partial class FormDetailOrder
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIdDetail = new System.Windows.Forms.TextBox();
            this.amount = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.TextBox();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.cboIDorder = new System.Windows.Forms.ComboBox();
            this.cboNameproduct = new System.Windows.Forms.ComboBox();
            this.dgvDetailOrder = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(145, 206);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(78, 32);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id Order";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Id Detail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Name Product";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(526, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Total";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(526, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Amount";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(526, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Price";
            // 
            // txtIdDetail
            // 
            this.txtIdDetail.Location = new System.Drawing.Point(253, 29);
            this.txtIdDetail.Name = "txtIdDetail";
            this.txtIdDetail.Size = new System.Drawing.Size(139, 22);
            this.txtIdDetail.TabIndex = 7;
            // 
            // amount
            // 
            this.amount.Location = new System.Drawing.Point(616, 34);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(127, 22);
            this.amount.TabIndex = 8;
            this.amount.TextChanged += new System.EventHandler(this.amount_TextChanged);
            // 
            // price
            // 
            this.price.Enabled = false;
            this.price.Location = new System.Drawing.Point(616, 82);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(127, 22);
            this.price.TabIndex = 9;
            // 
            // txttotal
            // 
            this.txttotal.Enabled = false;
            this.txttotal.Location = new System.Drawing.Point(616, 142);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(127, 22);
            this.txttotal.TabIndex = 10;
            // 
            // cboIDorder
            // 
            this.cboIDorder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIDorder.FormattingEnabled = true;
            this.cboIDorder.Location = new System.Drawing.Point(253, 92);
            this.cboIDorder.Name = "cboIDorder";
            this.cboIDorder.Size = new System.Drawing.Size(139, 24);
            this.cboIDorder.TabIndex = 11;
            // 
            // cboNameproduct
            // 
            this.cboNameproduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNameproduct.FormattingEnabled = true;
            this.cboNameproduct.Location = new System.Drawing.Point(253, 147);
            this.cboNameproduct.Name = "cboNameproduct";
            this.cboNameproduct.Size = new System.Drawing.Size(139, 24);
            this.cboNameproduct.TabIndex = 12;
            this.cboNameproduct.SelectedIndexChanged += new System.EventHandler(this.cboNameproduct_SelectedIndexChanged);
            // 
            // dgvDetailOrder
            // 
            this.dgvDetailOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetailOrder.Location = new System.Drawing.Point(32, 259);
            this.dgvDetailOrder.Name = "dgvDetailOrder";
            this.dgvDetailOrder.RowHeadersWidth = 51;
            this.dgvDetailOrder.RowTemplate.Height = 24;
            this.dgvDetailOrder.Size = new System.Drawing.Size(896, 260);
            this.dgvDetailOrder.TabIndex = 13;
            this.dgvDetailOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetailOrder_CellClick);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(302, 206);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(78, 32);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(478, 206);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(78, 32);
            this.btnDel.TabIndex = 15;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(640, 206);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(78, 32);
            this.btnSearch.TabIndex = 16;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // FormDetailOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 531);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dgvDetailOrder);
            this.Controls.Add(this.cboNameproduct);
            this.Controls.Add(this.cboIDorder);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.price);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.txtIdDetail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd);
            this.Name = "FormDetailOrder";
            this.Text = "FormDetailOrder";
            this.Load += new System.EventHandler(this.FormDetailOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIdDetail;
        private System.Windows.Forms.TextBox amount;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.ComboBox cboIDorder;
        private System.Windows.Forms.ComboBox cboNameproduct;
        private System.Windows.Forms.DataGridView dgvDetailOrder;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnSearch;
    }
}