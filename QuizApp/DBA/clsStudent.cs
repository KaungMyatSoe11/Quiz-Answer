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
    class clsStudent
    {
        public int STUDENTID { get; set; }
        public string STUDENTNAME { get; set; }
        public string STUDENTPASSWORD { get; set; }
        public string NRC { get; set; }
        public string Address { get; set; }
        public string BDATE { get; set; }
        public string PHONE { get; set; }
        public string UPDATE { get; set; }
        public byte[] SIMAGE { get; set; }
        public string GENDER { get; set; }
        public string Hnit { get; set; }
        public string HnitAnswer { get; set; }
        public int ACTION { get; set; }


        clsMainDB obj_clsMainDB = new clsMainDB();

        public void SaveData()
        {
            try
            {
                obj_clsMainDB.DataBaseConn();
                SqlCommand sql = new SqlCommand("SP_Insert_Student", obj_clsMainDB.con);
                sql.CommandType = CommandType.StoredProcedure;
                sql.Parameters.AddWithValue("@StudentID", STUDENTID);
                sql.Parameters.AddWithValue("@StudentName", STUDENTNAME);
                sql.Parameters.AddWithValue("@Password", STUDENTPASSWORD);
                sql.Parameters.AddWithValue("@NRC", NRC);
                sql.Parameters.AddWithValue("@Phone", PHONE);
                sql.Parameters.AddWithValue("@Gender", GENDER);
                sql.Parameters.AddWithValue("@Address", Address);
                sql.Parameters.AddWithValue("@Birthdate", BDATE);
                sql.Parameters.AddWithValue("@UpdateDate", UPDATE);
                sql.Parameters.AddWithValue("@StudentImage", SIMAGE);
                sql.Parameters.AddWithValue("@hnit", Hnit);
                sql.Parameters.AddWithValue("@hnitanswer", HnitAnswer);
                sql.Parameters.AddWithValue("@action", ACTION);
                sql.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error In Save Data");
            }
            finally
            {
                obj_clsMainDB.con.Close();
            }
        }


    }
}
