using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Hall_management_System_sdp
{
    public partial class ChangePassword : Form
    {
        CommonClasses cc = new CommonClasses();
        clsFunc cf = new clsFunc();
        ConnectionString cs = new ConnectionString();
        string st1;
        string st2;
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                int RowsAffected = 0;
                if ((txtUserID.Text.Trim().Length == 0))
                {
                    MessageBox.Show("Please enter user id", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUserID.Focus();
                    return;
                }
                if ((txtOldPassword.Text.Trim().Length == 0))
                {
                    MessageBox.Show("Please enter old password", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtOldPassword.Focus();
                    return;
                }
                if ((txtNewPassword.Text.Trim().Length == 0))
                {
                    MessageBox.Show("Please enter new password", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNewPassword.Focus();
                    return;
                }
                if ((txtConfirmPassword.Text.Trim().Length == 0))
                {
                    MessageBox.Show("Please confirm new password", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtConfirmPassword.Focus();
                    return;
                }
                if ((txtNewPassword.TextLength < 5))
                {
                    MessageBox.Show("The New Password Should be of Atleast 5 Characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNewPassword.Text = "";
                    txtConfirmPassword.Text = "";
                    txtNewPassword.Focus();
                    return;
                }
                else if ((txtNewPassword.Text != txtConfirmPassword.Text))
                {
                    MessageBox.Show("Password do not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNewPassword.Text = "";
                    txtOldPassword.Text = "";
                    txtConfirmPassword.Text = "";
                    txtOldPassword.Focus();
                    return;
                }
                else if ((txtOldPassword.Text == txtNewPassword.Text))
                {
                    MessageBox.Show("Password is same..Re-enter new password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNewPassword.Text = "";
                    txtConfirmPassword.Text = "";
                    txtNewPassword.Focus();
                    return;
                }
              
                cc.con = new SqlConnection(cs.DBConn);
                cc.con.Open();
                string co = "Update Registration set Password = '" + txtNewPassword.Text + "'where UserID=@d1 and Password =@d2";
                cc.cmd = new SqlCommand(co);
                cc.cmd.Connection = cc.con;
                cc.cmd.Parameters.AddWithValue("@d1", txtUserID.Text);
                cc.cmd.Parameters.AddWithValue("@d2", txtOldPassword.Text);
                RowsAffected = cc.cmd.ExecuteNonQuery();
                if ((RowsAffected > 0))
                {
                    st1 = txtUserID.Text;
                    st2 = "Successfully changed the password";
                    cf.LogFunc(st1, System.DateTime.Now, st2);
                    MessageBox.Show("Successfully changed", "Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUserID.Text = "";
                    txtNewPassword.Text = "";
                    txtOldPassword.Text = "";
                    txtConfirmPassword.Text = "";
                    Login LoginForm1 = new Login();
                    this.Hide();
                    Login frm = new Login();
                    frm.UserID.Text = "";
                    frm.Password.Text = "";
                    frm.ProgressBar1.Visible = false;
                    frm.UserID.Focus();
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("invalid user name or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUserID.Text = "";
                    txtNewPassword.Text = "";
                    txtOldPassword.Text = "";
                    txtConfirmPassword.Text = "";
                    txtUserID.Focus();
                }
                if ((cc.con.State == ConnectionState.Open))
                {
                    cc.con.Close();
                }
                cc.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChangePassword_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Login frm = new Login();
            frm.UserID.Text = "";
            frm.Password.Text = "";
            frm.ProgressBar1.Visible = false;
            frm.UserID.Focus();
            frm.Show();
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {

        }

    }
}
