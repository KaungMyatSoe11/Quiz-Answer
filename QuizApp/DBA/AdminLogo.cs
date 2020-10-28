using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace QuizApp.DBA
{
    class AdminLogo
    {
        public int AdminID { get; set; }
        public int Action { get; set; }

        clsMainDB obj_clsMainDB = new clsMainDB();
        string SPString;
        DataTable DT = new DataTable();

        public byte[] showprofile()
        {
            try
            {

                SPString = string.Format("SP_Select_Admin N'{0}',N'{1}',N'{2}'", AdminID, "0", "2");
                DT = obj_clsMainDB.SelectData(SPString);



                byte[] md = new byte[0];
                return md = (byte[])DT.Rows[0]["Logo"];


            }
            catch
            {
                byte[] md = new byte[0];
                return md = (byte[])null;
            }





        }
    }
}
