using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Hall_management_System_sdp
{
    public partial class MainMenu : Form
    {
        ConnectionString cs = new ConnectionString();
        CommonClasses cc = new CommonClasses();
        clsFunc cf = new clsFunc();
        string st1;
        string st2;
        public MainMenu()
        {
            InitializeComponent();
        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*frmCategory frm = new frmCategory();
            frm.lblUser.Text = lblUser.Text;
            frm.Reset();
            frm.ShowDialog();*/
        }

        private void subCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*frmSubCategory frm = new frmSubCategory();
            frm.lblUser.Text = lblUser.Text;
            frm.Reset();
            frm.ShowDialog();*/
        }

        private void registrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
           User_Registration frm = new User_Registration();
            frm.lblUser.Text = lblUser.Text;
            frm.Reset();
            frm.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
           /* frmAbout frm = new frmAbout();
            frm.ShowDialog();*/
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*frmProduct frm = new frmProduct();
            frm.lblUser.Text = lblUser.Text;
            frm.Reset();
            frm.Show();*/
        }

        private void membershipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*frmMembershipType frm = new frmMembershipType();
            frm.lblUser.Text = lblUser.Text;
            frm.Reset();
            frm.ShowDialog();*/
        }

  

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("Calc.exe");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }

        private void notepadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("Notepad.exe");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }

        private void wordpadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("Wordpad.exe");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }

        private void mSWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("WinWord.exe");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }

        private void taskManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("TaskMgr.exe");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }

      
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = System.DateTime.Now.ToString();
        }

 

        private void logsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Logs frm = new Logs();
            frm.Reset();
            frm.lblUser.Text = lblUser.Text;
            frm.ShowDialog();
        }


        private void timer2_Tick(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            timer2.Enabled = false;
        }

    

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*frmProduct frm = new frmProduct();
            frm.lblUser.Text = lblUser.Text;
            frm.Reset();
            frm.Show();*/
        }

 

        private void membershipToolStripMenuItem1_Click(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*try
            {
                cc.con = new SqlConnection(cs.DBConn);
                cc.con.Open();
                cc.cmd = new SqlCommand("Select RTRIM(Customer.CustomerID),RTRIM(Name),RTRIM(City),RTRIM(Type),Convert(Varchar(10),DateFrom,103),Convert(varchar(10),DateTo,103) from Membership,CustomerMembership,Customer where Customer.C_ID=CustomerMembership.CustomerID and Membership.M_ID=CustomerMembership.MembershipID order by billdate", cc.con);
                cc.rdr = cc.cmd.ExecuteReader(CommandBehavior.CloseConnection);
                dgw.Rows.Clear();
                while (cc.rdr.Read() == true)
                {
                    dgw.Rows.Add(cc.rdr[0], cc.rdr[1], cc.rdr[2], cc.rdr[3], cc.rdr[4], cc.rdr[5]);
                }
                cc.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            button1.PerformClick();
        }


   
        private void backupToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                timer2.Enabled = true;
                if ((!System.IO.Directory.Exists("C:\\DBBackup")))
                {
                    System.IO.Directory.CreateDirectory("C:\\DBBackup");
                }
                string destdir = "C:\\DBBackup\\GMS_DB " + DateTime.Now.ToString("dd-MM-yyyy_HH-mm-ss") + ".bak";
                cc.con = new SqlConnection(cs.DBConn);
                cc.con.Open();
                string cb = "backup database [" + System.Windows.Forms.Application.StartupPath + "\\GMS_DB.mdf] to disk='" + destdir + "'with init,stats=10";
                cc.cmd = new SqlCommand(cb);
                cc.cmd.Connection = cc.con;
                cc.cmd.ExecuteReader();
                cc.con.Close();
                st1 = lblUser.Text;
                st2 = "Successfully backup the database";
                cf.LogFunc(st1, System.DateTime.Now, st2);
                MessageBox.Show("Successfully performed", "Database Backup", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void restoreToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                var _with1 = openFileDialog1;
                _with1.Filter = ("DB Backup File|*.bak;");
                _with1.FilterIndex = 4;
                //Clear the file name
                openFileDialog1.FileName = "";

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    Cursor = Cursors.WaitCursor;
                    timer2.Enabled = true;
                    SqlConnection.ClearAllPools();
                    cc.con = new SqlConnection(cs.DBConn);
                    cc.con.Open();
                    string cb = "USE Master ALTER DATABASE [" + System.Windows.Forms.Application.StartupPath + "\\gms_db.mdf] SET Single_User WITH Rollback Immediate Restore database [" + System.Windows.Forms.Application.StartupPath + "\\gms_db.mdf] FROM disk='" + openFileDialog1.FileName + "' WITH REPLACE ALTER DATABASE [" + System.Windows.Forms.Application.StartupPath + "\\gms_db.mdf] SET Multi_User ";
                    cc.cmd = new SqlCommand(cb);
                    cc.cmd.Connection = cc.con;
                    cc.cmd.ExecuteReader();
                    cc.con.Close();
                    st1 = lblUser.Text;
                    st2 = "Successfully restore the database";
                    cf.LogFunc(st1, System.DateTime.Now, st2);
                    MessageBox.Show("Successfully performed", "Database Restore", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void customerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            /*frmCustomer frm = new frmCustomer();
            frm.lblUser.Text = lblUser.Text;
            frm.Reset();
            frm.Show();*/
        }

        private void supplierToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           /* frmSupplier frm = new frmSupplier();
            frm.lblUser.Text = lblUser.Text;
            frm.Reset();
            frm.Show();*/
        }

        private void stockToolStripMenuItem1_Click(object sender, EventArgs e)
        {
          /*  frmStock frm = new frmStock();
            frm.lblUser.Text = lblUser.Text;
            frm.Reset();
            frm.Show();*/
        }

        private void membershipToolStripMenuItem2_Click(object sender, EventArgs e)
        {
           /* frmCustomerMembership frm = new frmCustomerMembership();
            frm.lblUser.Text = lblUser.Text;
            frm.Reset();
            frm.Show();*/
        }

        private void fitnessMeasureToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            /*frmFitnessMeasure frm = new frmFitnessMeasure();
            frm.lblUser.Text = lblUser.Text;
            frm.Reset();
            frm.Show();*/
        }

        private void salesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            /*frmSales frm = new frmSales();
            frm.lblUser.Text = lblUser.Text;
            frm.Reset();
            frm.Show();*/
        }

        private void logoutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            st1 = lblUser.Text;
            st2 = "Successfully logged out";
            cf.LogFunc(st1, System.DateTime.Now, st2);
            this.Hide();
            Login frm = new Login();
            frm.Show();
            frm.UserID.Text = "";
            frm.Password.Text = "";
            frm.ProgressBar1.Visible = false;
            frm.UserID.Focus();
        }
        
        private void frmMainMenu_Load(object sender, EventArgs e)
        {

        }

        private void masterEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Student_Entry en = new Student_Entry();
            en.Show();

        }

        private void webCamStudentIdentificationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPrincipal recognation = new FrmPrincipal();
            recognation.Show();
        }

        private void hallStudentMealBillingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentMealBilling mBill = new StudentMealBilling();
            mBill.Show();
        }

        private void mealStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MealStock mStock = new MealStock();
            mStock.Show();

        }

        private void mealPriceSettingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Meal m = new Meal();
            m.Show();

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void supplierEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Supplier s = new Supplier();
            s.Show();

        }

        private void mealTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void categoryToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MealCategory mc = new MealCategory();
            mc.Show();
        }

        private void subCategoryToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Meal_Sub_Category subC = new Meal_Sub_Category();
            subC.Show();
        }
    }
}
