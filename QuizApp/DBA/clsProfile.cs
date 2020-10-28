using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using QuizApp.Student;
using System.IO;

namespace QuizApp.DBA
{
    class clsProfile
    {
       // SqlConnection con = new SqlConnection(@"Data Source=WINDOWS-C6RB5G6;Initial Catalog=QuizApplication;User ID=sa;Password=kms1998");
        public int StudentID { get; set; }
        public int Action { get; set; }

        clsMainDB obj_clsMainDB = new clsMainDB();
        string SPString;
        DataTable DT = new DataTable();

        public byte[] showprofile()
        {
            
            
                SPString = string.Format("SP_Select_Student N'{0}',N'{1}',N'{2}'", StudentID, "0", "7");
                DT = obj_clsMainDB.SelectData(SPString);

                byte[] md = new byte[0];
               return md = (byte[])DT.Rows[0]["StudentImage"];

            
           





          //  SqlCommand cmd = new SqlCommand(@"Select StudentImage from Student Where StudentID=" + StudentID+ "", obj_clsMainDB.con);

          //  SqlDataAdapter sda = new SqlDataAdapter();
          //  DataTable DT = new DataTable();
          //  sda.SelectCommand = cmd;
          //  DataSet ds = new DataSet();
          //  byte[] md = new byte[0];
          //  sda.Fill(ds, "StudentImage");
          //  DataRow dr;
          //  dr = ds.Tables["StudentImage"].Rows[0];
          //return  md = (byte[])dr["StudentImage"];
            //MemoryStream stream = new MemoryStream(md);

            //Image = Image.FromStream(stream);
        }

    }
}
