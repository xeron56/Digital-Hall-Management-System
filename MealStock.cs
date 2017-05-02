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
    public partial class MealStock : Form
    {
        ConnectionString cs = new ConnectionString();
        CommonClasses cc = new CommonClasses();
        clsFunc cf = new clsFunc();
        string st1;
        string st2;
        public MealStock()
        {
            InitializeComponent();
        }

      public void Reset()
        {
        cmbSupplierName.SelectedIndex = -1;
        cmbProductName.SelectedIndex = -1;
        txtQuantity.Text = "";
        txtStockID.Text="";
        txtProductID.Text = "";
        txtSupplierID.Text = "";
        txtID.Text = "";
        dtpDate.Text = System.DateTime.Now.ToString();
        txtStockID.Focus();
        btnSave.Enabled = true;
        btnUpdate.Enabled = false;
        btnDelete.Enabled = false;
        auto();
        }
      private void delete_records()
      {

         
              int RowsAffected = 0;
              cc.con = new SqlConnection(cs.DBConn);
              cc.con.Open();
              string cb2 = "Update Temp_Stock set Quantity=Quantity - " + txtQty1.Text + " where ProductID=" + txtProductID.Text + "";
              cc.cmd = new SqlCommand(cb2);
              cc.cmd.Connection = cc.con;
              cc.cmd.ExecuteReader();
              cc.con.Close();
              cc.con = new SqlConnection(cs.DBConn);
              cc.con.Open();
              string cq = "delete from Stock where ST_ID=" + txtID.Text + "";
              cc.cmd = new SqlCommand(cq);
              cc.cmd.Connection = cc.con;
              RowsAffected = cc.cmd.ExecuteNonQuery();
              if (RowsAffected > 0)
              {
                  st1 = lblUser.Text;
                  st2 = "deleted the stock record of product'" + cmbProductName.Text + "' having stock id '" + txtStockID.Text + "'";
                  cf.LogFunc(st1, System.DateTime.Now, st2);
                  MessageBox.Show("Successfully deleted", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                  Reset();
              }
              else
              {
                  MessageBox.Show("No Record found", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Information);
                  Reset();
              }
              if (cc.con.State == ConnectionState.Open)
              {
                  cc.con.Close();
              }


          /*
          catch (Exception ex)
          {
              MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
          }*/
      }
  
       
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void auto()
        {
           
                int Num = 0;
                cc.con = new SqlConnection(cs.DBConn);
                cc.con.Open();
                string sql = "SELECT MAX(ST_ID+1) FROM Stock";
                cc.cmd = new SqlCommand(sql);
                cc.cmd.Connection = cc.con;
                if (Convert.IsDBNull(cc.cmd.ExecuteScalar()))
                {
                    Num = 1;
                    txtID.Text = Convert.ToString(Num);
                    txtStockID.Text = "ST-" + Convert.ToString(Num);
                }
                else
                {
                    Num = (int)(cc.cmd.ExecuteScalar());
                    txtID.Text = Convert.ToString(Num);
                    txtStockID.Text = "ST-" + Convert.ToString(Num);
                }
                cc.cmd.Dispose();
                cc.con.Close();
                cc.con.Dispose();
            /*
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }
        private void btnSave_Click(object sender, EventArgs e)
        {

           
                if (cmbProductName.Text == "")
                {
                    MessageBox.Show("Please select product name", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbProductName.Focus();
                    return;
                }
                if (cmbSupplierName.Text == "")
                {
                    MessageBox.Show("Please select supplier name", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbSupplierName.Focus();
                    return;
                }
                if (txtQuantity.Text == "")
                {
                    MessageBox.Show("Please enter quantity", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtQuantity.Focus();
                    return;
                }
                cc.con = new SqlConnection(cs.DBConn);
                cc.con.Open();

                string ct = "select ProductID from temp_Stock where ProductID=" + txtProductID.Text + "";
                cc.cmd = new SqlCommand(ct);
                cc.cmd.Connection = cc.con;
                cc.rdr = cc.cmd.ExecuteReader();

                if (cc.rdr.Read())
                {
                    cc.con = new SqlConnection(cs.DBConn);
                    cc.con.Open();
                    string cb2 = "Update Temp_Stock set Quantity=Quantity + " + txtQuantity.Text + " where ProductID=" + txtProductID.Text + "";
                    cc.cmd = new SqlCommand(cb2);
                    cc.cmd.Connection = cc.con;
                    cc.cmd.ExecuteReader();
                    cc.con.Close();

                }
                else
                {
                    cc.con = new SqlConnection(cs.DBConn);
                    cc.con.Open();
                    string cb1 = "insert into Temp_Stock(ProductID,Quantity) VALUES (" + txtProductID.Text + "," + txtQuantity.Text + ")";
                    cc.cmd = new SqlCommand(cb1);
                    cc.cmd.Connection = cc.con;

                    cc.cmd.ExecuteReader();
                    cc.con.Close(); 
                }
                    cc.con = new SqlConnection(cs.DBConn);
                    cc.con.Open();
                    string cb = "insert into Stock(ST_ID,StockID,ProductID,SupplierID,Quantity,Date) VALUES (" + txtID.Text + ",'"+ txtStockID.Text +"',"+ txtProductID.Text +","+ txtSupplierID.Text +"," + txtQuantity.Text +",@d1)";
                    cc.cmd = new SqlCommand(cb);
                    cc.cmd.Connection = cc.con;
                    cc.cmd.Parameters.AddWithValue("@d1", dtpDate.Value);
                    cc.cmd.ExecuteReader();
                    cc.con.Close();
                    st1 = lblUser.Text;
                    st2 = "added the new stock of product'" + cmbProductName.Text + "' having stock id '" + txtStockID.Text + "'";
                    cf.LogFunc(st1, System.DateTime.Now, st2);
                    btnSave.Enabled = false;
                    MessageBox.Show("Successfully saved", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
            /*
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }
    
      
      

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
                if (cmbProductName.Text == "")
                {
                    MessageBox.Show("Please select product name", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbProductName.Focus();
                    return;
                }
                if (cmbSupplierName.Text == "")
                {
                    MessageBox.Show("Please select supplier name", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbSupplierName.Focus();
                    return;
                }
                if (txtQuantity.Text == "")
                {
                    MessageBox.Show("Please enter quantity", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtQuantity.Focus();
                    return;
                }
                cc.con = new SqlConnection(cs.DBConn);
                cc.con.Open();

                string ct = "select ProductID from temp_Stock where ProductID=" + txtProductID.Text + "";
                cc.cmd = new SqlCommand(ct);
                cc.cmd.Connection = cc.con;
                cc.rdr = cc.cmd.ExecuteReader();

                if (cc.rdr.Read())
                {
                    cc.con = new SqlConnection(cs.DBConn);
                    cc.con.Open();
                    string cb2 = "Update Temp_Stock set Quantity=Quantity + " + txtQuantity.Text + "- " + txtQty1.Text + " where ProductID=" + txtProductID.Text + "";
                    cc.cmd = new SqlCommand(cb2);
                    cc.cmd.Connection = cc.con;
                    cc.cmd.ExecuteReader();
                    cc.con.Close();

                }
                    cc.con = new SqlConnection(cs.DBConn);
                    cc.con.Open();
                    string cb = "Update Stock set StockID='" + txtStockID.Text + "',ProductID=" + txtProductID.Text + ",SupplierID=" + txtSupplierID.Text + ",Date=@d1,Quantity=" + txtQuantity.Text + " where ST_ID=" + txtID.Text + "";
                    cc.cmd = new SqlCommand(cb);
                    cc.cmd.Connection = cc.con;
                    cc.cmd.Parameters.AddWithValue("@d1", dtpDate.Value);
                    cc.cmd.ExecuteReader();
                    cc.con.Close();
                    st1 = lblUser.Text;
                    st2 = "updated the stock of product'" + cmbProductName.Text + "' having stock id '" + txtStockID.Text + "'";
                    cf.LogFunc(st1, System.DateTime.Now, st2);
                    btnUpdate.Enabled = false;
                    MessageBox.Show("Successfull updated", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            /*
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }

    
        private void btnNew_Click(object sender, EventArgs e)
        {
            Reset();
        }

    
     
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                delete_records();
            }
        }

      
        private void btnGetData_Click(object sender, EventArgs e)
        {
            this.Hide();
            MealStockRecord frm = new MealStockRecord();
            frm.Reset();
            frm.lblOperation.Text = "Stock";
            frm.lblUser.Text = lblUser.Text;
            frm.Show();
        }

        private void cmbProductName_SelectedIndexChanged(object sender, EventArgs e)
        {
           
                cc.con = new SqlConnection(cs.DBConn);
                cc.con.Open();
                cc.cmd = cc.con.CreateCommand();
                cc.cmd.CommandText = "SELECT P_ID from Product where ProductName=@d1";
                cc.cmd.Parameters.AddWithValue("@d1", cmbProductName.Text);
                cc.rdr = cc.cmd.ExecuteReader();

                if (cc.rdr.Read())
                {
                    txtProductID.Text = cc.rdr.GetValue(0).ToString().Trim();
                }
                if ((cc.rdr != null))
                {
                    cc.rdr.Close();
                }
                if (cc.con.State == ConnectionState.Open)
                {
                    cc.con.Close();
                }
            /*
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }

        private void cmbSupplierName_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                cc.con = new SqlConnection(cs.DBConn);
                cc.con.Open();
                cc.cmd = cc.con.CreateCommand();
                cc.cmd.CommandText = "SELECT S_ID from Supplier where Name=@d1";
                cc.cmd.Parameters.AddWithValue("@d1", cmbSupplierName.Text);
                cc.rdr = cc.cmd.ExecuteReader();

                if (cc.rdr.Read())
                {
                    txtSupplierID.Text = cc.rdr.GetValue(0).ToString().Trim();
                }
                if ((cc.rdr != null))
                {
                    cc.rdr.Close();
                }
                if (cc.con.State == ConnectionState.Open)
                {
                    cc.con.Close();
                }
            /*
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }
        public void FillProductName()
        {
            
                cc.con = new SqlConnection(cs.DBConn);
                cc.con.Open();
                string ct = "select RTRIM(ProductName) from Product order by ProductName";
                cc.cmd = new SqlCommand(ct);
                cc.cmd.Connection = cc.con;
                cc.rdr = cc.cmd.ExecuteReader();
                while (cc.rdr.Read())
                {
                    cmbProductName.Items.Add(cc.rdr[0]);
                }
                cc.con.Close();
            /*
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }
        public void FillSupplier()
        {
            
                cc.con = new SqlConnection(cs.DBConn);
                cc.con.Open();
                string ct = "select RTRIM(Name) from Supplier order by Name";
                cc.cmd = new SqlCommand(ct);
                cc.cmd.Connection = cc.con;
                cc.rdr = cc.cmd.ExecuteReader();
                while (cc.rdr.Read())
                {
                    cmbSupplierName.Items.Add(cc.rdr[0]);
                }
                cc.con.Close();
            /*
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }
        private void frmStock_Load(object sender, EventArgs e)
        {
            FillProductName();
            FillSupplier();

        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

    }
}