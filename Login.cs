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
    public partial class Login : Form
    {
        ConnectionString cs = new ConnectionString();
        MainMenu frm = new MainMenu();
        CommonClasses cc = new CommonClasses();
        clsFunc cf = new clsFunc();
        string st1;
        string st2;
        public Login()
        {
            InitializeComponent();
        }

      

   
        private void btnOK_Click(object sender, EventArgs e)
        {

            if (UserID.Text == "")
            {
                MessageBox.Show("Please enter user id", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                UserID.Focus();
                return;
            }
            if (Password.Text == "")
            {
                MessageBox.Show("Please enter password", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Password.Focus();
                return;
            }
            try
            {
                cc.con = new SqlConnection(cs.DBConn);
                cc.con.Open();
                cc.cmd = cc.con.CreateCommand();
                cc.cmd.CommandText = "SELECT RTRIM(UserID),RTRIM(Password) FROM Registration where UserID = @d1 and Password=@d2";
                cc.cmd.Parameters.AddWithValue("@d1", UserID.Text);
                cc.cmd.Parameters.AddWithValue("@d2",Password.Text);
                cc.rdr = cc.cmd.ExecuteReader();
                if (cc.rdr.Read())
                {
                    cc.con = new SqlConnection(cs.DBConn);
                    cc.con.Open();
                    cc.cmd = cc.con.CreateCommand();
                    cc.cmd.CommandText = "SELECT usertype FROM Registration where UserID=@d3 and Password=@d4";
                    cc.cmd.Parameters.AddWithValue("@d3", UserID.Text);
                    cc.cmd.Parameters.AddWithValue("@d4",Password.Text);
                    cc.rdr = cc.cmd.ExecuteReader();
                    if (cc.rdr.Read())
                    {
                        UserType.Text = cc.rdr.GetValue(0).ToString().Trim();
                    }
                    if ((cc.rdr != null))
                    {
                        cc.rdr.Close();
                    }
                    if (cc.con.State == ConnectionState.Open)
                    {
                        cc.con.Close();
                    }
                    if ((UserType.Text == "Admin"))
                    {
                       frm.masterEntryToolStripMenuItem.Enabled=true;
                       frm.usersToolStripMenuItem.Enabled=true;
                       frm.databaseToolStripMenuItem.Enabled = true;
                     
                      
                     
                       
                       
                       frm.lblUser.Text = UserID.Text;
                       frm.lblUserType.Text = UserType.Text;
                       ProgressBar1.Visible = true;
                        ProgressBar1.Maximum = 5000;
                        ProgressBar1.Minimum = 0;
                        ProgressBar1.Value = 4;
                        ProgressBar1.Step = 1;
                        for (int i = 0; i <= 5000; i++)
                        {
                            ProgressBar1.PerformStep();
                        }
                        st1 = UserID.Text;
                        st2 = "Successfully logged in";
                        cf.LogFunc(st1, System.DateTime.Now, st2);
                        this.Hide();
                        frm.Show();

                    }
                    if ((UserType.Text == "Operator"))
                    {
                        frm.masterEntryToolStripMenuItem.Enabled = false;
                        frm.usersToolStripMenuItem.Enabled = false;
                        frm.databaseToolStripMenuItem.Enabled = false;
                       
                       
                        
                       
                       
                        
                        frm.lblUser.Text = UserID.Text;
                        frm.lblUserType.Text = UserType.Text;
                        ProgressBar1.Visible = true;
                        ProgressBar1.Maximum = 5000;
                        ProgressBar1.Minimum = 0;
                        ProgressBar1.Value = 4;
                        ProgressBar1.Step = 1;
                        for (int i = 0; i <= 5000; i++)
                        {
                            ProgressBar1.PerformStep();
                        }
                        st1 = UserID.Text;
                        st2 = "Successfully logged in";
                        cf.LogFunc(st1, System.DateTime.Now, st2);
                        this.Hide();
                        frm.Show();

                    }
                }
                else
                {
                    MessageBox.Show("Login is Failed...Try again !","Login Denied",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    UserID.Text = "";
                    Password.Text = "";
                    UserID.Focus();
                }
                cc.cmd.Dispose();
                cc.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LinkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ChangePassword frm = new ChangePassword();
            frm.Show();
            frm.txtUserID.Text = "";
            frm.txtNewPassword.Text = "";
            frm.txtOldPassword.Text = "";
            frm.txtConfirmPassword.Text = "";
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

   
    }
}
