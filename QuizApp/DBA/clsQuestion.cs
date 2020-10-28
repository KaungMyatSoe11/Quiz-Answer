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
    class clsQuestion
    {
        public int QUIZID { get; set; }
        public int COURSEID { get; set; }
        public string QUESTION { get; set; }
        public string ANSWER1 { get; set; }
        public string ANSWER2 { get; set; }
        public string ANSWER3 { get; set; }
        public string ANSWER4 { get; set; }
        public string CORRECTANS { get; set; }
        public int ACTION { get; set; }

        clsMainDB obj_clsMainDB = new clsMainDB();

        public void SaveData()
        {
            try
            {
                obj_clsMainDB.DataBaseConn();
                SqlCommand sql = new SqlCommand("SP_Insert_Quiz", obj_clsMainDB.con);
                sql.CommandType = CommandType.StoredProcedure;
                sql.Parameters.AddWithValue("@QuizID", QUIZID);
                sql.Parameters.AddWithValue("@CourseID", COURSEID);
                sql.Parameters.AddWithValue("@Question", QUESTION);
                sql.Parameters.AddWithValue("@Answer1", ANSWER1);
                sql.Parameters.AddWithValue("@Answer2", ANSWER2);
                sql.Parameters.AddWithValue("@Answer3", ANSWER3);
                sql.Parameters.AddWithValue("@Answer4", ANSWER4);
                sql.Parameters.AddWithValue("@CorrectAns", CORRECTANS);
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
