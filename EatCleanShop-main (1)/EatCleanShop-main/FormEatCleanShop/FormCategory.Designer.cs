namespace FormEatCleanShop
{
    partial class FormCategory
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
            this.txtNameCategory = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btAdd = new System.Windows.Forms.Button();
            this.btDel = new System.Windows.Forms.Button();
            this.btBack = new System.Windows.Forms.Button();
            this.gvCategory = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIDCategory = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNameCategory
            // 
            this.txtNameCategory.Location = new System.Drawing.Point(239, 110);
            this.txtNameCategory.Margin = new System.Windows.Forms.Padding(4);
            this.txtNameCategory.Name = "txtNameCategory";
            this.txtNameCategory.Size = new System.Drawing.Size(174, 22);
            this.txtNameCategory.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 110);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(504, 77);
            this.btAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(100, 28);
            this.btAdd.TabIndex = 2;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btDel
            // 
            this.btDel.Location = new System.Drawing.Point(644, 77);
            this.btDel.Margin = new System.Windows.Forms.Padding(4);
            this.btDel.Name = "btDel";
            this.btDel.Size = new System.Drawing.Size(100, 28);
            this.btDel.TabIndex = 4;
            this.btDel.Text = "Delete";
            this.btDel.UseVisualStyleBackColor = true;
            this.btDel.Click += new System.EventHandler(this.btDel_Click);
            // 
            // btBack
            // 
            this.btBack.Location = new System.Drawing.Point(911, 79);
            this.btBack.Margin = new System.Windows.Forms.Padding(4);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(100, 28);
            this.btBack.TabIndex = 5;
            this.btBack.Text = "Back";
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // gvCategory
            // 
            this.gvCategory.AllowUserToAddRows = false;
            this.gvCategory.AllowUserToDeleteRows = false;
            this.gvCategory.AllowUserToResizeColumns = false;
            this.gvCategory.AllowUserToResizeRows = false;
            this.gvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvCategory.Location = new System.Drawing.Point(296, 188);
            this.gvCategory.Margin = new System.Windows.Forms.Padding(4);
            this.gvCategory.Name = "gvCategory";
            this.gvCategory.ReadOnly = true;
            this.gvCategory.RowHeadersWidth = 51;
            this.gvCategory.Size = new System.Drawing.Size(460, 351);
            this.gvCategory.TabIndex = 6;
            this.gvCategory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvCategory_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "ID";
            // 
            // txtIDCategory
            // 
            this.txtIDCategory.Location = new System.Drawing.Point(239, 47);
            this.txtIDCategory.Margin = new System.Windows.Forms.Padding(4);
            this.txtIDCategory.Name = "txtIDCategory";
            this.txtIDCategory.Size = new System.Drawing.Size(174, 22);
            this.txtIDCategory.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(779, 77);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 30);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FormCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 600);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIDCategory);
            this.Controls.Add(this.gvCategory);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.btDel);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNameCategory);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormCategory";
            this.Text = "Form Category";
            this.Load += new System.EventHandler(this.FormCategory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvCategory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNameCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btDel;
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.DataGridView gvCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIDCategory;
        private System.Windows.Forms.Button btnSave;
    }
}