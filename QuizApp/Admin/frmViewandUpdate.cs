using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using QuizApp.DBA;
using System.IO;
using QuizApp.Student;

namespace QuizApp.Admin
{
    public partial class frmViewandUpdate : Form
    {

        clsQuestion obj_clsQuestion = new clsQuestion();
        clsMainDB obj_clsMainDB = new clsMainDB();
        clsCourse obj_Course = new clsCourse();
        DataTable DTCourse = new DataTable();
        string SPString;
        DataTable DT = new DataTable();
        int _QuizID = 0;
        bool _IsEdit;
        private void ShowEntry()
        {
            if (dgvQuiz.CurrentRow.Cells[0].Value.ToString() == string.Empty)
            {
                MessageBox.Show("There is No Data");

            }
            else
            {
                _QuizID = Convert.ToInt32(dgvQuiz.CurrentRow.Cells["QuizID"].Value.ToString());
                lblCourse.Text = dgvQuiz.CurrentRow.Cells["CourseName"].Value.ToString();
                //cboCourse.Items.Add = dgvQuiz.CurrentRow.Cells["CourseName"].Value.ToString();
                txtQuestion.Text = dgvQuiz.CurrentRow.Cells["Question"].Value.ToString();
                txtAnswer1.Text = dgvQuiz.CurrentRow.Cells["Answer1"].Value.ToString();
                txtAnswer2.Text = dgvQuiz.CurrentRow.Cells["Answer2"].Value.ToString();
                txtAnswer3.Text = dgvQuiz.CurrentRow.Cells["Answer3"].Value.ToString();
                txtAnswer4.Text = dgvQuiz.CurrentRow.Cells["Answer4"].Value.ToString();
                txtCorrectAnswer.Text = dgvQuiz.CurrentRow.Cells["CorrectAns"].Value.ToString();
               

                _IsEdit = true;
                ShowData();
            }
        }
        public void ShowData()
        {


            if (cboCourse.SelectedIndex==0)
            {
                SPString = string.Format("SP_Select_Quiz N'{0}',N'{1}',N'{2}'", "0", "0", "1");
              
            }
            else
            {
                SPString = string.Format("SP_Select_Quiz N'{0}',N'{1}',N'{2}'",Convert.ToInt32(cboCourse.SelectedValue.ToString()), "0", "2");
            }
            dgvQuiz.DataSource = obj_clsMainDB.SelectData(SPString);
            dgvQuiz.Columns[0].Width = (dgvQuiz.Width / 220) * 10;
            dgvQuiz.Columns[1].Visible = false;
            dgvQuiz.Columns[2].Visible = false;
           
        }
        public void ClearData()
        {
            txtAnswer1.Text = "";
            txtAnswer3.Text = "";
            txtAnswer2.Text = "";
            txtAnswer4.Text = "";
            txtCorrectAnswer.Text = "";
            txtQuestion.Text = "";
            lblCourse.Text = "";
            
        }
        public frmViewandUpdate()
        {
            InitializeComponent();
        }

        private void frmViewandUpdate_Load(object sender, EventArgs e)
        {
            SPString = string.Format("SP_Select_Course N'{0}',N'{1}',N'{2}'", "0", "0", "0");
            obj_Course.AddCombo(ref cboCourse, SPString, "CourseName", "CourseID");
            
            ShowData();
            AdminLogo();
            btnViewandUpdate.BackColor = Color.DeepPink;
          
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

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (txtQuestion.Text == "")
            {
                MessageBox.Show("Please Type Your Question");
                txtQuestion.Focus();
            }
            else if (txtAnswer1.Text == "")
            {
                MessageBox.Show("Please fill Answer1");
                txtAnswer1.Focus();

            }
            else if (txtAnswer2.Text == "")
            {
                MessageBox.Show("Please fill Answer2");
                txtAnswer2.Focus();
            }
            else if (txtAnswer3.Text == "")
            {
                MessageBox.Show("Please fill Answer3");
                txtAnswer3.Focus();
            }
            else if (txtAnswer4.Text == "")
            {
                MessageBox.Show("Please fill Answer4");
                txtAnswer4.Focus();
            }
            else if (txtCorrectAnswer.Text == "")
            {
                MessageBox.Show("Please Fill Correctans");
                txtCorrectAnswer.Focus();
            }
            else
            {
            //    SPString = string.Format("SP_Select_Quiz N'{0}',N'{1}',N'{2}'", txtQuestion.Text.Trim().ToString(), "0", "0");
            //    DT = obj_clsMainDB.SelectData(SPString);
            //    //int a = Convert.ToInt32(DT.Rows[0]["QuizID"]);
            //    if (DT.Rows.Count > 0)
            //    {
            //        MessageBox.Show("This Item is Already Exist");

            //    }
                
                

                    obj_clsQuestion.QUIZID = Convert.ToInt32(_QuizID);
                    obj_clsQuestion.COURSEID = Convert.ToInt32(dgvQuiz.CurrentRow.Cells["CourseID"].Value.ToString());
                    obj_clsQuestion.QUESTION = txtQuestion.Text;
                    obj_clsQuestion.ANSWER1 = txtAnswer1.Text;
                    obj_clsQuestion.ANSWER2 = txtAnswer2.Text;
                    obj_clsQuestion.ANSWER3 = txtAnswer3.Text;
                    obj_clsQuestion.ANSWER4 = txtAnswer4.Text;
                    obj_clsQuestion.CORRECTANS = txtCorrectAnswer.Text;

                    obj_clsQuestion.ACTION = 1;
                    obj_clsQuestion.SaveData();
                    MessageBox.Show("Successfully Update", "Successfully", MessageBoxButtons.OK);
                    ClearData();
                    txtQuestion.Focus();
                    ShowData();
                

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string QuizID = dgvQuiz.CurrentRow.Cells["QuizID"].Value.ToString();
            if (QuizID==string.Empty)
            {
                MessageBox.Show("there is No Data");
            }
            else if (txtQuestion.Text == "" || txtAnswer1.Text == "")
            {
                MessageBox.Show("Please fill Question ");
            }
            else
            {
                if (MessageBox.Show("Are You Sure You Want To Delete?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    obj_clsQuestion.QUIZID = Convert.ToInt32(dgvQuiz.CurrentRow.Cells["QuizID"].Value.ToString());
                    obj_clsQuestion.ACTION = 2;
                    obj_clsQuestion.SaveData();
                    MessageBox.Show("Successfully Delete");
                    ShowData();
                    ClearData();
                }
            }
        }

        private void dgvQuiz_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dgvQuiz_DoubleClick(object sender, EventArgs e)
        {
            ShowEntry();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
  

        private void lblCourse_Click(object sender, EventArgs e)
        {

        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new frmAdmin().ShowDialog();
        }

        private void btnViewandUpdate_Click(object sender, EventArgs e)
        {
         
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new frmSetting().ShowDialog();
        }

       

        private void textBox1_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            

        }

       

        private void btnCreateQuiz_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmCreateQuiz frm = new frmCreateQuiz();
            frm.ShowDialog();
        }

        private void cboCourse_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ShowData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                txtSearch.Text = "Search";
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            (dgvQuiz.DataSource as DataTable).DefaultView.RowFilter = string.Format("CourseName Like '{0}%'", txtSearch.Text);
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
