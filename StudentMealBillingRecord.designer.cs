namespace Hall_management_System_sdp
{
    partial class StudentMealBillingRecord
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
            this.Panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dtpDateTo = new System.Windows.Forms.DateTimePicker();
            this.Label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDateFrom = new System.Windows.Forms.DateTimePicker();
            this.btnGetData = new System.Windows.Forms.Button();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblOperation = new System.Windows.Forms.Label();
            this.Panel5 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.Panel3 = new System.Windows.Forms.Panel();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.dgw = new System.Windows.Forms.DataGridView();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.Label1 = new System.Windows.Forms.Label();
            this.Panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.Panel5.SuspendLayout();
            this.Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw)).BeginInit();
            this.Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.White;
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.panel4);
            this.Panel1.Controls.Add(this.lblUser);
            this.Panel1.Controls.Add(this.lblOperation);
            this.Panel1.Controls.Add(this.Panel5);
            this.Panel1.Controls.Add(this.Panel3);
            this.Panel1.Controls.Add(this.dgw);
            this.Panel1.Controls.Add(this.Panel2);
            this.Panel1.Location = new System.Drawing.Point(13, 14);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(940, 559);
            this.Panel1.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.dtpDateTo);
            this.panel4.Controls.Add(this.Label2);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.dtpDateFrom);
            this.panel4.Controls.Add(this.btnGetData);
            this.panel4.Location = new System.Drawing.Point(228, 75);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(368, 70);
            this.panel4.TabIndex = 45;
            // 
            // dtpDateTo
            // 
            this.dtpDateTo.CustomFormat = "dd/MMM/yyyy";
            this.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateTo.Location = new System.Drawing.Point(153, 27);
            this.dtpDateTo.Name = "dtpDateTo";
            this.dtpDateTo.Size = new System.Drawing.Size(119, 20);
            this.dtpDateTo.TabIndex = 14;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(150, 8);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(26, 13);
            this.Label2.TabIndex = 13;
            this.Label2.Text = "To :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "From :";
            // 
            // dtpDateFrom
            // 
            this.dtpDateFrom.CustomFormat = "dd/MMM/yyyy";
            this.dtpDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateFrom.Location = new System.Drawing.Point(13, 27);
            this.dtpDateFrom.Name = "dtpDateFrom";
            this.dtpDateFrom.Size = new System.Drawing.Size(119, 20);
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
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(793, 107);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(29, 13);
            this.lblUser.TabIndex = 44;
            this.lblUser.Text = "User";
            this.lblUser.Visible = false;
            // 
            // lblOperation
            // 
            this.lblOperation.AutoSize = true;
            this.lblOperation.Location = new System.Drawing.Point(788, 86);
            this.lblOperation.Name = "lblOperation";
            this.lblOperation.Size = new System.Drawing.Size(53, 13);
            this.lblOperation.TabIndex = 43;
            this.lblOperation.Text = "Operation";
            this.lblOperation.Visible = false;
            // 
            // Panel5
            // 
            this.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel5.Controls.Add(this.btnClose);
            this.Panel5.Controls.Add(this.btnReset);
            this.Panel5.Location = new System.Drawing.Point(603, 75);
            this.Panel5.Name = "Panel5";
            this.Panel5.Size = new System.Drawing.Size(194, 70);
            this.Panel5.TabIndex = 42;
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(101, 23);
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
            this.btnReset.Location = new System.Drawing.Point(13, 23);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(82, 28);
            this.btnReset.TabIndex = 0;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Panel3
            // 
            this.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel3.Controls.Add(this.txtCustomerName);
            this.Panel3.Controls.Add(this.Label3);
            this.Panel3.Location = new System.Drawing.Point(9, 75);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(213, 70);
            this.Panel3.TabIndex = 1;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.BackColor = System.Drawing.Color.White;
            this.txtCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerName.Location = new System.Drawing.Point(13, 30);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(183, 21);
            this.txtCustomerName.TabIndex = 13;
            this.txtCustomerName.TextChanged += new System.EventHandler(this.txtGuestName_TextChanged);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(10, 10);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(136, 13);
            this.Label3.TabIndex = 12;
            this.Label3.Text = "Search By Student  Name :";
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgw.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgw.ColumnHeadersHeight = 24;
            this.dgw.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgw.EnableHeadersVisualStyles = false;
            this.dgw.GridColor = System.Drawing.Color.White;
            this.dgw.Location = new System.Drawing.Point(9, 151);
            this.dgw.MultiSelect = false;
            this.dgw.Name = "dgw";
            this.dgw.ReadOnly = true;
            this.dgw.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.dgw.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgw.Size = new System.Drawing.Size(916, 394);
            this.dgw.TabIndex = 40;
            this.dgw.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgw_RowPostPaint);
            this.dgw.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgw_MouseClick);
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.Color.DarkMagenta;
            this.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Panel2.Controls.Add(this.Label1);
            this.Panel2.Location = new System.Drawing.Point(9, 7);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(916, 62);
            this.Panel2.TabIndex = 0;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(369, 14);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(267, 24);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "All Hall Student Meal Billing";
            // 
            // StudentMealBillingRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(965, 586);
            this.Controls.Add(this.Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "StudentMealBillingRecord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmCustomerRecord_Load);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.Panel5.ResumeLayout(false);
            this.Panel3.ResumeLayout(false);
            this.Panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw)).EndInit();
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Panel Panel5;
        internal System.Windows.Forms.Button btnClose;
        internal System.Windows.Forms.Button btnReset;
        internal System.Windows.Forms.Panel Panel3;
        internal System.Windows.Forms.TextBox txtCustomerName;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.DataGridView dgw;
        internal System.Windows.Forms.Panel Panel2;
        internal System.Windows.Forms.Label Label1;
        public System.Windows.Forms.Label lblOperation;
        public System.Windows.Forms.Label lblUser;
        internal System.Windows.Forms.Panel panel4;
        internal System.Windows.Forms.DateTimePicker dtpDateTo;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.DateTimePicker dtpDateFrom;
        internal System.Windows.Forms.Button btnGetData;

    }
}