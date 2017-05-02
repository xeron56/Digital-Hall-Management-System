using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
namespace Hall_management_System_sdp
{
    public partial class Meal : Form
    {

        ConnectionString cs = new ConnectionString();
        CommonClasses cc = new CommonClasses();
        clsFunc cf = new clsFunc();
        string st1;
        string st2;
        public Meal()
        {
            InitializeComponent();
        }
        public void FillCombo()
        {
            try
            {
                cc.con = new SqlConnection(cs.DBConn);
                cc.con.Open();
                string ct = "select RTRIM(CategoryName) from Category order by CategoryName";
                cc.cmd = new SqlCommand(ct);
                cc.cmd.Connection = cc.con;
                cc.rdr = cc.cmd.ExecuteReader();
                while (cc.rdr.Read())
                {
                    cmbCategory.Items.Add(cc.rdr[0]);
                }
                cc.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void auto()
        {
            try
            {
                int Num = 0;
                cc.con = new SqlConnection(cs.DBConn);
                cc.con.Open();
                string sql = "SELECT MAX(P_ID+1) FROM Product";
                cc.cmd = new SqlCommand(sql);
                cc.cmd.Connection = cc.con;
                if (Convert.IsDBNull(cc.cmd.ExecuteScalar()))
                {
                    Num = 1;
                    txtID.Text = Convert.ToString(Num);
                    txtProductID.Text = Convert.ToString("P" + Num);
                }
                else
                {
                    Num = (int)(cc.cmd.ExecuteScalar());
                    txtID.Text = Convert.ToString(Num);
                    txtProductID.Text = Convert.ToString("P" + Num);
                }
                cc.cmd.Dispose();
                cc.con.Close();
                cc.con.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frmCategory_Load(object sender, EventArgs e)
        {
            Autocomplete();
            FillCombo();
        }
        private void delete_records()
        {

            try
            {
                int RowsAffected = 0;
                cc.con = new SqlConnection(cs.DBConn);
                cc.con.Open();
                string cq = "delete from Product where P_ID=" + txtID.Text + "";
                cc.cmd = new SqlCommand(cq);
                cc.cmd.Connection = cc.con;
                RowsAffected = cc.cmd.ExecuteNonQuery();
                if (RowsAffected > 0)
                {
                    st1 = lblUser.Text;
                    st2 = "deleted the Product '" + txtProductID.Text + "'";
                    cf.LogFunc(st1, System.DateTime.Now, st2);
                    Reset();
                    Autocomplete();
                    MessageBox.Show("Successfully deleted", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                }
                else
                {
                    MessageBox.Show("No Record found", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reset();
                    Autocomplete();
                }
                if (cc.con.State == ConnectionState.Open)
                {
                    cc.con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Autocomplete()
        {
            try
            {
                cc.con = new SqlConnection(cs.DBConn);
                cc.con.Open();
                cc.cmd = new SqlCommand("SELECT distinct Productname FROM Product", cc.con);
                cc.ds = new DataSet();
                cc.da = new SqlDataAdapter(cc.cmd);
                cc.da.Fill(cc.ds, "Product");
                AutoCompleteStringCollection col = new AutoCompleteStringCollection();
                int i = 0;
                for (i = 0; i <= cc.ds.Tables[0].Rows.Count - 1; i++)
                {
                    col.Add(cc.ds.Tables[0].Rows[i]["Productname"].ToString());

                }
                txtProductName.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtProductName.AutoCompleteCustomSource = col;
                txtProductName.AutoCompleteMode = AutoCompleteMode.Suggest;
                cc.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
 
        public void Reset()
        {
            txtProductID.Text = "";
            txtID.Text = "";
            cmbCategory.SelectedIndex=-1;
            cmbSubCategory.SelectedIndex = -1;
            txtSubCategoryID.Text = "";
            txtProductName.Text = "";
            cmbSubCategory.Text = "";
            cmbCategory.Text = "";
            txtPrice.Text = "";
            txtFeatures.Text = "";
            txtVAT.Text = "";
            txtServiceTax.Text = "";
            txtPrice.Text = "";
            txtDiscount.Text = "";
            pictureBox1.Image = Properties.Resources._12;
            btnSave.Enabled = true;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            cmbSubCategory.Enabled=false;
            txtProductName.Focus();
            auto();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtProductName.Text == "")
            {
                MessageBox.Show("Please enter product name", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtProductName.Focus();
                return;
            }
            if (cmbCategory.Text == "")
            {
                MessageBox.Show("Please select category", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbCategory.Focus();
                return;
            }
            if (cmbSubCategory.Text == "")
            {
                MessageBox.Show("Please select sub category", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbSubCategory.Focus();
                return;
            }
            if (txtPrice.Text == "")
            {
                MessageBox.Show("Please enter price", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrice.Focus();
                return;
            }
            if (txtServiceTax.Text == "")
            {
                MessageBox.Show("Please enter service tax", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtServiceTax.Focus();
                return;
            }
            if (txtVAT.Text == "")
            {
                MessageBox.Show("Please enter VAT", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtVAT.Focus();
                return;
            }
            if (txtDiscount.Text == "")
            {
                MessageBox.Show("Please enter discount", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDiscount.Focus();
                return;
            }
            try
            {
                cc.con = new SqlConnection(cs.DBConn);
                cc.con.Open();
                string ct = "select ProductName from Product where ProductName=@d1";
                cc.cmd = new SqlCommand(ct);
                cc.cmd.Connection = cc.con;
                cc.cmd.Parameters.AddWithValue("@d1", txtProductName.Text);
                cc.rdr = cc.cmd.ExecuteReader();
                if (cc.rdr.Read())
                {
                    MessageBox.Show("Product Name Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtProductName.Text = "";
                    txtProductName.Focus();
                    if ((cc.rdr != null))
                    {
                        cc.rdr.Close();
                    }
                    return;
                }

                cc.con = new SqlConnection(cs.DBConn);
                cc.con.Open();
                string cb = "insert into Product(P_ID,ProductID,ProductName,SubCategoryID,Features,Price,VAT,ST,Discount,Photo) VALUES ("+ txtID.Text +",'" + txtProductID.Text + "',@d1," + txtSubCategoryID.Text + ",@d2," + txtPrice.Text +"," + txtVAT.Text +","+ txtServiceTax.Text +","+ txtDiscount.Text +",@d3)";
                cc.cmd = new SqlCommand(cb);
                cc.cmd.Connection = cc.con;
                cc.cmd.Parameters.AddWithValue("@d1", txtProductName.Text);
                cc.cmd.Parameters.AddWithValue("@d2", txtFeatures.Text);
                MemoryStream ms = new MemoryStream();
                Bitmap bmpImage = new Bitmap(pictureBox1.Image);
                bmpImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] data = ms.GetBuffer();
                SqlParameter p = new SqlParameter("@d3", SqlDbType.Image);
                p.Value = data;
                cc.cmd.Parameters.Add(p);
                cc.cmd.ExecuteReader();
                cc.con.Close();
                st1 = lblUser.Text;
                st2 = "added the new product '" + txtProductName.Text + "'";
                cf.LogFunc(st1,System.DateTime.Now,st2);
                Autocomplete();
                btnSave.Enabled = false;
                MessageBox.Show("Successfully saved", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                delete_records();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtProductName.Text == "")
                {
                    MessageBox.Show("Please enter product name", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtProductName.Focus();
                    return;
                }
                if (cmbCategory.Text == "")
                {
                    MessageBox.Show("Please select category", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbCategory.Focus();
                    return;
                }
                if (cmbSubCategory.Text == "")
                {
                    MessageBox.Show("Please select sub category", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbSubCategory.Focus();
                    return;
                }
                if (txtPrice.Text == "")
                {
                    MessageBox.Show("Please enter price", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPrice.Focus();
                    return;
                }
                if (txtServiceTax.Text == "")
                {
                    MessageBox.Show("Please enter service tax", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtServiceTax.Focus();
                    return;
                }
                if (txtVAT.Text == "")
                {
                    MessageBox.Show("Please enter VAT", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtVAT.Focus();
                    return;
                }
                if (txtDiscount.Text == "")
                {
                    MessageBox.Show("Please enter discount", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDiscount.Focus();
                    return;
                }
                cc.con = new SqlConnection(cs.DBConn);
                cc.con.Open();
                string cb = "Update Product set ProductID='" + txtProductID.Text + "',ProductName=@d1,SubCategoryID=" + txtSubCategoryID.Text + ",Features=@d2,Price=" + txtPrice.Text + ",VAT=" + txtVAT.Text + ",ST=" + txtServiceTax.Text + ",Discount=" + txtDiscount.Text + ",Photo=@d3 where P_ID=" + txtID.Text + "";
                cc.cmd = new SqlCommand(cb);
                cc.cmd.Connection = cc.con;
                cc.cmd.Parameters.AddWithValue("@d1", txtProductName.Text);
                cc.cmd.Parameters.AddWithValue("@d2", txtFeatures.Text);
                MemoryStream ms = new MemoryStream();
                Bitmap bmpImage = new Bitmap(pictureBox1.Image);
                bmpImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] data = ms.GetBuffer();
                SqlParameter p = new SqlParameter("@d3", SqlDbType.Image);
                p.Value = data;
                cc.cmd.Parameters.Add(p);
                cc.cmd.ExecuteReader();
                cc.con.Close();
                st1 = lblUser.Text;
                st2 = "updated the product '" + txtProductID.Text + "' details";
                cf.LogFunc(st1, System.DateTime.Now, st2);
                Autocomplete();
                btnUpdate.Enabled = false;
                MessageBox.Show("Successfully updated", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      
      
        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cmbCategory.Text = cmbCategory.Text.Trim();
                cmbSubCategory.Items.Clear();
                cmbSubCategory.Text = "";
                cmbSubCategory.Enabled = true;
                cmbSubCategory.Focus();
                cc.con = new SqlConnection(cs.DBConn);
                cc.con.Open();
                string ct = "select distinct RTRIM(SubCategoryName) from Category,SubCategory where Category.Cat_ID=SubCategory.CategoryID and CategoryName=@d1";
                cc.cmd = new SqlCommand(ct);
                cc.cmd.Connection = cc.con;
                cc.cmd.Parameters.AddWithValue("@d1", cmbCategory.Text);
                cc.rdr = cc.cmd.ExecuteReader();
                while (cc.rdr.Read())
                {
                    cmbSubCategory.Items.Add(cc.rdr[0]);
                }
                cc.con.Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                var _with1 = openFileDialog1;

                _with1.Filter = ("Image Files |*.png; *.bmp; *.jpg;*.jpeg; *.gif;");
                _with1.FilterIndex = 4;
                //Reset the file name
                openFileDialog1.FileName = "";

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbSubCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cc.con = new SqlConnection(cs.DBConn);
                cc.con.Open();
                cc.cmd = cc.con.CreateCommand();
                cc.cmd.CommandText = "SELECT SCat_ID from SubCategory WHERE SubCategoryName=@d1";
                cc.cmd.Parameters.AddWithValue("@d1", cmbSubCategory.Text);
                cc.rdr = cc.cmd.ExecuteReader();
                if (cc.rdr.Read())
                {
                    txtSubCategoryID.Text = cc.rdr.GetInt32(0).ToString().Trim();
                }
                if ((cc.rdr != null))
                {
                    cc.rdr.Close();
                }
                if (cc.con.State == ConnectionState.Open)
                {
                    cc.con.Close();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows 0-9, backspace, and decimal
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtServiceTax_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows 0-9, backspace, and decimal
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtVAT_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows 0-9, backspace, and decimal
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows 0-9, backspace, and decimal
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }
        }

        private void btnGetData_Click(object sender, EventArgs e)
        {
            this.Hide();
            Meal_Record frm = new Meal_Record();

            frm.Reset();
            frm.lblOperation.Text = "Product Master";
            frm.lblUser.Text = lblUser.Text;
            frm.Show();
        }

   
    
    }
}
