using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace QuizApp.DBA
{
    class clsClassDetail
    {
        public int STID { get; set; }
        public int CID { get; set; }
        public string STDATE { get; set; }
        public int ACTION { get; set; }

        clsMainDB obj_clsMainDB = new clsMainDB();

        public void SaveData()
        {
            try
            {
                obj_clsMainDB.DataBaseConn();
                SqlCommand sql = new SqlCommand("SP_Insert_ClassDetail", obj_clsMainDB.con);
                sql.Parameters.AddWithValue("@StudentID", STID);
                sql.Parameters.AddWithValue("@ClassID", CID);
                sql.Parameters.AddWithValue("@StartDate", STDATE);
                sql.Parameters.AddWithValue("@action", ACTION);

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
    }
}
