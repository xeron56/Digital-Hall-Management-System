namespace Hall_management_System_sdp
{
    partial class MealStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MealStock));
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Panel4 = new System.Windows.Forms.Panel();
            this.txtQty1 = new System.Windows.Forms.TextBox();
            this.txtSupplierID = new System.Windows.Forms.TextBox();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.cmbSupplierName = new System.Windows.Forms.ComboBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.cmbProductName = new System.Windows.Forms.ComboBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtStockID = new System.Windows.Forms.TextBox();
            this.Panel3 = new System.Windows.Forms.Panel();
            this.btnGetData = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.Label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Panel1.SuspendLayout();
            this.Panel4.SuspendLayout();
            this.Panel3.SuspendLayout();
            this.Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.White;
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.Panel4);
            this.Panel1.Controls.Add(this.Panel3);
            this.Panel1.Controls.Add(this.Panel2);
            this.Panel1.Location = new System.Drawing.Point(12, 12);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(480, 292);
            this.Panel1.TabIndex = 3;
            // 
            // Panel4
            // 
            this.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel4.Controls.Add(this.txtQty1);
            this.Panel4.Controls.Add(this.txtSupplierID);
            this.Panel4.Controls.Add(this.txtProductID);
            this.Panel4.Controls.Add(this.cmbSupplierName);
            this.Panel4.Controls.Add(this.dtpDate);
            this.Panel4.Controls.Add(this.cmbProductName);
            this.Panel4.Controls.Add(this.lblUser);
            this.Panel4.Controls.Add(this.txtID);
            this.Panel4.Controls.Add(this.Label6);
            this.Panel4.Controls.Add(this.Label5);
            this.Panel4.Controls.Add(this.txtQuantity);
            this.Panel4.Controls.Add(this.Label4);
            this.Panel4.Controls.Add(this.Label2);
            this.Panel4.Controls.Add(this.Label3);
            this.Panel4.Controls.Add(this.txtStockID);
            this.Panel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Panel4.Location = new System.Drawing.Point(9, 79);
            this.Panel4.Name = "Panel4";
            this.Panel4.Size = new System.Drawing.Size(341, 164);
            this.Panel4.TabIndex = 0;
            // 
            // txtQty1
            // 
            this.txtQty1.Location = new System.Drawing.Point(258, 128);
            this.txtQty1.Name = "txtQty1";
            this.txtQty1.Size = new System.Drawing.Size(68, 21);
            this.txtQty1.TabIndex = 297;
            this.txtQty1.Visible = false;
            // 
            // txtSupplierID
            // 
            this.txtSupplierID.Location = new System.Drawing.Point(268, 41);
            this.txtSupplierID.Name = "txtSupplierID";
            this.txtSupplierID.Size = new System.Drawing.Size(68, 21);
            this.txtSupplierID.TabIndex = 296;
            this.txtSupplierID.Visible = false;
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(268, 14);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(68, 21);
            this.txtProductID.TabIndex = 295;
            this.txtProductID.Visible = false;
            // 
            // cmbSupplierName
            // 
            this.cmbSupplierName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbSupplierName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSupplierName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSupplierName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSupplierName.FormattingEnabled = true;
            this.cmbSupplierName.Location = new System.Drawing.Point(125, 96);
            this.cmbSupplierName.Name = "cmbSupplierName";
            this.cmbSupplierName.Size = new System.Drawing.Size(201, 23);
            this.cmbSupplierName.TabIndex = 3;
            this.cmbSupplierName.SelectedIndexChanged += new System.EventHandler(this.cmbSupplierName_SelectedIndexChanged);
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "dd/MMM/yyyy";
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(125, 41);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(121, 21);
            this.dtpDate.TabIndex = 1;
            // 
            // cmbProductName
            // 
            this.cmbProductName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbProductName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbProductName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProductName.FormattingEnabled = true;
            this.cmbProductName.Location = new System.Drawing.Point(125, 67);
            this.cmbProductName.Name = "cmbProductName";
            this.cmbProductName.Size = new System.Drawing.Size(201, 23);
            this.cmbProductName.TabIndex = 2;
            this.cmbProductName.SelectedIndexChanged += new System.EventHandler(this.cmbProductName_SelectedIndexChanged);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(201, 128);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(45, 15);
            this.lblUser.TabIndex = 5;
            this.lblUser.Text = "Label8";
            this.lblUser.Visible = false;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(194, 14);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(68, 21);
            this.txtID.TabIndex = 4;
            this.txtID.Visible = false;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(7, 125);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(88, 15);
            this.Label6.TabIndex = 12;
            this.Label6.Text = "Meal Quantity :";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(7, 94);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(96, 15);
            this.Label5.TabIndex = 11;
            this.Label5.Text = "Supplier Name :";
            // 
            // txtQuantity
            // 
            this.txtQuantity.BackColor = System.Drawing.Color.White;
            this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(125, 125);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(63, 21);
            this.txtQuantity.TabIndex = 4;
            this.txtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantity_KeyPress);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(7, 67);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(78, 15);
            this.Label4.TabIndex = 6;
            this.Label4.Text = "Meal Name :";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(7, 41);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(39, 15);
            this.Label2.TabIndex = 5;
            this.Label2.Text = "Date :";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(7, 14);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(58, 15);
            this.Label3.TabIndex = 0;
            this.Label3.Text = "Stock ID :";
            // 
            // txtStockID
            // 
            this.txtStockID.BackColor = System.Drawing.SystemColors.Control;
            this.txtStockID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStockID.Location = new System.Drawing.Point(125, 14);
            this.txtStockID.Name = "txtStockID";
            this.txtStockID.ReadOnly = true;
            this.txtStockID.Size = new System.Drawing.Size(63, 21);
            this.txtStockID.TabIndex = 0;
            // 
            // Panel3
            // 
            this.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel3.Controls.Add(this.btnGetData);
            this.Panel3.Controls.Add(this.btnDelete);
            this.Panel3.Controls.Add(this.btnClose);
            this.Panel3.Controls.Add(this.btnUpdate);
            this.Panel3.Controls.Add(this.btnSave);
            this.Panel3.Controls.Add(this.btnNew);
            this.Panel3.Location = new System.Drawing.Point(356, 79);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(111, 203);
            this.Panel3.TabIndex = 2;
            // 
            // btnGetData
            // 
            this.btnGetData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGetData.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGetData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetData.Location = new System.Drawing.Point(13, 135);
            this.btnGetData.Name = "btnGetData";
            this.btnGetData.Size = new System.Drawing.Size(82, 28);
            this.btnGetData.TabIndex = 5;
            this.btnGetData.Text = "Get Data";
            this.btnGetData.UseVisualStyleBackColor = true;
            this.btnGetData.Click += new System.EventHandler(this.btnGetData_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(13, 103);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(82, 28);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(13, 167);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(82, 28);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(13, 72);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(82, 28);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(13, 41);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(82, 28);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(13, 10);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(82, 28);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.Color.DarkMagenta;
            this.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Panel2.Controls.Add(this.Label1);
            this.Panel2.Location = new System.Drawing.Point(9, 7);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(458, 62);
            this.Panel2.TabIndex = 0;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(81, 13);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(285, 24);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Hall Student Meal Stock Entry";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmMedicalStock
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(504, 316);
            this.Controls.Add(this.Panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMedicalStock";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmStock_Load);
            this.Panel1.ResumeLayout(false);
            this.Panel4.ResumeLayout(false);
            this.Panel4.PerformLayout();
            this.Panel3.ResumeLayout(false);
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Label lblUser;
        internal System.Windows.Forms.TextBox txtID;
        internal System.Windows.Forms.Panel Panel4;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox txtQuantity;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox txtStockID;
        internal System.Windows.Forms.Panel Panel3;
        internal System.Windows.Forms.Button btnDelete;
        internal System.Windows.Forms.Button btnClose;
        internal System.Windows.Forms.Button btnUpdate;
        internal System.Windows.Forms.Button btnSave;
        internal System.Windows.Forms.Button btnNew;
        internal System.Windows.Forms.Panel Panel2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button btnGetData;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        public System.Windows.Forms.ComboBox cmbProductName;
        public System.Windows.Forms.ComboBox cmbSupplierName;
        internal System.Windows.Forms.DateTimePicker dtpDate;
        internal System.Windows.Forms.TextBox txtSupplierID;
        internal System.Windows.Forms.TextBox txtProductID;
        internal System.Windows.Forms.TextBox txtQty1;

    }
}

