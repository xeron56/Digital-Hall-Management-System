namespace Hall_management_System_sdp
{
    partial class Logs
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Logs));
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Panel6 = new System.Windows.Forms.Panel();
            this.btnDeleteAllLogs = new System.Windows.Forms.Button();
            this.Panel5 = new System.Windows.Forms.Panel();
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.Panel4 = new System.Windows.Forms.Panel();
            this.cmbUserID = new System.Windows.Forms.ComboBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.Panel3 = new System.Windows.Forms.Panel();
            this.dtpDateTo = new System.Windows.Forms.DateTimePicker();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.dtpDateFrom = new System.Windows.Forms.DateTimePicker();
            this.btnGetData = new System.Windows.Forms.Button();
            this.dgw = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.Label1 = new System.Windows.Forms.Label();
            this.Panel1.SuspendLayout();
            this.Panel6.SuspendLayout();
            this.Panel5.SuspendLayout();
            this.Panel4.SuspendLayout();
            this.Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw)).BeginInit();
            this.Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.White;
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.Panel6);
            this.Panel1.Controls.Add(this.Panel5);
            this.Panel1.Controls.Add(this.Panel4);
            this.Panel1.Controls.Add(this.Panel3);
            this.Panel1.Controls.Add(this.dgw);
            this.Panel1.Controls.Add(this.Panel2);
            this.Panel1.Location = new System.Drawing.Point(12, 12);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(720, 558);
            this.Panel1.TabIndex = 3;
            // 
            // Panel6
            // 
            this.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel6.Controls.Add(this.btnDeleteAllLogs);
            this.Panel6.Location = new System.Drawing.Point(596, 316);
            this.Panel6.Name = "Panel6";
            this.Panel6.Size = new System.Drawing.Size(111, 67);
            this.Panel6.TabIndex = 46;
            // 
            // btnDeleteAllLogs
            // 
            this.btnDeleteAllLogs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteAllLogs.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteAllLogs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAllLogs.Location = new System.Drawing.Point(13, 10);
            this.btnDeleteAllLogs.Name = "btnDeleteAllLogs";
            this.btnDeleteAllLogs.Size = new System.Drawing.Size(82, 45);
            this.btnDeleteAllLogs.TabIndex = 0;
            this.btnDeleteAllLogs.Text = "Delete all logs";
            this.btnDeleteAllLogs.UseVisualStyleBackColor = true;
            this.btnDeleteAllLogs.Click += new System.EventHandler(this.btnDeleteAllLogs_Click);
            // 
            // Panel5
            // 
            this.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel5.Controls.Add(this.btnExportExcel);
            this.Panel5.Controls.Add(this.btnClose);
            this.Panel5.Controls.Add(this.btnReset);
            this.Panel5.Location = new System.Drawing.Point(596, 163);
            this.Panel5.Name = "Panel5";
            this.Panel5.Size = new System.Drawing.Size(111, 119);
            this.Panel5.TabIndex = 45;
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportExcel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExportExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportExcel.Location = new System.Drawing.Point(13, 78);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(82, 28);
            this.btnExportExcel.TabIndex = 5;
            this.btnExportExcel.Text = "Export Excel";
            this.btnExportExcel.UseVisualStyleBackColor = true;
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(13, 44);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(82, 28);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnReset
            // 
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(13, 10);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(82, 28);
            this.btnReset.TabIndex = 0;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Panel4
            // 
            this.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel4.Controls.Add(this.cmbUserID);
            this.Panel4.Controls.Add(this.Label5);
            this.Panel4.Controls.Add(this.lblUser);
            this.Panel4.Location = new System.Drawing.Point(383, 76);
            this.Panel4.Name = "Panel4";
            this.Panel4.Size = new System.Drawing.Size(199, 70);
            this.Panel4.TabIndex = 44;
            // 
            // cmbUserID
            // 
            this.cmbUserID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUserID.FormattingEnabled = true;
            this.cmbUserID.Location = new System.Drawing.Point(13, 30);
            this.cmbUserID.Name = "cmbUserID";
            this.cmbUserID.Size = new System.Drawing.Size(171, 23);
            this.cmbUserID.TabIndex = 13;
            this.cmbUserID.SelectedIndexChanged += new System.EventHandler(this.cmbUserID_SelectedIndexChanged);
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(10, 8);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(54, 15);
            this.Label5.TabIndex = 12;
            this.Label5.Text = "User ID :";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(87, 8);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(45, 15);
            this.lblUser.TabIndex = 5;
            this.lblUser.Text = "Label8";
            this.lblUser.Visible = false;
            // 
            // Panel3
            // 
            this.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel3.Controls.Add(this.dtpDateTo);
            this.Panel3.Controls.Add(this.Label2);
            this.Panel3.Controls.Add(this.Label3);
            this.Panel3.Controls.Add(this.dtpDateFrom);
            this.Panel3.Controls.Add(this.btnGetData);
            this.Panel3.Location = new System.Drawing.Point(9, 76);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(368, 70);
            this.Panel3.TabIndex = 42;
            // 
            // dtpDateTo
            // 
            this.dtpDateTo.CustomFormat = "dd/MMM/yyyy";
            this.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateTo.Location = new System.Drawing.Point(153, 27);
            this.dtpDateTo.Name = "dtpDateTo";
            this.dtpDateTo.Size = new System.Drawing.Size(119, 21);
            this.dtpDateTo.TabIndex = 14;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(150, 8);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(27, 15);
            this.Label2.TabIndex = 13;
            this.Label2.Text = "To :";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(10, 8);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(42, 15);
            this.Label3.TabIndex = 12;
            this.Label3.Text = "From :";
            // 
            // dtpDateFrom
            // 
            this.dtpDateFrom.CustomFormat = "dd/MMM/yyyy";
            this.dtpDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateFrom.Location = new System.Drawing.Point(13, 27);
            this.dtpDateFrom.Name = "dtpDateFrom";
            this.dtpDateFrom.Size = new System.Drawing.Size(119, 21);
            this.dtpDateFrom.TabIndex = 11;
            // 
            // btnGetData
            // 
            this.btnGetData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGetData.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGetData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetData.Location = new System.Drawing.Point(278, 27);
            this.btnGetData.Name = "btnGetData";
            this.btnGetData.Size = new System.Drawing.Size(76, 20);
            this.btnGetData.TabIndex = 1;
            this.btnGetData.Text = "Get Data";
            this.btnGetData.UseVisualStyleBackColor = true;
            this.btnGetData.Click += new System.EventHandler(this.btnGetData_Click);
            // 
            // dgw
            // 
            this.dgw.AllowUserToAddRows = false;
            this.dgw.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FloralWhite;
            this.dgw.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgw.BackgroundColor = System.Drawing.Color.White;
            this.dgw.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgw.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgw.ColumnHeadersHeight = 24;
            this.dgw.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgw.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgw.EnableHeadersVisualStyles = false;
            this.dgw.GridColor = System.Drawing.Color.White;
            this.dgw.Location = new System.Drawing.Point(9, 152);
            this.dgw.MultiSelect = false;
            this.dgw.Name = "dgw";
            this.dgw.ReadOnly = true;
            this.dgw.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgw.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgw.RowHeadersWidth = 25;
            this.dgw.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgw.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgw.RowTemplate.Height = 18;
            this.dgw.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgw.Size = new System.Drawing.Size(581, 394);
            this.dgw.TabIndex = 43;
            this.dgw.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgw_RowPostPaint);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "User ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Date";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Operation";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 300;
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Panel2.Controls.Add(this.Label1);
            this.Panel2.Location = new System.Drawing.Point(9, 7);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(698, 62);
            this.Panel2.TabIndex = 0;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(313, 13);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(55, 24);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Logs";
            // 
            // Logs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(743, 583);
            this.Controls.Add(this.Panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Logs";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.frmLogs_Load);
            this.Panel1.ResumeLayout(false);
            this.Panel6.ResumeLayout(false);
            this.Panel5.ResumeLayout(false);
            this.Panel4.ResumeLayout(false);
            this.Panel4.PerformLayout();
            this.Panel3.ResumeLayout(false);
            this.Panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw)).EndInit();
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Label lblUser;
        internal System.Windows.Forms.Panel Panel2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Panel Panel6;
        internal System.Windows.Forms.Button btnDeleteAllLogs;
        internal System.Windows.Forms.Panel Panel5;
        internal System.Windows.Forms.Button btnExportExcel;
        internal System.Windows.Forms.Button btnClose;
        internal System.Windows.Forms.Button btnReset;
        internal System.Windows.Forms.Panel Panel4;
        internal System.Windows.Forms.ComboBox cmbUserID;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Panel Panel3;
        internal System.Windows.Forms.DateTimePicker dtpDateTo;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.DateTimePicker dtpDateFrom;
        internal System.Windows.Forms.Button btnGetData;
        internal System.Windows.Forms.DataGridView dgw;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Column3;

    }
}

