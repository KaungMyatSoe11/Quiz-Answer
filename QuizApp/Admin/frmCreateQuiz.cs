using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using QuizApp.DBA;
using System.IO;
using QuizApp.Student;


namespace QuizApp.Admin
{
    public partial class frmCreateQuiz : Form
    {
        string SPString;
        clsMainDB obj_clsMainDB = new clsMainDB();
        DataTable DT=new DataTable();
        clsQuestion obj_clsQuestion = new clsQuestion();
        public int _QuizID;
       bool _IsEdit;
        public frmCreateQuiz()
        {
            InitializeComponent();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            frmAdmin Admin = new frmAdmin();
            Admin.ShowDialog();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ClearData()
        {
          
            txtAnswer1.Text = "";
            txtAnswer3.Text = "";
            txtAnswer2.Text = "";
            txtAnswer4.Text = "";
            txtCorrectAnswer.Text = "";
           txtQuestion.Text = "";
          
        }
        public void CboCurse()
        {
            SPString = string.Format("SP_Select_Course N'{0}',N'{1}',N'{2}'", "0", "0", "0");
            obj_clsMainDB.AddCombo(ref cboCourse, SPString, "CourseName", "CourseID");
        }
        private void frmCreateQuiz_Load(object sender, EventArgs e)
        {
            CboCurse();  
            btnCreateQuiz.BackColor = Color.Fuchsia;
            AdminLogo();
            ClearData();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(cboCourse.SelectedValue.ToString()) == 0)
            {
                MessageBox.Show("Please Choose Your Course");
                cboCourse.Focus();
            }
            else if (txtAnswer1.Text == txtAnswer2.Text || txtAnswer1.Text == txtAnswer3.Text || txtAnswer1.Text == txtAnswer4.Text)
            {
                MessageBox.Show(" Your answers should be different");
                txtAnswer1.Focus();
            }
            else if (txtAnswer2.Text == txtAnswer1.Text || txtAnswer2.Text == txtAnswer3.Text || txtAnswer2.Text == txtAnswer4.Text)
            {
                MessageBox.Show("Your answers Should Be different");
                txtAnswer2.Focus();
            }
            else if (txtAnswer3.Text == txtAnswer1.Text || txtAnswer3.Text == txtAnswer2.Text || txtAnswer3.Text == txtAnswer4.Text)
            {
                MessageBox.Show(" Your answers should be different");
                txtAnswer3.Focus();
            }
            else if (txtAnswer4.Text == txtAnswer2.Text || txtAnswer4.Text == txtAnswer3.Text || txtAnswer4.Text == txtAnswer1.Text)
            {
                MessageBox.Show(" Your answers should be different");
                txtAnswer4.Focus();
            }
            else if (txtCorrectAnswer.Text != txtAnswer1.Text && txtCorrectAnswer.Text != txtAnswer2.Text && txtCorrectAnswer.Text != txtAnswer3.Text && txtCorrectAnswer.Text != txtAnswer4.Text)
            {
                MessageBox.Show(" Correct Should be same at least one");
                txtCorrectAnswer.Focus();
                txtCorrectAnswer.SelectAll();
            }
            else if (txtQuestion.Text == string.Empty)
            {
                MessageBox.Show("Please Type Your Question");
                txtQuestion.Focus();

            }
            else if (txtAnswer1.Text == string.Empty)
            {
                MessageBox.Show("Please Type Your Answer1");
                txtAnswer1.Focus();

            }
            else if (txtAnswer2.Text == string.Empty)
            {
                MessageBox.Show("Please Type Your Answer2");
                txtAnswer3.Focus();

            }
            else if (txtAnswer3.Text == string.Empty)
            {
                MessageBox.Show("Please Type Your Answer3");
                txtAnswer3.Focus();

            }
            else if (txtAnswer4.Text == string.Empty)
            {
                MessageBox.Show("Please Type Your Answer4");
                txtAnswer4.Focus();

            }
            else if (txtCorrectAnswer.Text == string.Empty)
            {
                MessageBox.Show("Please Type Your CorrectAnswer");
                txtCorrectAnswer.Focus();

            }
            else
            {
                SPString = string.Format("SP_Select_Quiz N'{0}',N'{1}',N'{2}'", txtQuestion.Text.Trim().ToString(), "0", "0");
                DT = obj_clsMainDB.SelectData(SPString);
                if ((DT.Rows.Count > 0) && (DT.Rows[0]["QuizID"].ToString() != _QuizID.ToString()))
                {
                    MessageBox.Show("This Question is Alread Exist");
                    txtQuestion.Focus();
                    txtQuestion.SelectAll();
                }
                else
                {
                    obj_clsQuestion.QUIZID = Convert.ToInt32(_QuizID);
                    obj_clsQuestion.COURSEID = Convert.ToInt32(cboCourse.SelectedValue.ToString());
                    obj_clsQuestion.QUESTION = txtQuestion.Text;
                    obj_clsQuestion.ANSWER1 = txtAnswer1.Text;
                    obj_clsQuestion.ANSWER2 = txtAnswer2.Text;
                    obj_clsQuestion.ANSWER3 = txtAnswer3.Text;
                    obj_clsQuestion.ANSWER4 = txtAnswer4.Text;
                    obj_clsQuestion.CORRECTANS = txtCorrectAnswer.Text;

                    obj_clsQuestion.ACTION = 0;
                    obj_clsQuestion.SaveData();
                    MessageBox.Show("Successfully Save", "Successfully", MessageBoxButtons.OK);
                    ClearData();
                    txtQuestion.Focus();

                }
            }
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(cboCourse.SelectedValue.ToString()) == 0)
            {
                MessageBox.Show("Please Choose Your Course");
                cboCourse.Focus();
            }
            else if (txtAnswer1.Text == txtAnswer2.Text || txtAnswer1.Text == txtAnswer3.Text || txtAnswer1.Text == txtAnswer4.Text)
            {
                MessageBox.Show(" Your answers should be different");
                txtAnswer1.Focus();
            }
            else if (txtAnswer2.Text == txtAnswer1.Text || txtAnswer2.Text == txtAnswer3.Text || txtAnswer2.Text == txtAnswer4.Text)
            {
                MessageBox.Show("Your answers Should Be different");
                txtAnswer2.Focus();
            }
            else if (txtAnswer3.Text == txtAnswer1.Text || txtAnswer3.Text == txtAnswer2.Text || txtAnswer3.Text == txtAnswer4.Text)
            {
                MessageBox.Show(" Your answers should be different");
                txtAnswer3.Focus();
            }
            else if (txtAnswer4.Text == txtAnswer2.Text || txtAnswer4.Text == txtAnswer3.Text || txtAnswer4.Text == txtAnswer1.Text)
            {
                MessageBox.Show(" Your answers should be different");
                txtAnswer4.Focus();
            }
            else if (txtCorrectAnswer.Text != txtAnswer1.Text && txtCorrectAnswer.Text != txtAnswer2.Text && txtCorrectAnswer.Text != txtAnswer3.Text && txtCorrectAnswer.Text != txtAnswer4.Text)
            {
                MessageBox.Show(" Correct Should be same at least one");
                txtCorrectAnswer.Focus();
                txtCorrectAnswer.SelectAll();
            }
            else if (txtQuestion.Text == string.Empty)
            {
                MessageBox.Show("Please Type Your Question");
                txtQuestion.Focus();

            }
            else if (txtAnswer1.Text == string.Empty)
            {
                MessageBox.Show("Please Type Your Answer1");
                txtAnswer1.Focus();

            }
            else if (txtAnswer2.Text == string.Empty)
            {
                MessageBox.Show("Please Type Your Answer2");
                txtAnswer3.Focus();

            }
            else if (txtAnswer3.Text == string.Empty)
            {
                MessageBox.Show("Please Type Your Answer3");
                txtAnswer3.Focus();

            }
            else if (txtAnswer4.Text == string.Empty)
            {
                MessageBox.Show("Please Type Your Answer4");
                txtAnswer4.Focus();

            }
            else if (txtCorrectAnswer.Text == string.Empty)
            {
                MessageBox.Show("Please Type Your CorrectAnswer");
                txtCorrectAnswer.Focus();

            }
            else
            {
                SPString = string.Format("SP_Select_Quiz N'{0}',N'{1}',N'{2}'", txtQuestion.Text.Trim().ToString(), "0", "0");
                DT = obj_clsMainDB.SelectData(SPString);
                if ((DT.Rows.Count > 0) && (DT.Rows[0]["QuizID"].ToString() != _QuizID.ToString()))
                {
                    MessageBox.Show("This Question is Alread Exist");
                    txtQuestion.Focus();
                    txtQuestion.SelectAll();
                }
                else
                {
                    obj_clsQuestion.QUIZID = Convert.ToInt32(_QuizID);
                    obj_clsQuestion.COURSEID = Convert.ToInt32(cboCourse.SelectedValue.ToString());
                    obj_clsQuestion.QUESTION = txtQuestion.Text;
                    obj_clsQuestion.ANSWER1 = txtAnswer1.Text;
                    obj_clsQuestion.ANSWER2 = txtAnswer2.Text;
                    obj_clsQuestion.ANSWER3 = txtAnswer3.Text;
                    obj_clsQuestion.ANSWER4 = txtAnswer4.Text;
                    obj_clsQuestion.CORRECTANS = txtCorrectAnswer.Text;

                    obj_clsQuestion.ACTION = 0;
                    obj_clsQuestion.SaveData();
                    MessageBox.Show("Successfully Save", "Successfully", MessageBoxButtons.OK);
                    ClearData();
                    txtQuestion.Focus();
                    cboCourse.SelectedIndex = 0;
                }
            }
        }
        public void AdminLogo()
        {
            AdminLogo logo = new AdminLogo();
            int AdminID = Program.AdminID;
            logo.AdminID = AdminID;
            byte[] image = new byte[0];
            image = (byte[])logo.showprofile();
            if (image != null)
            {

                MemoryStream stream = new MemoryStream(image);

                picLogo.Image = Image.FromStream(stream);
            }
        }

