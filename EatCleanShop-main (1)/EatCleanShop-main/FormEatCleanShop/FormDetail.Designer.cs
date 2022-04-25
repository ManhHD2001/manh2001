
namespace FormEatCleanShop
{
    partial class FormDetail
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
            this.btnAddBI = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDateCreate = new System.Windows.Forms.DateTimePicker();
            this.txtIDOrder = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.Amount = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnback = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cboNameUser = new System.Windows.Forms.ComboBox();
            this.cboNameProduct = new System.Windows.Forms.ComboBox();
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.txtsum = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPhonenumber = new System.Windows.Forms.MaskedTextBox();
            this.gb2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtIdDetail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvDetailOrderInfor = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.gb1.SuspendLayout();
            this.gb2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailOrderInfor)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddBI
            // 
            this.btnAddBI.Location = new System.Drawing.Point(180, 529);
            this.btnAddBI.Name = "btnAddBI";
            this.btnAddBI.Size = new System.Drawing.Size(75, 23);
            this.btnAddBI.TabIndex = 0;
            this.btnAddBI.Text = "Add";
            this.btnAddBI.UseVisualStyleBackColor = true;
            this.btnAddBI.Click += new System.EventHandler(this.btnAddBI_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID Order";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(318, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name User";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Date Create";
            // 
            // txtDateCreate
            // 
            this.txtDateCreate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDateCreate.Location = new System.Drawing.Point(148, 87);
            this.txtDateCreate.Name = "txtDateCreate";
            this.txtDateCreate.Size = new System.Drawing.Size(123, 22);
            this.txtDateCreate.TabIndex = 6;
            // 
            // txtIDOrder
            // 
            this.txtIDOrder.Location = new System.Drawing.Point(148, 36);
            this.txtIDOrder.Name = "txtIDOrder";
            this.txtIDOrder.Size = new System.Drawing.Size(123, 22);
            this.txtIDOrder.TabIndex = 7;
            this.txtIDOrder.TextChanged += new System.EventHandler(this.txtIDOrder_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(318, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(632, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Phone Number";
            // 
            // txtAddress
            // 
            this.txtAddress.Enabled = false;
            this.txtAddress.Location = new System.Drawing.Point(433, 85);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(151, 22);
            this.txtAddress.TabIndex = 12;
            // 
            // Amount
            // 
            this.Amount.Location = new System.Drawing.Point(148, 85);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(100, 22);
            this.Amount.TabIndex = 16;
            this.Amount.TextChanged += new System.EventHandler(this.Amount_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Amount";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(325, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "Name Product";
            // 
            // Price
            // 
            this.Price.Enabled = false;
            this.Price.Location = new System.Drawing.Point(433, 88);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(100, 22);
            this.Price.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(329, 88);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 17);
            this.label10.TabIndex = 19;
            this.label10.Text = "Price";
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(791, 529);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(75, 23);
            this.btnback.TabIndex = 23;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(330, 529);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 24;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cboNameUser
            // 
            this.cboNameUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNameUser.FormattingEnabled = true;
            this.cboNameUser.Location = new System.Drawing.Point(433, 37);
            this.cboNameUser.Name = "cboNameUser";
            this.cboNameUser.Size = new System.Drawing.Size(151, 24);
            this.cboNameUser.TabIndex = 26;
            this.cboNameUser.SelectedIndexChanged += new System.EventHandler(this.cboNameUser_SelectedIndexChanged);
            // 
            // cboNameProduct
            // 
            this.cboNameProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNameProduct.FormattingEnabled = true;
            this.cboNameProduct.Location = new System.Drawing.Point(433, 38);
            this.cboNameProduct.Name = "cboNameProduct";
            this.cboNameProduct.Size = new System.Drawing.Size(121, 24);
            this.cboNameProduct.TabIndex = 27;
            this.cboNameProduct.SelectedIndexChanged += new System.EventHandler(this.cboNameProduct_SelectedIndexChanged);
            // 
            // gb1
            // 
            this.gb1.Controls.Add(this.txtsum);
            this.gb1.Controls.Add(this.label12);
            this.gb1.Controls.Add(this.txtPhonenumber);
            this.gb1.Controls.Add(this.txtIDOrder);
            this.gb1.Controls.Add(this.label1);
            this.gb1.Controls.Add(this.cboNameUser);
            this.gb1.Controls.Add(this.txtDateCreate);
            this.gb1.Controls.Add(this.label4);
            this.gb1.Controls.Add(this.label2);
            this.gb1.Controls.Add(this.txtAddress);
            this.gb1.Controls.Add(this.label5);
            this.gb1.Controls.Add(this.label6);
            this.gb1.Location = new System.Drawing.Point(71, 22);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(892, 135);
            this.gb1.TabIndex = 28;
            this.gb1.TabStop = false;
            this.gb1.Text = "Basic Information";
            // 
            // txtsum
            // 
            this.txtsum.Enabled = false;
            this.txtsum.Location = new System.Drawing.Point(744, 85);
            this.txtsum.Name = "txtsum";
            this.txtsum.Size = new System.Drawing.Size(100, 22);
            this.txtsum.TabIndex = 29;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(636, 88);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 17);
            this.label12.TabIndex = 28;
            this.label12.Text = "Sum";
            // 
            // txtPhonenumber
            // 
            this.txtPhonenumber.Enabled = false;
            this.txtPhonenumber.Location = new System.Drawing.Point(744, 41);
            this.txtPhonenumber.Mask = "0000000000";
            this.txtPhonenumber.Name = "txtPhonenumber";
            this.txtPhonenumber.Size = new System.Drawing.Size(120, 22);
            this.txtPhonenumber.TabIndex = 27;
            // 
            // gb2
            // 
            this.gb2.Controls.Add(this.label7);
            this.gb2.Controls.Add(this.txtTotal);
            this.gb2.Controls.Add(this.txtIdDetail);
            this.gb2.Controls.Add(this.label3);
            this.gb2.Controls.Add(this.cboNameProduct);
            this.gb2.Controls.Add(this.label9);
            this.gb2.Controls.Add(this.Price);
            this.gb2.Controls.Add(this.label10);
            this.gb2.Controls.Add(this.Amount);
            this.gb2.Controls.Add(this.label8);
            this.gb2.Location = new System.Drawing.Point(71, 163);
            this.gb2.Name = "gb2";
            this.gb2.Size = new System.Drawing.Size(892, 128);
            this.gb2.TabIndex = 29;
            this.gb2.TabStop = false;
            this.gb2.Text = "Detail Order Information";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(640, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 17);
            this.label7.TabIndex = 31;
            this.label7.Text = "Total";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(705, 83);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 22);
            this.txtTotal.TabIndex = 30;
            // 
            // txtIdDetail
            // 
            this.txtIdDetail.Location = new System.Drawing.Point(148, 38);
            this.txtIdDetail.Name = "txtIdDetail";
            this.txtIdDetail.Size = new System.Drawing.Size(100, 22);
            this.txtIdDetail.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 28;
            this.label3.Text = "Id Detail ";
            // 
            // dgvDetailOrderInfor
            // 
            this.dgvDetailOrderInfor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetailOrderInfor.Location = new System.Drawing.Point(48, 307);
            this.dgvDetailOrderInfor.Name = "dgvDetailOrderInfor";
            this.dgvDetailOrderInfor.RowHeadersWidth = 51;
            this.dgvDetailOrderInfor.RowTemplate.Height = 24;
            this.dgvDetailOrderInfor.Size = new System.Drawing.Size(915, 193);
            this.dgvDetailOrderInfor.TabIndex = 30;
            this.dgvDetailOrderInfor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetailOrderInfor_CellClick);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(490, 529);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 31;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(651, 529);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 32;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // FormDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 640);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvDetailOrderInfor);
            this.Controls.Add(this.gb2);
            this.Controls.Add(this.gb1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnAddBI);
            this.Name = "FormDetail";
            this.Text = "FormDetail";
            this.Load += new System.EventHandler(this.FormDetail_Load);
            this.gb1.ResumeLayout(false);
            this.gb1.PerformLayout();
            this.gb2.ResumeLayout(false);
            this.gb2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailOrderInfor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddBI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker txtDateCreate;
        private System.Windows.Forms.TextBox txtIDOrder;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox Amount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cboNameUser;
        private System.Windows.Forms.ComboBox cboNameProduct;
        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.GroupBox gb2;
        private System.Windows.Forms.TextBox txtIdDetail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvDetailOrderInfor;
        private System.Windows.Forms.MaskedTextBox txtPhonenumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtsum;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnPrint;
    }
}