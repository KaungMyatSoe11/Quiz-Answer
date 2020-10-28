using System;
using System.Data;
using System.Windows.Forms;
using QuizApp.DBA;
using System.Data.SqlClient;

namespace QuizApp.Student
{
    public partial class frm_CurrentResult : Form
    {
     //   SqlConnection con = new SqlConnection(@"Data Source=WINDOWS-C6RB5G6;Initial Catalog=QuizApplication;User ID=sa;Password=kms1998");
        string SPString;
        public int _courseId = 0;
        public int correct = 0;
        public int mark = 0;
       public int totalquestion = 0;
        public int wrong = 0;
        DataTable DT = new DataTable();
        clsCourseDetail obj_clsCourseDeatil = new clsCourseDetail();
        clsMainDB obj_clsMainDB = new clsMainDB();
        
        public frm_CurrentResult()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            lblCorrect.Text = correct.ToString() ;
            lblWrong.Text = wrong.ToString();
            lbltotalmark.Text = totalquestion.ToString();

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            //Error all zero
            //obj_clsCourseDeatil.CourseID = _courseId;
            //obj_clsCourseDeatil.StudentID = Program.StudentID;
            //obj_clsCourseDeatil.Date = DateTime.Now.ToLongDateString();
            //obj_clsCourseDeatil.Point = 10;
            //obj_clsCourseDeatil.Action = 1;
            //obj_clsCourseDeatil.SaveData();
            SPString = string.Format("SP_Select_CourseDetail N'{0}',N'{1}',N'{2}'", _courseId, Program.StudentID, "2");
            DT = obj_clsMainDB.SelectData(SPString);
            if (DT.Rows.Count <= 0)
            {
                SqlCommand cmd = new SqlCommand(@"insert into CourseDetail (CourseID,StudentID,Date,Point) values ('" + _courseId + "','" + Program.StudentID + "','" + DateTime.Now.ToLongDateString() + "','"+lblCorrect.Text+"' )", obj_clsMainDB.con);
                obj_clsMainDB.con.Open();
                cmd.ExecuteNonQuery();
                obj_clsMainDB.con.Close();
              
            }
            else
            {
                SqlCommand cmdupdate = new SqlCommand(@"update CourseDetail set Point =  '"+lblCorrect.Text+"', Date ='" + DateTime.Now.ToLongDateString() + "'  where StudentID ='" + Program.StudentID + "' and  CourseID ='" + _courseId + "'", obj_clsMainDB.con);
                obj_clsMainDB.con.Open();
                cmdupdate.ExecuteNonQuery();
                obj_clsMainDB.con.Close();
               
            }
            this.Visible = false;

            
        }
    }
}
