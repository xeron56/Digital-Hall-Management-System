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
    public partial class MealStockRecord : Form
    {
        ConnectionString cs = new ConnectionString();
        CommonClasses cc = new CommonClasses();
        public MealStockRecord()
        {
            InitializeComponent();
        }
        public void GetData()
        {
            try
            {
                cc.con = new SqlConnection(cs.DBConn);
                cc.con.Open();
                cc.cmd = new SqlCommand("Select RTRIM(ST_ID) as [ID],RTRIM(StockID) as [Stock ID],Convert(DateTime,Date,131) as [Date],RTRIM(Stock.ProductID) as [Product ID],RTRIM(ProductName) as [Product Name],RTRIM(Stock.SupplierID) as [Supplier ID],RTRIM(Name) as [Supplier Name],RTRIM(Quantity) as [Quantity] from Supplier,Product,Stock where Stock.SupplierID=Supplier.S_ID and Stock.ProductID=Product.P_ID order by date", cc.con);
                cc.da = new SqlDataAdapter(cc.cmd);
                cc.ds = new DataSet();
                cc.da.Fill(cc.ds, "Supplier");
                dgw.DataSource = cc.ds.Tables["Supplier"].DefaultView;
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
                cc.cmd = new SqlCommand("Select RTRIM(ST_ID) as [ID],RTRIM(StockID) as [Stock ID],Convert(DateTime,Date,131) as [Date],RTRIM(Stock.ProductID) as [Product ID],RTRIM(ProductName) as [Product Name],RTRIM(Stock.SupplierID) as [Supplier ID],RTRIM(Name) as [Supplier Name],RTRIM(Quantity) as [Quantity] from Supplier,Product,Stock where Stock.SupplierID=Supplier.S_ID and Stock.ProductID=Product.P_ID and Productname like '" + txtProductName.Text + "%' order by Productname", cc.con);
                cc.da = new SqlDataAdapter(cc.cmd);
                cc.ds = new DataSet();
                cc.da.Fill(cc.ds, "Stock");
                dgw.DataSource = cc.ds.Tables["Stock"].DefaultView;
                cc.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Reset()
        {
            txtProductName.Text = "";
            txtSupplierName.Text = "";
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
                if (lblOperation.Text == "Stock")
                {
                    DataGridViewRow dr = dgw.SelectedRows[0];
                    this.Hide();
                    MealStock frm = new MealStock();
                    frm.Show();
                    frm.txtID.Text = dr.Cells[0].Value.ToString();
                    frm.txtStockID.Text = dr.Cells[1].Value.ToString();
                    frm.dtpDate.Text = dr.Cells[2].Value.ToString();
                    frm.txtProductID.Text = dr.Cells[3].Value.ToString();
                    frm.cmbProductName.Text = dr.Cells[4].Value.ToString();
                    frm.txtSupplierID.Text = dr.Cells[5].Value.ToString();
                    frm.cmbSupplierName.Text = dr.Cells[6].Value.ToString();
                    frm.txtQuantity.Text = dr.Cells[7].Value.ToString();
                    frm.txtQty1.Text = dr.Cells[7].Value.ToString();
                    frm.btnUpdate.Enabled = true;
                    frm.btnDelete.Enabled = true;
                    frm.btnSave.Enabled = false;
                    frm.lblUser.Text = lblUser.Text;
                    lblOperation.Text = "";
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

        private void txtSupplierName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                cc.con = new SqlConnection(cs.DBConn);
                cc.con.Open();
                cc.cmd = new SqlCommand("Select RTRIM(ST_ID) as [ID],RTRIM(StockID) as [Stock ID],Convert(DateTime,Date,131) as [Date],RTRIM(Stock.ProductID) as [Product ID],RTRIM(ProductName) as [Product Name],RTRIM(Stock.SupplierID) as [Supplier ID],RTRIM(Name) as [Supplier Name],RTRIM(Quantity) as [Quantity] from Supplier,Product,Stock where Stock.SupplierID=Supplier.S_ID and Stock.ProductID=Product.P_ID and name like '" + txtSupplierName.Text + "%' order by name", cc.con);
                cc.da = new SqlDataAdapter(cc.cmd);
                cc.ds = new DataSet();
                cc.da.Fill(cc.ds, "Stock");
                dgw.DataSource = cc.ds.Tables["Stock"].DefaultView;
                cc.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
