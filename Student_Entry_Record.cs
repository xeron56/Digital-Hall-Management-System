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
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;
namespace Hall_management_System_sdp
{
    public partial class Student_Entry_Record : Form
    {
        ConnectionString cs = new ConnectionString();
        CommonClasses cc = new CommonClasses();
        public Student_Entry_Record()
        {
            InitializeComponent();
        }
        public void GetData()
        {
            try
            {
                cc.con = new SqlConnection(cs.DBConn);
                cc.con.Open();
                cc.cmd = new SqlCommand("SELECT RTRIM(C_ID) as [ID],RTRIM(StudentID) as [Student ID],RTRIM(Name) as [Student Name],RTRIM(Address) as [Address],RTRIM(City) as [City],RTRIM(ContactNo) as [Contact No.],RTRIM(Email) as [Email],Photo from Student order by name", cc.con);
                cc.da = new SqlDataAdapter(cc.cmd);
                cc.ds = new DataSet();
                cc.da.Fill(cc.ds, "Student");
                dgw.DataSource = cc.ds.Tables["Student"].DefaultView;
                cc.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtGuestName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                cc.con = new SqlConnection(cs.DBConn);
                cc.con.Open();
                cc.cmd = new SqlCommand("SELECT RTRIM(C_ID) as [ID],RTRIM(StudentID) as [Student ID],RTRIM(Name) as [Student Name],RTRIM(Address) as [Address],RTRIM(City) as [City],RTRIM(ContactNo) as [Contact No.],RTRIM(Email) as [Email],Photo from Student WHERE name like '" + txtCustomerName.Text + "%' order by name", cc.con);
                cc.da = new SqlDataAdapter(cc.cmd);
                cc.ds = new DataSet();
                cc.da.Fill(cc.ds, "Student");
                dgw.DataSource = cc.ds.Tables["Student"].DefaultView;
                cc.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Reset()
        {
            txtCustomerName.Text = "";
            GetData();
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgw_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            string strRowNumber = (e.RowIndex + 1).ToString();
            SizeF size = e.Graphics.MeasureString(strRowNumber, this.Font);
            if (dgw.RowHeadersWidth < Convert.ToInt32((size.Width + 20)))
            {
               dgw.RowHeadersWidth = Convert.ToInt32((size.Width + 20));
            }
            Brush b = SystemBrushes.ControlText;
            e.Graphics.DrawString(strRowNumber, this.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2));
     
        }

        private void dgw_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (lblOperation.Text == "Customer Master")
                {
                    DataGridViewRow dr = dgw.SelectedRows[0];
                    this.Hide();
                    //frmPatient frm = new frmPatient();
                    Student_Entry frm = new Student_Entry();
                    frm.Show();
                    frm.txtID.Text = dr.Cells[0].Value.ToString();
                    frm.txtCustomerID.Text = dr.Cells[1].Value.ToString();
                    frm.txtCustomerName.Text = dr.Cells[2].Value.ToString();
                    frm.txtAddress.Text = dr.Cells[3].Value.ToString();
                    frm.txtCity.Text = dr.Cells[4].Value.ToString();
                    frm.txtContactNo.Text = dr.Cells[5].Value.ToString();
                    frm.txtEmailID.Text = dr.Cells[6].Value.ToString();
                    byte[] data = (byte[])dr.Cells[7].Value;
                    MemoryStream ms = new MemoryStream(data);
                    frm.Picture.Image = Image.FromStream(ms);
                    frm.btnUpdate.Enabled = true;
                    frm.btnDelete.Enabled = true;
                    frm.btnSave.Enabled = false;
                    frm.lblUser.Text = lblUser.Text;
                    lblOperation.Text = "";
                }
             /*   if (lblOperation.Text == "Membership")
                {
                   DataGridViewRow dr = dgw.SelectedRows[0];
                    this.Hide();
                    frmAdmittedPatientStayBilling frm = new frmAdmittedPatientStayBilling();
                    frm.Show();
                    frm.txtM_ID.Text = dr.Cells[0].Value.ToString();
                    frm.txtMemberName.Text = dr.Cells[2].Value.ToString();
                    frm.txtAddress.Text = dr.Cells[3].Value.ToString();
                    frm.txtCity.Text = dr.Cells[4].Value.ToString();
                    frm.txtContactNo.Text = dr.Cells[5].Value.ToString();
                    frm.txtEmailID.Text = dr.Cells[6].Value.ToString();
                    byte[] data = (byte[])dr.Cells[7].Value;
                    MemoryStream ms = new MemoryStream(data);
                    frm.Picture.Image = Image.FromStream(ms);
                    frm.lblUser.Text = lblUser.Text;
                    lblOperation.Text = "";
                    frm.auto();
                    
                } */
                if (lblOperation.Text == "Sales")
                {
                    DataGridViewRow dr = dgw.SelectedRows[0];
                    this.Hide();
                    StudentMealBilling frm = new StudentMealBilling();
                    frm.Show();
                    frm.txtC_Id.Text = dr.Cells[0].Value.ToString();
                    frm.txtCustomerID.Text = dr.Cells[1].Value.ToString();
                    frm.txtCustomerName.Text = dr.Cells[2].Value.ToString();
                    frm.lblUser.Text = lblUser.Text;
                    lblOperation.Text = "";
                    frm.auto();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmCustomerRecord_Load(object sender, EventArgs e)
        {
            GetData();
        }

    }
}
