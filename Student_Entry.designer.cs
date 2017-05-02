namespace Hall_management_System_sdp
{
    partial class Student_Entry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student_Entry));
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Panel4 = new System.Windows.Forms.Panel();
            this.lblUser = new System.Windows.Forms.Label();
            this.Picture = new System.Windows.Forms.PictureBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.Browse = new System.Windows.Forms.Button();
            this.BRemove = new System.Windows.Forms.Button();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.txtEmailID = new System.Windows.Forms.TextBox();
            this.txtContactNo = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).BeginInit();
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
            this.Panel1.Size = new System.Drawing.Size(717, 304);
            this.Panel1.TabIndex = 3;
            // 
            // Panel4
            // 
            this.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel4.Controls.Add(this.lblUser);
            this.Panel4.Controls.Add(this.Picture);
            this.Panel4.Controls.Add(this.txtID);
            this.Panel4.Controls.Add(this.Browse);
            this.Panel4.Controls.Add(this.BRemove);
            this.Panel4.Controls.Add(this.txtCustomerName);
            this.Panel4.Controls.Add(this.Label7);
            this.Panel4.Controls.Add(this.Label6);
            this.Panel4.Controls.Add(this.Label5);
            this.Panel4.Controls.Add(this.txtEmailID);
            this.Panel4.Controls.Add(this.txtContactNo);
            this.Panel4.Controls.Add(this.txtCity);
            this.Panel4.Controls.Add(this.txtAddress);
            this.Panel4.Controls.Add(this.Label4);
            this.Panel4.Controls.Add(this.Label2);
            this.Panel4.Controls.Add(this.Label3);
            this.Panel4.Controls.Add(this.txtCustomerID);
            this.Panel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Panel4.Location = new System.Drawing.Point(9, 79);
            this.Panel4.Name = "Panel4";
            this.Panel4.Size = new System.Drawing.Size(576, 212);
            this.Panel4.TabIndex = 0;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(164, 180);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(45, 15);
            this.lblUser.TabIndex = 5;
            this.lblUser.Text = "Label8";
            this.lblUser.Visible = false;
            // 
            // Picture
            // 
            this.Picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Picture.Image = global::Hall_management_System_sdp.Properties.Resources.photo;
            this.Picture.Location = new System.Drawing.Point(371, 14);
            this.Picture.Name = "Picture";
            this.Picture.Size = new System.Drawing.Size(186, 152);
            this.Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Picture.TabIndex = 291;
            this.Picture.TabStop = false;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(231, 174);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(111, 21);
            this.txtID.TabIndex = 4;
            this.txtID.Visible = false;
            // 
            // Browse
            // 
            this.Browse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Browse.ForeColor = System.Drawing.Color.Black;
            this.Browse.Location = new System.Drawing.Point(371, 172);
            this.Browse.Name = "Browse";
            this.Browse.Size = new System.Drawing.Size(89, 23);
            this.Browse.TabIndex = 6;
            this.Browse.Text = "Browse...";
            this.Browse.UseVisualStyleBackColor = true;
            this.Browse.Click += new System.EventHandler(this.Browse_Click);
            // 
            // BRemove
            // 
            this.BRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BRemove.ForeColor = System.Drawing.Color.Black;
            this.BRemove.Location = new System.Drawing.Point(466, 172);
            this.BRemove.Name = "BRemove";
            this.BRemove.Size = new System.Drawing.Size(89, 23);
            this.BRemove.TabIndex = 7;
            this.BRemove.Text = "Remove";
            this.BRemove.UseVisualStyleBackColor = true;
            this.BRemove.Click += new System.EventHandler(this.BRemove_Click);
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.BackColor = System.Drawing.Color.White;
            this.txtCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerName.Location = new System.Drawing.Point(137, 41);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(217, 21);
            this.txtCustomerName.TabIndex = 1;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(7, 148);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(45, 15);
            this.Label7.TabIndex = 13;
            this.Label7.Text = "Email :";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(7, 121);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(76, 15);
            this.Label6.TabIndex = 12;
            this.Label6.Text = "Contact No. :";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(7, 94);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(32, 15);
            this.Label5.TabIndex = 11;
            this.Label5.Text = "City :";
            // 
            // txtEmailID
            // 
            this.txtEmailID.BackColor = System.Drawing.Color.White;
            this.txtEmailID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailID.Location = new System.Drawing.Point(137, 148);
            this.txtEmailID.Name = "txtEmailID";
            this.txtEmailID.Size = new System.Drawing.Size(217, 21);
            this.txtEmailID.TabIndex = 5;
            this.txtEmailID.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmailID_Validating);
            // 
            // txtContactNo
            // 
            this.txtContactNo.BackColor = System.Drawing.Color.White;
            this.txtContactNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactNo.Location = new System.Drawing.Point(137, 121);
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.Size = new System.Drawing.Size(109, 21);
            this.txtContactNo.TabIndex = 4;
            // 
            // txtCity
            // 
            this.txtCity.BackColor = System.Drawing.Color.White;
            this.txtCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCity.Location = new System.Drawing.Point(137, 94);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(157, 21);
            this.txtCity.TabIndex = 3;
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.White;
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(137, 67);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(217, 21);
            this.txtAddress.TabIndex = 2;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(7, 67);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(57, 15);
            this.Label4.TabIndex = 6;
            this.Label4.Text = "Address :";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(7, 41);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(120, 15);
            this.Label2.TabIndex = 5;
            this.Label2.Text = "Hall Student  Name :";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(3, 17);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(137, 15);
            this.Label3.TabIndex = 0;
            this.Label3.Text = "Machine Generated ID :";
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.BackColor = System.Drawing.SystemColors.Control;
            this.txtCustomerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerID.Location = new System.Drawing.Point(137, 14);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.ReadOnly = true;
            this.txtCustomerID.Size = new System.Drawing.Size(84, 21);
            this.txtCustomerID.TabIndex = 0;
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
            this.Panel3.Location = new System.Drawing.Point(594, 79);
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
            this.Panel2.Size = new System.Drawing.Size(696, 62);
            this.Panel2.TabIndex = 0;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(260, 15);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(177, 24);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Hall Student Entry";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Student_Entry
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(740, 327);
            this.Controls.Add(this.Panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Student_Entry";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Panel1.ResumeLayout(false);
            this.Panel4.ResumeLayout(false);
            this.Panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).EndInit();
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
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox txtEmailID;
        internal System.Windows.Forms.TextBox txtContactNo;
        internal System.Windows.Forms.TextBox txtCity;
        internal System.Windows.Forms.TextBox txtAddress;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox txtCustomerID;
        internal System.Windows.Forms.Panel Panel3;
        internal System.Windows.Forms.Button btnDelete;
        internal System.Windows.Forms.Button btnClose;
        internal System.Windows.Forms.Button btnUpdate;
        internal System.Windows.Forms.Button btnSave;
        internal System.Windows.Forms.Button btnNew;
        internal System.Windows.Forms.Panel Panel2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtCustomerName;
        internal System.Windows.Forms.Button btnGetData;
        public System.Windows.Forms.PictureBox Picture;
        private System.Windows.Forms.Button Browse;
        private System.Windows.Forms.Button BRemove;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;

    }
}