        private void btnViewandUpdate_Click(object sender, EventArgs e)
        {
 
        }

        private void txtAnswer2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCorrectAnswer_KeyPress(object sender, KeyPressEventArgs e)
        {
         
             if (e.KeyChar.Equals('\r'))
             {
                 if (Convert.ToInt32(cboCourse.SelectedValue.ToString()) == 0)
                 {
                     MessageBox.Show("Please Choose Your Course");
                     cboCourse.Focus();
                 }
                     
             if (txtCorrectAnswer.Text == string.Empty)
            {
                MessageBox.Show("Please Type Your CorrectAnswer");
                txtCorrectAnswer.Focus();

            }
                 else if (txtAnswer1.Text == txtAnswer2.Text || txtAnswer1.Text == txtAnswer3.Text || txtAnswer1.Text == txtAnswer4.Text)
                 {
                     MessageBox.Show(" Your answers should be different");
                     txtAnswer1.Focus();
                 }
                 else if (txtAnswer2.Text == txtAnswer1.Text || txtAnswer2.Text == txtAnswer3.Text || txtAnswer2.Text == txtAnswer4.Text)
                 {
                     MessageBox.Show("Your answers Should Be different");
                     txtAnswer2.Focus();
                 }
                 else if (txtAnswer3.Text == txtAnswer1.Text || txtAnswer3.Text == txtAnswer2.Text || txtAnswer3.Text == txtAnswer4.Text)
                 {
                     MessageBox.Show(" Your answers should be different");
                     txtAnswer3.Focus();
                 }
                 else if (txtAnswer4.Text == txtAnswer2.Text || txtAnswer4.Text == txtAnswer3.Text || txtAnswer4.Text == txtAnswer1.Text)
                 {
                     MessageBox.Show(" Your answers should be different");
                     txtAnswer4.Focus();
                 }
                 else if (txtCorrectAnswer.Text != txtAnswer1.Text && txtCorrectAnswer.Text != txtAnswer2.Text && txtCorrectAnswer.Text != txtAnswer3.Text && txtCorrectAnswer.Text != txtAnswer4.Text)
                 {
                     MessageBox.Show(" Correct Should be same at least one");
                     txtCorrectAnswer.Focus();
                     txtCorrectAnswer.SelectAll();
                 }
                 else if (txtQuestion.Text == string.Empty)
                 {
                     MessageBox.Show("Please Type Your Question");
                     txtQuestion.Focus();

                 }
                 else if (txtAnswer1.Text == string.Empty)
                 {
                     MessageBox.Show("Please Type Your Answer1");
                     txtAnswer1.Focus();

                 }
                 else if (txtAnswer2.Text == string.Empty)
                 {
                     MessageBox.Show("Please Type Your Answer2");
                     txtAnswer3.Focus();

                 }
                 else if (txtAnswer3.Text == string.Empty)
                 {
                     MessageBox.Show("Please Type Your Answer3");
                     txtAnswer3.Focus();

                 }
                 else if (txtAnswer4.Text == string.Empty)
                 {
                     MessageBox.Show("Please Type Your Answer4");
                     txtAnswer4.Focus();

                 }

                 else
                 {
                     SPString = string.Format("SP_Select_Quiz N'{0}',N'{1}',N'{2}'", txtQuestion.Text.Trim().ToString(), "0", "0");
                     DT = obj_clsMainDB.SelectData(SPString);
                     if ((DT.Rows.Count > 0) && (DT.Rows[0]["QuizID"].ToString() != _QuizID.ToString()))
                     {
                         MessageBox.Show("This Question is Alread Exist");
                         txtQuestion.Focus();
                         txtQuestion.SelectAll();
                     }
                     else
                     {
                         obj_clsQuestion.QUIZID = Convert.ToInt32(_QuizID);
                         obj_clsQuestion.COURSEID = Convert.ToInt32(cboCourse.SelectedValue.ToString());
                         obj_clsQuestion.QUESTION = txtQuestion.Text;
                         obj_clsQuestion.ANSWER1 = txtAnswer1.Text;
                         obj_clsQuestion.ANSWER2 = txtAnswer2.Text;
                         obj_clsQuestion.ANSWER3 = txtAnswer3.Text;
                         obj_clsQuestion.ANSWER4 = txtAnswer4.Text;
                         obj_clsQuestion.CORRECTANS = txtCorrectAnswer.Text;

                         obj_clsQuestion.ACTION = 0;
                         obj_clsQuestion.SaveData();
                         MessageBox.Show("Successfully Save", "Successfully", MessageBoxButtons.OK);
                         ClearData();
                         txtQuestion.Focus();

                     
                 }
                 }
             }
        }

        private void btnAddStudent_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            new frmAdmin().ShowDialog();

        }

        private void btnViewandUpdate_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            new frmViewandUpdate().ShowDialog();

        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new frmSetting().ShowDialog();
        }

        private void btnCreateQuiz_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new frmCreateQuiz().ShowDialog();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            frmCreateCourse frm = new frmCreateCourse();
            frm.ShowDialog();
            CboCurse();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Logout", "Confirm Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Visible = false;
                frmLogin frm = new frmLogin();
                frm.ShowDialog();

            }
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new frmResult().ShowDialog();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            About frm = new About();
            frm.ShowDialog();
        }
    }
}
