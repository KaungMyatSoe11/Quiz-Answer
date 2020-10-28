using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuizApp.DBA;

namespace QuizApp.Student
{
    public partial class frmTest : Form
    {
        string stuanswer;
        
        clsProfile obj_clsProfile = new clsProfile();
        string SPString;
        clsMainDB obj_clsMainDB = new clsMainDB();
        int mark = 0;
        // for loop to count Question
        int countQuestion = 0;
       public int _CouseID = 0;
        DataTable DT = new DataTable();
        // two var for count correct/wrong
       public int correct = 0;
      public  int wrong = 0;
        public frmTest()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }
        public void answer()
        {
            if (rdo1.Checked)
            {
                stuanswer = rdo1.Text;
            }
            else if (rdo2.Checked)
            {
                stuanswer = rdo2.Text;
            }
            else if (rdo3.Checked)
            {
                stuanswer = rdo3.Text;
            }
            else if (rdo4.Checked)
            {
                stuanswer = rdo4.Text;
            }
            
        }
        public void showquestion()
        {
            SPString = string.Format("SP_Select_Quiz N'{0}',N'{1}',N'{2}'", _CouseID, "0", "2");
            DT = obj_clsMainDB.SelectData(SPString);
            ClearData();
            if (countQuestion != DT.Rows.Count)
            {

                lblQuestion.Text = DT.Rows[countQuestion]["Question"].ToString();
                rdo1.Text = DT.Rows[countQuestion]["Answer1"].ToString();
                rdo2.Text = DT.Rows[countQuestion]["Answer2"].ToString();
                rdo3.Text = DT.Rows[countQuestion]["Answer3"].ToString();
                rdo4.Text = DT.Rows[countQuestion]["Answer4"].ToString();
               
            }
            else
            {
                this.Visible = false;

                frm_CurrentResult frm = new frm_CurrentResult();
               //တန်ဖိုးchange
                frm.correct = correct;
                frm.wrong = wrong;
                frm.mark = mark;
                frm.totalquestion = DT.Rows.Count;
                frm._courseId = _CouseID;
                frm.ShowDialog();

                //UserControl pan2 = new Resultshow();
                // Panel pan = ((QuizApp.Student.Resultshow)(pan2)).panel1;
                // pan2.Show();
            }
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            answer();
            if (!rdo1.Checked && !rdo2.Checked && !rdo3.Checked && !rdo4.Checked)
            {
                MessageBox.Show("Choose Your Answer");
            }
            else
            {
                checkcorrectanswer();
                countQuestion++;
                showquestion();
            }
          
            

        }
        public void ClearData()
        {
            lblQuestion.Text = "";
            rdo1.Checked = false;
            rdo2.Checked = false;
            rdo3.Checked = false;
            rdo4.Checked = false;
          
            

        }

        public void checkcorrectanswer()
        {
            if (stuanswer != string.Empty)
            {
                if (rdo1.Checked || rdo2.Checked ||rdo3.Checked || rdo4.Checked)
                {
                    SPString = string.Format("SP_Select_Quiz N'{0}',N'{1}',N'{2}'", _CouseID, "0", "2");
                    DT = obj_clsMainDB.SelectData(SPString);
                    if (DT.Rows[countQuestion]["CorrectAns"].ToString() == stuanswer)
                    {
                        correct++;
                        mark++;
                    }
                    else
                    {
                        wrong++;
                        
                    }
                }
            }
        }
        private void frmTest_Load(object sender, EventArgs e)
        {
            showquestion();
            correct = 0;
            wrong = 0;
        }

        private void btnExist_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
