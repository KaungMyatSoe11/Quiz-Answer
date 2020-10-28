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
    class clsCourseDetail
    {
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public string Date { get; set; }
        public int Point { get; set; }
        public int Action { get; set; }

        clsMainDB obj_clsMainDB = new clsMainDB();
        public void SaveData()
        {
            try
            {
                obj_clsMainDB.DataBaseConn();
                SqlCommand sql = new SqlCommand("SP_Insert_CourseDetail", obj_clsMainDB.con);
                
                sql.Parameters.AddWithValue("@StudentID", StudentID);
                sql.Parameters.AddWithValue("@CourseID", CourseID);
                sql.Parameters.AddWithValue("@Date", Date);
                sql.Parameters.AddWithValue("@Point", Point);
                sql.Parameters.AddWithValue("@action", Action);
                sql.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error in Save Data");
            }
            finally
            {
                obj_clsMainDB.con.Close();
            }
        }
        public void AddCombo(ref ComboBox cboCombo, string SPString, string Display, string Value)
        {
            DataTable DT = new DataTable();
            DataTable DTCombo = new DataTable();
            DataRow Dr;

            DTCombo.Columns.Add(Display);
            DTCombo.Columns.Add(Value);

            Dr = DTCombo.NewRow();
            Dr[Display] = "My Record";
            Dr[Value] = 0;
            DTCombo.Rows.Add(Dr);

            try
            {
                obj_clsMainDB.DataBaseConn();
                SqlDataAdapter Adpt = new SqlDataAdapter(SPString, obj_clsMainDB.con);
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
                obj_clsMainDB.con.Close();
            }
        }
    }
}
