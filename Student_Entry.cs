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
    public partial class Student_Entry : Form
    {
        ConnectionString cs = new ConnectionString();
        CommonClasses cc = new CommonClasses();
        clsFunc cf = new clsFunc();
        string st1;
        string st2;
        public Student_Entry()
        {
            InitializeComponent();
        }

      public void Reset()
        {
        txtEmailID.Text = "";
        txtCustomerName.Text = "";
        txtContactNo.Text = "";
        txtCity.Text = "";
        txtAddress.Text = "";
        txtCustomerID.Text = "";
        txtID.Text = "";
        txtCustomerName.Focus();
        btnSave.Enabled = true;
        btnUpdate.Enabled = false;
        btnDelete.Enabled = false;
        Picture.Image = Properties.Resources.photo;
        auto();
        }
     
  
        private void delete_records()
        {

           
                int RowsAffected = 0;
                cc.con = new SqlConnection(cs.DBConn);
                cc.con.Open();
                string ct = "delete from Student where C_ID=@d1";
                cc.cmd = new SqlCommand(ct);
                cc.cmd.Connection = cc.con;
                cc.cmd.Parameters.AddWithValue("@d1", txtID.Text);
                RowsAffected = cc.cmd.ExecuteNonQuery();
                if (RowsAffected > 0)
                {
                    st1 = lblUser.Text;
                    st2 = "deleted the Student'" + txtCustomerName.Text + "' having Student id '" + txtCustomerID.Text + "'";
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
             
            
           /* catch (Exception ex)
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
                string sql = "SELECT MAX(C_ID+1) FROM Student";
                cc.cmd = new SqlCommand(sql);
                cc.cmd.Connection = cc.con;
                if (Convert.IsDBNull(cc.cmd.ExecuteScalar()))
                {
                    Num = 1;
                    txtID.Text = Convert.ToString(Num);
                    txtCustomerID.Text = "C-" + Convert.ToString(Num);
                }
                else
                {
                    Num = (int)(cc.cmd.ExecuteScalar());
                    txtID.Text = Convert.ToString(Num);
                    txtCustomerID.Text = "C-" + Convert.ToString(Num);
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
           
           
            if (txtCustomerName.Text == "")
                {
                    MessageBox.Show("Please enter Patient name", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtCustomerName.Focus();
            return;
            }
            if (txtAddress.Text == "" )
            {
                MessageBox.Show("Please enter address", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtAddress.Focus();
            return;
            }
            if (txtCity.Text == "")
            {
            MessageBox.Show("Please enter city", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtCity.Focus();
            return;
            }
            if (txtContactNo.Text == "")
            {
            MessageBox.Show("Please enter contact no.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtContactNo.Focus();
            return;
            }
               

                cc.con = new SqlConnection(cs.DBConn);
                cc.con.Open();
                string cb = "insert into Student(C_ID,StudentID,Name,Address,City,ContactNo,Email,Photo) VALUES (@d1,@d2,@d3,@d4,@d5,@d6,@d7,@d8)";
                cc.cmd = new SqlCommand(cb);
                cc.cmd.Connection = cc.con;
                cc.cmd.Parameters.AddWithValue("@d1", txtID.Text);
                cc.cmd.Parameters.AddWithValue("@d2", txtCustomerID.Text);
                cc.cmd.Parameters.AddWithValue("@d3",txtCustomerName.Text);
                cc.cmd.Parameters.AddWithValue("@d4", txtAddress.Text);
                cc.cmd.Parameters.AddWithValue("@d5", txtCity.Text);
                cc.cmd.Parameters.AddWithValue("@d6", txtContactNo.Text);
                cc.cmd.Parameters.AddWithValue("@d7",txtEmailID.Text);
                MemoryStream ms = new MemoryStream();
                Bitmap bmpImage = new Bitmap(Picture.Image);
                bmpImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] data = ms.GetBuffer();
                SqlParameter p = new SqlParameter("@d8", SqlDbType.Image);
                p.Value = data;
                cc.cmd.Parameters.Add(p);
                cc.cmd.ExecuteReader();
                cc.con.Close();
                st1 = lblUser.Text;
                st2 = "added the new Student'" + txtCustomerName.Text + "' having Student id '" + txtCustomerID.Text + "'";
                cf.LogFunc(st1, System.DateTime.Now, st2);
                btnSave.Enabled = false;
                MessageBox.Show("Successfully saved", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
          /*  catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }
    
      
      

        private void btnUpdate_Click(object sender, EventArgs e)
        {
             
                  if (txtCustomerID.Text == "")
                  {
                      MessageBox.Show("Please enter user id", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                      txtCustomerID.Focus();
                      return;
                  }

                  if (txtAddress.Text == "")
                  {
                      MessageBox.Show("Please enter password", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                      txtAddress.Focus();
                      return;
                  }
                  if (txtCity.Text == "")
                  {
                      MessageBox.Show("Please enter name", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                      txtCity.Focus();
                      return;
                  }
                  if (txtEmailID.Text == "")
                  {
                      MessageBox.Show("Please enter contact no.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                      txtEmailID.Focus();
                      return;
                  }
                  cc.con = new SqlConnection(cs.DBConn);
                  cc.con.Open();
                  string cb = "Update Student set StudentID=@d2,Name=@d3,Address=@d4,City=@d5,ContactNo=@d6,Email=@d7,Photo=@d8 where C_ID=@d1";
                  cc.cmd = new SqlCommand(cb);
                  cc.cmd.Connection = cc.con;
                  cc.cmd.Parameters.AddWithValue("@d1", txtID.Text);
                  cc.cmd.Parameters.AddWithValue("@d2", txtCustomerID.Text);
                  cc.cmd.Parameters.AddWithValue("@d3", txtCustomerName.Text);
                  cc.cmd.Parameters.AddWithValue("@d4", txtAddress.Text);
                  cc.cmd.Parameters.AddWithValue("@d5", txtCity.Text);
                  cc.cmd.Parameters.AddWithValue("@d6", txtContactNo.Text);
                  cc.cmd.Parameters.AddWithValue("@d7", txtEmailID.Text);
                  MemoryStream ms = new MemoryStream();
                  Bitmap bmpImage = new Bitmap(Picture.Image);
                  bmpImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                  byte[] data = ms.GetBuffer();
                  SqlParameter p = new SqlParameter("@d8", SqlDbType.Image);
                  p.Value = data;
                  cc.cmd.Parameters.Add(p);
                  cc.cmd.ExecuteReader();
                  cc.con.Close();
                  st1 = lblUser.Text;
                  st2 = "updated the Student'" + txtCustomerName.Text + "' having Student id '" + txtCustomerID.Text + "'";
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

        private void Browse_Click(object sender, EventArgs e)
        {
            
                var _with1 = openFileDialog1;

                _with1.Filter = ("Image Files |*.png; *.bmp; *.jpg;*.jpeg; *.gif;");
                _with1.FilterIndex = 4;
                //Reset the file name
                openFileDialog1.FileName = "";

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    Picture.Image = Image.FromFile(openFileDialog1.FileName);
                }

            /*
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }

        private void txtEmailID_Validating(object sender, CancelEventArgs e)
        {
            System.Text.RegularExpressions.Regex rEMail = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
            if (txtEmailID.Text.Length > 0)
            {
                if (!rEMail.IsMatch(txtEmailID.Text))
                {
                    MessageBox.Show("invalid email address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEmailID.SelectAll();
                    e.Cancel = true;
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                delete_records();
            }
        }

        private void BRemove_Click(object sender, EventArgs e)
        {
            Picture.Image = Properties.Resources.photo;
        }

        private void btnGetData_Click(object sender, EventArgs e)
        {
            this.Hide();
           // frmPatientRecord frm = new frmPatientRecord();
            Student_Entry_Record frm = new Student_Entry_Record();
            frm.Reset();
            frm.lblOperation.Text = "Student Master";
            frm.lblUser.Text = lblUser.Text;
            frm.Show();
        }

    }
}