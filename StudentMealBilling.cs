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
    public partial class StudentMealBilling : Form
    {
        ConnectionString cs = new ConnectionString();
        CommonClasses cc = new CommonClasses();
        clsFunc cf = new clsFunc();
        string st1;
        string st2;
        public StudentMealBilling()
        {
            InitializeComponent();
        }
        public void Clear()
        {
            cmbProductName.Text = "";
            txtPrice.Text = "";
            txtQty.Text = "";
            txtAmt.Text = "";
            txtServiceTaxAmount.Text = "";
            txtServiceTaxPer.Text = "";
            txtDiscountAmount.Text = "";
            txtDiscountPer.Text = "";
            txtVATAmt.Text = "";
            txtVATPer.Text = "";
            txtTotalAmt.Text = "";
        }
      public void Reset()
        {
          txtBillNo.Text = "";
          cmbProductName.Text = "";
          txtID.Text = "";
          txtAmt.Text = "";
          txtCustomerID.Text = "";
          txtCustomerName.Text = "";
          txtDiscountAmount.Text = "";
          txtDiscountPer.Text = "";
          txtQty.Text = "";
          txtPrice.Text = "";
          txtServiceTaxAmount.Text = "";
          txtServiceTaxPer.Text = "";
          txtTotalAmt.Text = "";
          txtVATPer.Text = "";
          txtVATAmt.Text = "";
          txtProductID.Text = "";
          txtAvailableQty.Text = "";
          dtpBillDate.Text = System.DateTime.Now.ToString();
          dtpBillDate.Enabled = true;
          txtGrandTotal.Text = "";
          txtCash.Text = "";
          txtChange.Text = "";
          txtAvailableQty.Text = "";
          DataGridView1.Rows.Clear();
        btnSave.Enabled = true;
        btnRemove.Enabled = false;
        btnAdd.Enabled = true;
        btnUpdate.Enabled = false;
        btnDelete.Enabled = false;
        auto();
        }
     
  
        private void delete_records()
        {

           
                int RowsAffected = 0;
                cc.con = new SqlConnection(cs.DBConn);
                cc.con.Open();
                string ct = "delete from OrderedProduct where B_ID=@d1";
                cc.cmd = new SqlCommand(ct);
                cc.cmd.Connection = cc.con;
                cc.cmd.Parameters.AddWithValue("@d1", txtID.Text);
                RowsAffected = cc.cmd.ExecuteNonQuery();
                if (RowsAffected > 0)
                {
                    st1 = lblUser.Text;
                    st2 = "deleted the Bill No.'" + txtBillNo.Text + "'";
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
             
            
            /*catch (Exception ex)
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
                string sql = "SELECT MAX(B_ID+1) FROM OrderedProduct";
                cc.cmd = new SqlCommand(sql);
                cc.cmd.Connection = cc.con;
                if (Convert.IsDBNull(cc.cmd.ExecuteScalar()))
                {
                    Num = 1;
                    txtID.Text = Convert.ToString(Num);
                    txtBillNo.Text = "B-" + Convert.ToString(Num);
                }
                else
                {
                    Num = (int)(cc.cmd.ExecuteScalar());
                    txtID.Text = Convert.ToString(Num);
                    txtBillNo.Text = "B-" + Convert.ToString(Num);
                }
                cc.cmd.Dispose();
                cc.con.Close();
                cc.con.Dispose();
            
           /* catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
           
           
            if (txtCustomerID.Text == "")
                {
                    MessageBox.Show("Please retieve Student Info", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            button1.Focus();
            return;
            }
            if (DataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("sorry no product added to cart", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtCash.Text=="")
            {
                MessageBox.Show("Please enter cash", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCash.Focus();
                return;
            }
            double val1 = 0;
            double val2 = 0;
            double.TryParse(txtGrandTotal.Text, out val1);
            double.TryParse(txtCash.Text, out val2);
            if (val2 < val1)
            {
                MessageBox.Show("Cash can not less than grand total", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCash.Text = "";
                txtCash.Focus();
                return;

            }
            cc.con = new SqlConnection(cs.DBConn);
            cc.con.Open();
            string cb = "insert into OrderedProduct( B_Id, BillNo, BillDate, GrandTotal, Cash, Change,CustomerID) Values (" + txtID.Text + ",'" + txtBillNo.Text + "','" + dtpBillDate.Value + "'," + txtGrandTotal.Text + "," + txtCash.Text + "," + txtChange.Text + "," + txtC_Id.Text + ")";
            cc.cmd = new SqlCommand(cb);
            cc.cmd.Connection = cc.con;
            cc.cmd.ExecuteReader();
            cc.con.Close();
            cc.con = new SqlConnection(cs.DBConn);
            cc.con.Open();
            string cb1 = "insert into ProductSold(BillID,ProductID,Price,Quantity,Amount,DiscountPer, DiscountAmount, STPer, STAmount, VATPer, VATAmount,TotalAmount ) VALUES (" + txtID.Text + ",@d1,@d2,@d3,@d4,@d5,@d6,@d7,@d8,@d9,@d10,@d11)";
            cc.cmd = new SqlCommand(cb1);
            cc.cmd.Connection = cc.con;
            // Prepare command for repeated execution
            cc.cmd.Prepare();
            // Data to be inserted
            foreach (DataGridViewRow row in DataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    cc.cmd.Parameters.AddWithValue("@d1", row.Cells[0].Value);
                    cc.cmd.Parameters.AddWithValue("@d2", row.Cells[2].Value);
                    cc.cmd.Parameters.AddWithValue("@d3", row.Cells[3].Value);
                    cc.cmd.Parameters.AddWithValue("@d4", row.Cells[4].Value);
                    cc.cmd.Parameters.AddWithValue("@d5", row.Cells[5].Value);
                    cc.cmd.Parameters.AddWithValue("@d6", row.Cells[6].Value);
                    cc.cmd.Parameters.AddWithValue("@d7", row.Cells[7].Value);
                    cc.cmd.Parameters.AddWithValue("@d8", row.Cells[8].Value);
                    cc.cmd.Parameters.AddWithValue("@d9", row.Cells[9].Value);
                    cc.cmd.Parameters.AddWithValue("@d10", row.Cells[10].Value);
                    cc.cmd.Parameters.AddWithValue("@d11", row.Cells[11].Value);
                    cc.cmd.ExecuteNonQuery();
                    cc.cmd.Parameters.Clear();
                }
            }
            foreach (DataGridViewRow row in DataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    cc.con.Close();
                    cc.con = new SqlConnection(cs.DBConn);
                    cc.con.Open();
                    string cb2 = "update Temp_Stock set Quantity=Quantity - " + row.Cells[3].Value + " where ProductID=" + row.Cells[0].Value + "";
                    cc.cmd = new SqlCommand(cb2);
                    cc.cmd.Connection = cc.con;
                    cc.cmd.ExecuteNonQuery();
                    if (cc.con.State == ConnectionState.Open)
                    {
                        cc.con.Close();
                    }
                    cc.con.Close();
                }
            }
                st1 = lblUser.Text;
                st2 = "added the new Bill having bill no. '" + txtBillNo.Text + "'";
                cf.LogFunc(st1, System.DateTime.Now, st2);
                btnSave.Enabled = false;
                MessageBox.Show("Successfully done", "Billing", MessageBoxButtons.OK, MessageBoxIcon.Information);
            /*
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }
    
      
      

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
                if (txtCustomerID.Text == "")
                {
                    MessageBox.Show("Please retieve StudentInfo", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    button1.Focus();
                    return;
                }
                if (DataGridView1.Rows.Count == 0)
                {
                    MessageBox.Show("sorry no product added to cart", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (txtCash.Text == "")
                {
                    MessageBox.Show("Please enter cash", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCash.Focus();
                    return;
                }
                double val1 = 0;
                double val2 = 0;
                double.TryParse(txtGrandTotal.Text, out val1);
                double.TryParse(txtCash.Text, out val2);
                if (val2 < val1)
                {
                    MessageBox.Show("Cash can not less than grand total", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCash.Text = "";
                    txtCash.Focus();
                    return;

                }
                cc.con = new SqlConnection(cs.DBConn);
                cc.con.Open();
                string cb = "update OrderedProduct set StudentID=" + txtC_Id.Text + ", GrandTotal=" + txtGrandTotal.Text + ",Cash=" + txtCash.Text + ",Change=" + txtChange.Text + " where B_ID=" + txtID.Text + "";
                cc.cmd = new SqlCommand(cb);
                cc.cmd.Connection = cc.con;
                cc.cmd.ExecuteNonQuery();
                if (cc.con.State == ConnectionState.Open)
                {
                    cc.con.Close();
                }
                cc.con.Close();
                st1 = lblUser.Text;
                st2 = "updated the Bill having bill no. '" + txtBillNo.Text + "'";
                cf.LogFunc(st1, System.DateTime.Now, st2);
                btnUpdate.Enabled = false;
                MessageBox.Show("Successfully updated", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            //StudentMealBilling frm = new StudentMealBilling();
            StudentMealBillingRecord frm = new StudentMealBillingRecord();
            frm.Reset();
            frm.lblOperation.Text = "Sales";
            frm.lblUser.Text = lblUser.Text;
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
           Student_Entry_Record frm = new Student_Entry_Record();
            
            frm.Reset();
            frm.lblOperation.Text = "Sales";
            frm.lblUser.Text = lblUser.Text;
            frm.Show();
        }

        private void txtCash_Validating(object sender, CancelEventArgs e)
        {
            double val1 = 0;
            double val2 = 0;
            double.TryParse(txtGrandTotal.Text, out val1);
            double.TryParse(txtCash.Text, out val2);
            if (val2 < val1)
            {
                MessageBox.Show("Cash can not less than grand total", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCash.Text = "";
                txtCash.Focus();
                return;

            }
        }

        private void txtCash_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows 0-9, backspace, and decimal
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
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
        public void Calculate()
        {
           
                double val1 = 0;
                double val2 = 0;
                double val3 = 0;
                double val4 = 0;
                double val5 = 0;
                double val6 = 0;
                double val7 = 0;
                double val8 = 0;
                double val9 = 0;
                int val12 = 0;
                double val13 = 0;
                int.TryParse(txtQty.Text, out val12);
                double.TryParse(txtPrice.Text, out val13);
                double.TryParse(txtDiscountPer.Text, out val2);
                double.TryParse(txtServiceTaxPer.Text, out val5);
                double.TryParse(txtVATPer.Text, out val7);
                val1 = Convert.ToDouble(val12 * val13);
                val1 = Math.Round(val1, 2);
                txtAmt.Text = val1.ToString();
                val3 = Convert.ToDouble((val1 * val2) / 100);
                val3 = Math.Round(val3, 2);
                txtDiscountAmount.Text = val3.ToString();
                val4 = Convert.ToDouble(val1 - val3);
                val4 = Math.Round(val4, 2);
                txtSubTotal.Text = val4.ToString();
                val6 = Convert.ToDouble((val4 * val5) / 100);
                val6 = Math.Round(val6, 2);
                txtServiceTaxAmount.Text = val6.ToString();
                val8 = Convert.ToDouble((val4 * val7) / 100);
                val8 = Math.Round(val8, 2);
                txtVATAmt.Text = val8.ToString();
                val9 = Convert.ToDouble(val4 + val6 + val8);
                val9 = Math.Round(val9, 2);
                txtTotalAmt.Text = val9.ToString();
            /*
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }*/
        }
        public void Compute2()
        {
            
                double val1 = 0;
                double val2 = 0;
                double.TryParse(txtCash.Text, out val1);
                double.TryParse(txtGrandTotal.Text, out val2);
                double number = 0;
                number = Convert.ToDouble(val1-val2);
                number = Math.Round(number, 2);
                txtChange.Text = number.ToString();
            /*
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }
        public double GrandTotal()
        {
            double sum = 0;
           
                foreach (DataGridViewRow r in this.DataGridView1.Rows)
                {
                    sum = sum + Convert.ToDouble(r.Cells[11].Value);
                }
            /*
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
            return sum;
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {

             foreach (DataGridViewRow row in DataGridView1.SelectedRows)
                {
                    DataGridView1.Rows.Remove(row);
                }
                double k = 0;
                k =(double)GrandTotal();
                k = Math.Round(k, 2);
                txtGrandTotal.Text = k.ToString();
                Compute2();
                btnRemove.Enabled = false;
            /*
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }

        private void txtCash_TextChanged(object sender, EventArgs e)
        {
            Compute2();
        }

        private void cmProductName_SelectedIndexChanged(object sender, EventArgs e)
        {

           
                cc.con = new SqlConnection(cs.DBConn);
                cc.con.Open();
                cc.cmd = cc.con.CreateCommand();
                cc.cmd.CommandText = "SELECT Price,VAT,ST,Discount,P_ID FROM Product WHERE ProductName=@d1";
                cc.cmd.Parameters.AddWithValue("@d1", cmbProductName.Text);
                cc.rdr = cc.cmd.ExecuteReader();
                if (cc.rdr.Read())
                {
                    txtPrice.Text = cc.rdr.GetValue(0).ToString();
                    txtVATPer.Text = cc.rdr.GetValue(1).ToString();
                    txtServiceTaxPer.Text = cc.rdr.GetValue(2).ToString();
                    txtDiscountPer.Text = cc.rdr.GetValue(3).ToString();
                    txtProductID.Text = cc.rdr.GetValue(4).ToString();
                }
                if ((cc.rdr != null))
                {
                    cc.rdr.Close();
                }
                if (cc.con.State == ConnectionState.Open)
                {
                    cc.con.Close();
                }
                cc.con = new SqlConnection(cs.DBConn);
                cc.con.Open();
                cc.cmd = cc.con.CreateCommand();
                cc.cmd.CommandText = "SELECT quantity FROM Product,Temp_Stock WHERE product.P_ID=Temp_Stock.ProductID and ProductName=@d1";
                cc.cmd.Parameters.AddWithValue("@d1", cmbProductName.Text);
                cc.rdr = cc.cmd.ExecuteReader();
                if (cc.rdr.Read())
                {
                    txtAvailableQty.Text = cc.rdr.GetValue(0).ToString();
     
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

        private void btnAdd_Click(object sender, EventArgs e)
        {

            
                if (txtCustomerID.Text == "")
                {
                    MessageBox.Show("Please retieve Student Info", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    button1.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txtQty.Text))
                {
                    MessageBox.Show("Please enter quantity", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtQty.Focus();
                    return;
                }
                if (txtQty.Text == 0.ToString())
                {
                    MessageBox.Show("Quantity can not be zero", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtQty.Focus();
                    return;
                }
                if (DataGridView1.Rows.Count == 0)
                {
                    DataGridView1.Rows.Add(txtProductID.Text,cmbProductName.Text, txtPrice.Text, txtQty.Text, txtAmt.Text, txtDiscountPer.Text, txtDiscountAmount.Text, txtServiceTaxPer.Text, txtServiceTaxAmount.Text, txtVATPer.Text, txtVATAmt.Text,txtTotalAmt.Text);
                    double k = 0;
                    k = GrandTotal();
                    k = Math.Round(k, 2);
                    txtGrandTotal.Text = k.ToString();
                    Clear();
                    return;
                }
                foreach (DataGridViewRow r in this.DataGridView1.Rows)
                {
                    if (r.Cells[0].Value.ToString() == txtProductID.Text)
                    {
                        double val1 = 0;
                        double val2 = 0;
                        double val4 = 0;
                        //double val5 = 0;
                        double val7 = 0;
                        double val6 = 0;
                        double val8 = 0;
                        double val9;
                        double val10 = 0;
                        double val11 = 0;
                        int val12 = 0;
                        int val13 = 0;
                        double val14 = 0;
                        double val15 = 0;
                        int.TryParse(r.Cells[3].Value.ToString(), out val12);
                        int.TryParse(txtQty.Text, out val13);
                        double.TryParse(r.Cells[4].Value.ToString(), out val1);
                        double.TryParse(txtAmt.Text, out val2);
                        double.TryParse(r.Cells[6].Value.ToString(), out val4);
                        //double.TryParse(txtDiscountAmount.ToString(), out val5);
                        double.TryParse(txtServiceTaxPer.Text, out val6);
                        double.TryParse(r.Cells[8].Value.ToString(), out val7);
                        double.TryParse(txtServiceTaxAmount.Text, out val8);
                        double.TryParse(txtVATPer.Text, out val9);
                        double.TryParse(r.Cells[10].Value.ToString(), out val10);
                        double.TryParse(txtVATAmt.Text, out val11);
                        double.TryParse(r.Cells[11].Value.ToString(), out val14);
                        double.TryParse(txtTotalAmt.Text, out val15);
                        r.Cells[0].Value = txtProductID.Text;
                        r.Cells[1].Value = cmbProductName.Text;
                        r.Cells[2].Value = txtPrice.Text;
                        r.Cells[3].Value = val12 + val13;
                        r.Cells[4].Value = val1 + val2;
                        r.Cells[5].Value = txtDiscountPer.Text;
                        r.Cells[6].Value = val4 + Convert.ToDouble(txtDiscountAmount.Text);
                        r.Cells[7].Value = val6;
                        r.Cells[8].Value = val7 + val8;
                        r.Cells[9].Value = val9;
                        r.Cells[10].Value = val10 + val11;
                        r.Cells[11].Value = val14 + val15;
                        double i = 0;
                        i = GrandTotal();
                        i = Math.Round(i, 2);
                        txtGrandTotal.Text = i.ToString();
                        Clear();
                        return;
                    }
                }
                DataGridView1.Rows.Add(txtProductID.Text, cmbProductName.Text, txtPrice.Text, txtQty.Text, txtAmt.Text, txtDiscountPer.Text, txtDiscountAmount.Text, txtServiceTaxPer.Text, txtServiceTaxAmount.Text, txtVATPer.Text, txtVATAmt.Text, txtTotalAmt.Text);
                double j = 0;
                j = GrandTotal();
                j = Math.Round(j, 2);
                txtGrandTotal.Text = j.ToString();
                Clear();
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
        private void frmSales_Load(object sender, EventArgs e)
        {
            FillProductName();
        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void txtQty_Validating(object sender, CancelEventArgs e)
        {
            int val1 = 0;
            int val2 = 0;
            int.TryParse(txtQty.Text, out val1);
            int.TryParse(txtAvailableQty.Text, out val2);
            if (val2 < val1)
            {
                MessageBox.Show("Entered quantity can not be more than available quantity", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtQty.Text = "";
                txtQty.Focus();
                return;

            }
        }

        private void DataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            btnRemove.Enabled = true;
        }

    }
}