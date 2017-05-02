namespace Hall_management_System_sdp
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.ProgressBar1 = new System.Windows.Forms.ProgressBar();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.LinkLabel2 = new System.Windows.Forms.LinkLabel();
            this.Label3 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.Label4 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.UserID = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.UserType = new System.Windows.Forms.TextBox();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProgressBar1
            // 
            this.ProgressBar1.Location = new System.Drawing.Point(-8, 517);
            this.ProgressBar1.Name = "ProgressBar1";
            this.ProgressBar1.Size = new System.Drawing.Size(767, 5);
            this.ProgressBar1.TabIndex = 59;
            this.ProgressBar1.Visible = false;
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Panel1.Controls.Add(this.LinkLabel2);
            this.Panel1.Controls.Add(this.Label3);
            this.Panel1.Controls.Add(this.btnCancel);
            this.Panel1.Controls.Add(this.Label4);
            this.Panel1.Controls.Add(this.btnOK);
            this.Panel1.Controls.Add(this.UserID);
            this.Panel1.Controls.Add(this.Password);
            this.Panel1.Location = new System.Drawing.Point(235, 162);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(352, 197);
            this.Panel1.TabIndex = 60;
            // 
            // LinkLabel2
            // 
            this.LinkLabel2.AutoSize = true;
            this.LinkLabel2.BackColor = System.Drawing.Color.Transparent;
            this.LinkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkLabel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LinkLabel2.LinkColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LinkLabel2.Location = new System.Drawing.Point(121, 162);
            this.LinkLabel2.Name = "LinkLabel2";
            this.LinkLabel2.Size = new System.Drawing.Size(118, 16);
            this.LinkLabel2.TabIndex = 5;
            this.LinkLabel2.TabStop = true;
            this.LinkLabel2.Text = "Change Password";
            this.LinkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel2_LinkClicked);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.BackColor = System.Drawing.Color.Transparent;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Label3.Location = new System.Drawing.Point(19, 20);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(58, 18);
            this.Label3.TabIndex = 1;
            this.Label3.Text = "User ID";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(238, 94);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 38);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.BackColor = System.Drawing.Color.Transparent;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Label4.Location = new System.Drawing.Point(19, 58);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(75, 18);
            this.Label4.TabIndex = 2;
            this.Label4.Text = "Password";
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(124, 94);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(87, 38);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "&OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // UserID
            // 
            this.UserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserID.Location = new System.Drawing.Point(124, 22);
            this.UserID.Name = "UserID";
            this.UserID.Size = new System.Drawing.Size(201, 22);
            this.UserID.TabIndex = 1;
            // 
            // Password
            // 
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(124, 60);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '♠';
            this.Password.Size = new System.Drawing.Size(201, 22);
            this.Password.TabIndex = 2;
            // 
            // UserType
            // 
            this.UserType.Location = new System.Drawing.Point(12, 375);
            this.UserType.Name = "UserType";
            this.UserType.Size = new System.Drawing.Size(131, 20);
            this.UserType.TabIndex = 62;
            this.UserType.Visible = false;
            // 
            // Login
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkMagenta;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(757, 523);
            this.Controls.Add(this.UserType);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.ProgressBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Form";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ProgressBar ProgressBar1;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.LinkLabel LinkLabel2;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Button btnCancel;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Button btnOK;
        internal System.Windows.Forms.TextBox UserID;
        internal System.Windows.Forms.TextBox Password;
        internal System.Windows.Forms.TextBox UserType;
    }
}