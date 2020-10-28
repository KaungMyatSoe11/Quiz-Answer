using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace QuizApp.DBA
{
    class clsMainDB
    {
        public SqlConnection con;
        DataSet DS = new DataSet();

        public void DataBaseConn()
        {
            try
            {
                con = new SqlConnection(QuizApp.Properties.Settings.Default.Quiz);
                if (con.State == ConnectionState.Open)
                    con.Close();
                con.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error In DataBaseConn");
            }
        }
        public DataTable SelectData (string SPString)
        {
            DataTable DT = new DataTable();
            try
            {
                DataBaseConn();
                SqlDataAdapter Adpt = new SqlDataAdapter(SPString, con);
                Adpt.Fill(DT);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error In SelectData");
            }
            finally
            {
                con.Close();
            }
            return DT;

        }
        public void AddCombo(ref ComboBox cboCombo, string SPString, string Display, string Value)
        {
            DataTable DT = new DataTable();
            DataTable DTCombo = new DataTable();
            DataRow Dr;

            DTCombo.Columns.Add(Display);
            DTCombo.Columns.Add(Value);

            Dr = DTCombo.NewRow();
            Dr[Display] = "----Select----";
            Dr[Value] = 0;
            DTCombo.Rows.Add(Dr);

            try
            {
                DataBaseConn();
                SqlDataAdapter Adpt = new SqlDataAdapter(SPString, con);
                Adpt.Fill(DT);
                for (int i = 0; i < DT.Rows.Count; i++)
                {
                    Dr = DTCombo.NewRow();
                    Dr[Display] = DT.Rows[i][Display];
                    Dr[Value] = DT.Rows[i][Value];
                    DTCombo.Rows.Add(Dr);
                }
                cboCombo.DisplayMember = Display;
                cboCombo.ValueMember = Value;
                cboCombo.DataSource = DTCombo;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error In AddCombo");
            }
            finally
            {
                con.Close();
            }
        }
        public void TextBoxData(ref TextBox txtTextBox, string SPString, string FieldName)
        {
            DataTable DT = new DataTable();
            AutoCompleteStringCollection Source =new AutoCompleteStringCollection();

            txtTextBox.AutoCompleteMode=AutoCompleteMode.Suggest;
            txtTextBox.AutoCompleteSource=AutoCompleteSource.CustomSource;

            try
            {

                DataBaseConn();
                SqlDataAdapter Adpt = new SqlDataAdapter(SPString, con);
                Adpt.Fill(DT);
                if (DT.Rows.Count > 0)
                {
                    txtTextBox.AutoCompleteCustomSource.Clear();
                    for (int i = 0; i < DT.Rows.Count; i++)
                    {
                        Source.Add(DT.Rows[i][FieldName].ToString());
                    }
                    txtTextBox.AutoCompleteCustomSource = Source;
                    txtTextBox.Text = "";
                    txtTextBox.Focus();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error In TextBoxData");
            }
            finally
            {
                con.Close();
            }
        }
        public void ToolStripTextBoxData(ref ToolStripTextBox tstToolStrip, string SPString, string FieldName)
        {
            DataTable DT = new DataTable();
            AutoCompleteStringCollection Source=new AutoCompleteStringCollection();
            try
            {
                DataBaseConn();
                SqlDataAdapter Adpt = new SqlDataAdapter(SPString, con);
                Adpt.Fill(DT);
                if (DT.Rows.Count > 0)
                {
                    tstToolStrip.AutoCompleteCustomSource.Clear();
                    for (int i = 0; i < DT.Rows.Count; i++)
                    {
                        Source.Add(DT.Rows[i][FieldName].ToString());

                    }
                    tstToolStrip.AutoCompleteCustomSource = Source;
                    tstToolStrip.Text = "";
                    tstToolStrip.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error In ToolStripTextBoxData");
            }
            finally
            {
                con.Close();
            }
        }

        internal void ToolStripTextBoxData(ref TextBox txtSearch, string SPString, string p)
        {
            //throw new NotImplementedException();
        }

        internal object SelectData()
        {
           throw new NotImplementedException();
        }
    }
}
