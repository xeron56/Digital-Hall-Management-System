namespace Hall_management_System_sdp
{
    partial class ChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePassword));
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.txtOldPassword = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtUserID
            // 
            this.txtUserID.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtUserID.Location = new System.Drawing.Point(160, 24);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(119, 20);
            this.txtUserID.TabIndex = 0;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.BackColor = System.Drawing.Color.Transparent;
            this.Label4.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.Color.Black;
            this.Label4.Location = new System.Drawing.Point(33, 24);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(57, 17);
            this.Label4.TabIndex = 17;
            this.Label4.Text = "User ID :";
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnChangePassword.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnChangePassword.Location = new System.Drawing.Point(89, 154);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(115, 38);
            this.btnChangePassword.TabIndex = 4;
            this.btnChangePassword.Text = "&Change Password";
            this.btnChangePassword.UseVisualStyleBackColor = false;
            this.btnChangePassword.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.BackColor = System.Drawing.Color.Transparent;
            this.Label3.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.Color.Black;
            this.Label3.Location = new System.Drawing.Point(33, 105);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(115, 17);
            this.Label3.TabIndex = 16;
            this.Label3.Text = "Confirm Password :";
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(160, 105);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '♠';
            this.txtConfirmPassword.Size = new System.Drawing.Size(119, 20);
            this.txtConfirmPassword.TabIndex = 3;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(160, 78);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '♠';
            this.txtNewPassword.Size = new System.Drawing.Size(119, 20);
            this.txtNewPassword.TabIndex = 2;
            // 
            // txtOldPassword
            // 
            this.txtOldPassword.Location = new System.Drawing.Point(160, 50);
            this.txtOldPassword.Name = "txtOldPassword";
            this.txtOldPassword.PasswordChar = '♠';
            this.txtOldPassword.Size = new System.Drawing.Size(119, 20);
            this.txtOldPassword.TabIndex = 1;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.Black;
            this.Label2.Location = new System.Drawing.Point(33, 78);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(94, 17);
            this.Label2.TabIndex = 12;
            this.Label2.Text = "New Password :";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.Black;
            this.Label1.Location = new System.Drawing.Point(33, 50);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(89, 17);
            this.Label1.TabIndex = 10;
            this.Label1.Text = "Old Password :";
            // 
            // ChangePassword
            // 
            this.AcceptButton = this.btnChangePassword;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(300, 216);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.txtOldPassword);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Password";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChangePassword_FormClosing);
            this.Load += new System.EventHandler(this.frmChangePassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox txtUserID;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Button btnChangePassword;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox txtConfirmPassword;
        internal System.Windows.Forms.TextBox txtNewPassword;
        internal System.Windows.Forms.TextBox txtOldPassword;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
    }
}