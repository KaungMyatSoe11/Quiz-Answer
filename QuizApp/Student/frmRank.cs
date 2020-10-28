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
using System.IO;

namespace QuizApp.Student
{
    public partial class frmRank : Form
    {
        clsProfile obj_clsProfile = new clsProfile();
        clsMainDB obj_clsMainDB = new clsMainDB();
        DataTable DT = new DataTable();
        int panelWidth;
        bool hidden;
        clsCourseDetail obj_clsCourseDetail = new clsCourseDetail();
        string SPString = "";
        public frmRank()
        {
            InitializeComponent();
            panelWidth = panelslide.Width;
            hidden = false;

        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new frmTestList().ShowDialog();
        }
      

        private void frmRank_Load(object sender, EventArgs e)
        {
            Profile();
            SPString = string.Format("SP_Select_Course N'{0}',N'{1}',N'{2}'", "0", "0", "0");
           obj_clsCourseDetail.AddCombo(ref cboCourseName, SPString, "CourseName", "CourseID");
           dgvRank.RowTemplate.Height = 60;
           btnRank.BackgroundColor = Color.CadetBlue;
           ShowData();

        }
        public void ShowData()
        {


            if (cboCourseName.SelectedIndex == 0)
            {
                SPString = string.Format("SP_Select_CourseDetail N'{0}',N'{1}',N'{2}'", Program.StudentID, "0", "3");
                dgvRank.DataSource = obj_clsMainDB.SelectData(SPString);

                dgvRank.Columns[1].Visible = false;
                dgvRank.Columns[4].Visible = false;



                for (int i = 0; i < dgvRank.Columns.Count; i++)
                {
                    if (dgvRank.Columns[i] is DataGridViewImageColumn)
                    {
                        ((DataGridViewImageColumn)dgvRank.Columns[i]).ImageLayout = DataGridViewImageCellLayout.Stretch;
                    }
                }
            }
            else
            {
                SPString = string.Format("SP_Select_CourseDetail N'{0}',N'{1}',N'{2}'", Convert.ToInt32(cboCourseName.SelectedValue.ToString()), "0", "4");
                dgvRank.DataSource = obj_clsMainDB.SelectData(SPString);

                dgvRank.Columns[1].Visible = false;
                dgvRank.Columns[4].Visible = false;
              
      

                for (int i = 0; i < dgvRank.Columns.Count; i++)
                {
                    if (dgvRank.Columns[i] is DataGridViewImageColumn)
                    {
                        ((DataGridViewImageColumn)dgvRank.Columns[i]).ImageLayout = DataGridViewImageCellLayout.Stretch;
                    }
                }
            }
            
        }

        private void cboCourseName_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowData();
        }
        public void Profile()
        {
            SPString = string.Format("SP_Select_Student N'{0}',N'{1}',N'{2}'", Program.StudentID, "0", "6");
            DT = obj_clsMainDB.SelectData(SPString);
            lblStudentName.Text = DT.Rows[0]["StudentName"].ToString();
            ////////////////////
            int studentid = Program.StudentID;
            obj_clsProfile.StudentID = studentid;
            byte[] image = new byte[0];
            image = (byte[])obj_clsProfile.showprofile();
            MemoryStream stream = new MemoryStream(image);

            picStudent.Image = Image.FromStream(stream);

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

        private void btnRank_Click(object sender, EventArgs e)
        {
            frmRank frm = new frmRank();
            frm.ShowDialog();
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

        private void picStudent_Click(object sender, EventArgs e)
        {
           
            new frmStudentprofilechange().ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (hidden)
            {
                panelslide.Width = panelslide.Width + 30;
                if (panelslide.Width >= panelWidth)
                {
                    timer1.Stop();
                    hidden = false;
                    this.Refresh();
                }
            }
            else
            {
                panelslide.Width = panelslide.Width - 30;
                if (panelslide.Width <= 0)
                {
                    timer1.Stop();
                    hidden = true;
                    this.Refresh();
                }
            }
        }

        private void btnExist_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblStudentName_Click(object sender, EventArgs e)
        {
            new frmStudentprofilechange().ShowDialog();
        }
    }
}
