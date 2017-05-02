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
    public partial class StudentMealBillingRecord : Form
    {
        ConnectionString cs = new ConnectionString();
        CommonClasses cc = new CommonClasses();
        public StudentMealBillingRecord()
        {
            InitializeComponent();
        }
        public void GetData()
        {
            try
            {
                cc.con = new SqlConnection(cs.DBConn);
                cc.con.Open();
                cc.cmd = new SqlCommand("SELECT RTRIM(B_Id) as [Bill ID], RTRIM(BillNo) as [Bill No.], Convert(Datetime,BillDate,131) as [Bill Date],RTRIM(OrderedProduct.CustomerID) as [CId],RTRIM(Student.StudentID) as [Student ID],RTRIM(Name) as [Custome Name], RTRIM(GrandTotal) as [Grand Total], RTRIM(Cash) as [Cash], RTRIM(Change) as [Change] from Student,OrderedProduct where Student.C_ID=OrderedProduct.CustomerID order by billdate", cc.con);
                cc.da = new SqlDataAdapter(cc.cmd);
                cc.ds = new DataSet();
                cc.da.Fill(cc.ds, "Orderedproduct");
                dgw.DataSource = cc.ds.Tables["OrderedProduct"].DefaultView;
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
                cc.cmd = new SqlCommand("SELECT RTRIM(B_Id) as [Bill ID], RTRIM(BillNo) as [Bill No.], Convert(Datetime,BillDate,131) as [Bill Date],RTRIM(OrderedProduct.CustomerID) as [CId],RTRIM(Student.StudentID) as [StudentStudent ID],RTRIM(Name) as [Custome Name], RTRIM(GrandTotal) as [Grand Total], RTRIM(Cash) as [Cash], RTRIM(Change) as [Change] from Student,OrderedProduct where Student.C_ID=OrderedProduct.CustomerID and name like '" + txtCustomerName.Text + "%' order by name", cc.con);
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
            dtpDateFrom.Text = System.DateTime.Today.ToString();
            dtpDateTo.Text = System.DateTime.Now.ToString();
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
                if (lblOperation.Text == "Sales")
                {
                    DataGridViewRow dr = dgw.SelectedRows[0];
                    this.Hide();
                    //frmPatientMedicineBilling frm = new frmPatientMedicineBilling();
                    StudentMealBilling frm = new StudentMealBilling();
                    frm.Show();
                    frm.txtID.Text = dr.Cells[0].Value.ToString();
                    frm.txtBillNo.Text = dr.Cells[1].Value.ToString();
                    frm.dtpBillDate.Text = dr.Cells[2].Value.ToString();
                    frm.txtC_Id.Text = dr.Cells[3].Value.ToString();
                    frm.txtCustomerID.Text = dr.Cells[4].Value.ToString();
                    frm.txtCustomerName.Text = dr.Cells[5].Value.ToString();
                    frm.txtGrandTotal.Text = dr.Cells[6].Value.ToString();
                    frm.txtCash.Text = dr.Cells[7].Value.ToString();
                    frm.txtChange.Text = dr.Cells[8].Value.ToString();
                    frm.btnUpdate.Enabled = true;
                    frm.btnDelete.Enabled = true;
                    frm.btnSave.Enabled = false;
                    frm.lblUser.Text = lblUser.Text;
                    lblOperation.Text = "";
                      cc.con = new SqlConnection(cs.DBConn);
                      cc.con.Open();
                      cc.cmd = new SqlCommand("SELECT RTRIM(ProductSold.ProductID),RTRIM(ProductName),RTRIM(ProductSold.Price),RTRIM(Quantity),RTRIM(Amount),RTRIM(DiscountPer), RTRIM(DiscountAmount), RTRIM(STPer), RTRIM(STAmount), RTRIM(VATPer), RTRIM(VATAmount),RTRIM(TotalAmount) from Product,OrderedProduct,ProductSold where Product.P_ID=ProductSold.ProductID and Orderedproduct.B_ID=ProductSold.BillID and BillNo='" + dr.Cells[1].Value +"'", cc.con);
                      cc.rdr = cc.cmd.ExecuteReader(CommandBehavior.CloseConnection);
                      frm.DataGridView1.Rows.Clear();
            while (cc.rdr.Read() == true)
                {
                frm.DataGridView1.Rows.Add(cc.rdr[0],cc.rdr[1],cc.rdr[2],cc.rdr[3],cc.rdr[4],cc.rdr[5],cc.rdr[6],cc.rdr[7],cc.rdr[8],cc.rdr[9],cc.rdr[10]);
                }
            cc.con.Close();

            
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

        private void btnGetData_Click(object sender, EventArgs e)
        {
            try
            {
                cc.con = new SqlConnection(cs.DBConn);
                cc.con.Open();
                cc.cmd = new SqlCommand("SELECT RTRIM(B_Id) as [Bill ID], RTRIM(BillNo) as [Bill No.], Convert(Datetime,BillDate,131) as [Bill Date],RTRIM(OrderedProduct.CustomerID) as [CId],RTRIM(Student.StudentID) as [Customer ID],RTRIM(Name) as [Custome Name], RTRIM(GrandTotal) as [Grand Total], RTRIM(Cash) as [Cash], RTRIM(Change) as [Change] from Student,OrderedProduct where Student.C_ID=OrderedProduct.Customer and BillDate between @d1 and @d2 order by BillDate", cc.con);
                cc.cmd.Parameters.Add("@d1", SqlDbType.DateTime, 30, "Date").Value = dtpDateFrom.Value.Date;
                cc.cmd.Parameters.Add("@d2", SqlDbType.DateTime, 30, "Date").Value = dtpDateTo.Value;
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

    }
}
