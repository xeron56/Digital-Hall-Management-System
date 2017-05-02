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
    public partial class Meal_Record : Form
    {
        ConnectionString cs = new ConnectionString();
        CommonClasses cc = new CommonClasses();
        public Meal_Record()
        {
            InitializeComponent();
        }
        public void GetData()
        {
            try
            {
                cc.con = new SqlConnection(cs.DBConn);
                cc.con.Open();
                cc.cmd = new SqlCommand("SELECT RTRIM(P_ID) as [ID],RTRIM(ProductID) as [Product ID],RTRIM(ProductName) as [Product Name],RTRIM(CategoryName) as [Category],RTRIM(SubCategoryID) as [Sub Category ID],RTRIM(SubCategoryName) as [Sub Category],RTRIM(Features) as [Features],RTRIM(Price) as [Price],RTRIM(VAT) as [VAT],RTRIM(ST) as [ST],RTRIM(Discount) as [Discount],Photo from Product,Category,SubCategory where Product.SubCategoryID=SubCategory.Scat_ID and Category.Cat_ID=SubCategory.CategoryID order by Productname", cc.con);
                cc.da = new SqlDataAdapter(cc.cmd);
                cc.ds = new DataSet();
                cc.da.Fill(cc.ds, "Product");
                dgw.DataSource = cc.ds.Tables["Product"].DefaultView;
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
                cc.cmd = new SqlCommand("SELECT RTRIM(P_ID) as [ID],RTRIM(ProductID) as [Product ID],RTRIM(ProductName) as [Product Name],RTRIM(CategoryName) as [Category],RTRIM(SubCategoryID) as [Sub Category ID],RTRIM(SubCategoryName) as [Sub Category],RTRIM(Features) as [Features],RTRIM(Price) as [Price],RTRIM(VAT) as [VAT],RTRIM(ST) as [ST],RTRIM(Discount) as [Discount],Photo from Product,Category,SubCategory where Product.SubCategoryID=SubCategory.Scat_ID and Category.Cat_ID=SubCategory.CategoryID WHERE Productname like '" + txtProductName.Text + "%' order by Productname", cc.con);
                cc.da = new SqlDataAdapter(cc.cmd);
                cc.ds = new DataSet();
                cc.da.Fill(cc.ds, "Product");
                dgw.DataSource = cc.ds.Tables["Product"].DefaultView;
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
                if (lblOperation.Text == "Product Master")
                {
                    DataGridViewRow dr = dgw.SelectedRows[0];
                    this.Hide();
                    Meal frm = new Meal();
                    frm.Show();
                    frm.txtID.Text = dr.Cells[0].Value.ToString();
                    frm.txtProductID.Text = dr.Cells[1].Value.ToString();
                    frm.txtProductName.Text = dr.Cells[2].Value.ToString();
                    frm.cmbCategory.Text = dr.Cells[3].Value.ToString();
                    frm.txtSubCategoryID.Text = dr.Cells[4].Value.ToString();
                    frm.cmbSubCategory.Text = dr.Cells[5].Value.ToString();
                    frm.txtFeatures.Text = dr.Cells[6].Value.ToString();
                    frm.txtPrice.Text = dr.Cells[7].Value.ToString();
                    frm.txtVAT.Text = dr.Cells[8].Value.ToString();
                    frm.txtServiceTax.Text = dr.Cells[9].Value.ToString();
                    frm.txtDiscount.Text = dr.Cells[10].Value.ToString();
                    byte[] data = (byte[])dr.Cells[11].Value;
                    MemoryStream ms = new MemoryStream(data);
                    frm.pictureBox1.Image = Image.FromStream(ms);
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

    }
}
