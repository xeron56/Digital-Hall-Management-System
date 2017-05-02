using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Excel = Microsoft.Office.Interop.Excel;
namespace Hall_management_System_sdp
{
    public partial class Logs : Form
    {

        ConnectionString cs = new ConnectionString();
        CommonClasses cc = new CommonClasses();
        clsFunc cf = new clsFunc();
        string st1;
        string st2;
        public Logs()
        {
            InitializeComponent();
        }

        public void fillCombo()
        {
            try
            {
                cc.con = new SqlConnection(cs.DBConn);
                cc.con.Open();
                cc.da = new SqlDataAdapter();
                cc.da.SelectCommand = new SqlCommand("SELECT distinct RTRIM(UserID) FROM Registration", cc.con);
                cc.ds = new DataSet("ds");
                cc.da.Fill(cc.ds);
                cc.dtable = cc.ds.Tables[0];
                cmbUserID.Items.Clear();
                foreach (DataRow drow in cc.dtable.Rows)
                {
                    cmbUserID.Items.Add(drow[0].ToString());
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
      public void Reset()
        {
        cmbUserID.SelectedIndex = -1;
        dtpDateFrom.Text = System.DateTime.Today.ToString();
        dtpDateTo.Text = System.DateTime.Now.ToString();
        lblUser.Text = "";
        GetData();
        fillCombo();
        }


      private void btnGetData_Click(object sender, EventArgs e)
      {

          try
          {
              cc.con = new SqlConnection(cs.DBConn);
              cc.con.Open();
              cc.cmd = new SqlCommand("SELECT RTRIM(UserID),RTRIM(Date),RTRIM(Operation) from logs where Date between @date1 and @date2 order by Date", cc.con);
              cc.cmd.Parameters.Add("@date1", SqlDbType.DateTime, 30, "Date").Value = dtpDateFrom.Value.Date;
              cc.cmd.Parameters.Add("@date2", SqlDbType.DateTime, 30, "Date").Value = dtpDateTo.Value;
              cc.rdr = cc.cmd.ExecuteReader(CommandBehavior.CloseConnection);
              dgw.Rows.Clear();
              while ((cc.rdr.Read() == true))
              {
                  dgw.Rows.Add(cc.rdr[0], cc.rdr[1], cc.rdr[2]);
              }
              cc.con.Close();
          }
          catch (Exception ex)
          {
              MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
          }
      }

      private void btnExportExcel_Click(object sender, EventArgs e)
      {
          int rowsTotal = 0;
          int colsTotal = 0;
          int I = 0;
          int j = 0;
          int iC = 0;
          System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;
          Excel.Application xlApp = new Excel.Application();

          try
          {
              Excel.Workbook excelBook = xlApp.Workbooks.Add();
              Excel.Worksheet excelWorksheet = (Excel.Worksheet)excelBook.Worksheets[1];
              xlApp.Visible = true;

              rowsTotal = dgw.RowCount - 1;
              colsTotal = dgw.Columns.Count - 1;
              var _with1 = excelWorksheet;
              _with1.Cells.Select();
              _with1.Cells.Delete();
              for (iC = 0; iC <= colsTotal; iC++)
              {
                  _with1.Cells[1, iC + 1].Value = dgw.Columns[iC].HeaderText;
              }
              for (I = 0; I <= rowsTotal - 1; I++)
              {
                  for (j = 0; j <= colsTotal; j++)
                  {
                      _with1.Cells[I + 2, j + 1].value = dgw.Rows[I].Cells[j].Value;
                  }
              }
              _with1.Rows["1:1"].Font.FontStyle = "Bold";
              _with1.Rows["1:1"].Font.Size = 12;

              _with1.Cells.Columns.AutoFit();
              _with1.Cells.Select();
              _with1.Cells.EntireColumn.AutoFit();
              _with1.Cells[1, 1].Select();
          }
          catch (Exception ex)
          {
              MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
          }
          finally
          {
              //RELEASE ALLOACTED RESOURCES
              System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default;
              xlApp = null;
          }
      }

      private void GetData()
      {
          try
          {
              cc.con = new SqlConnection(cs.DBConn);
              cc.con.Open();
              cc.cmd = new SqlCommand("SELECT RTRIM(UserID),RTRIM(Date),RTRIM(Operation) from Logs order by Date", cc.con);
              cc.rdr = cc.cmd.ExecuteReader(CommandBehavior.CloseConnection);
              dgw.Rows.Clear();
              while ((cc.rdr.Read() == true))
              {
                  dgw.Rows.Add(cc.rdr[0], cc.rdr[1], cc.rdr[2]);
              }
              cc.con.Close();
          }
          catch (Exception ex)
          {
              MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
          }
      }

      public void DeleteRecord()
      {
          try
          {
              int RowsAffected = 0;
              cc.con = new SqlConnection(cs.DBConn);
              cc.con.Open();
              string ct = "delete from logs";
              cc.cmd = new SqlCommand(ct);
              cc.cmd.Connection = cc.con;
              RowsAffected = cc.cmd.ExecuteNonQuery();
              if (cc.con.State == ConnectionState.Open)
              {
                  cc.con.Close();
              }
              if (RowsAffected > 0)
              {
                  st1 = lblUser.Text;
                  st2 = "deleted the all logs till date '" + System.DateTime.Now + "'";
                  cf.LogFunc(st1, System.DateTime.Now, st2);
                  MessageBox.Show("Successfully deleted", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                  Reset();
                  GetData();
              }
              else
              {
                  MessageBox.Show("No record found", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Information);
                  Reset();
              }
              cc.con.Close();
          }
          catch (Exception ex)
          {
              MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
          }
      }
      private void cmbUserID_SelectedIndexChanged(object sender, EventArgs e)
      {

          try
          {
              cc.con = new SqlConnection(cs.DBConn);
              cc.con.Open();
              cc.cmd = new SqlCommand("SELECT RTRIM(UserID),RTRIM(Date),RTRIM(Operation) from Logs where UserID='" + cmbUserID.Text + "' order by date", cc.con);
              cc.rdr = cc.cmd.ExecuteReader(CommandBehavior.CloseConnection);
              dgw.Rows.Clear();
              while (cc.rdr.Read() == true)
              {
                  dgw.Rows.Add(cc.rdr[0], cc.rdr[1], cc.rdr[2]);
              }
              cc.con.Close();
          }
          catch (Exception ex)
          {
              MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
          }
      }

      private void frmLogs_Load(object sender, EventArgs e)
      {
          fillCombo();
          GetData();
      }

      private void btnReset_Click(object sender, EventArgs e)
      {
          Reset();
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

      private void btnDeleteAllLogs_Click(object sender, EventArgs e)
      {

          try
          {
              if (MessageBox.Show("Do you really want to delete all logs?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) ==System. Windows.Forms.DialogResult.Yes)
              {
                  DeleteRecord();
              }
          }
          catch (Exception ex)
          {
              MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
          }
      }

      private void btnClose_Click(object sender, EventArgs e)
      {
          this.Close();
      }

  
     
    
     
    }
}