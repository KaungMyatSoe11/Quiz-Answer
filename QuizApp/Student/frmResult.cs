using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using QuizApp.DBA;
using System.IO;
using System.Data.SqlClient;

namespace QuizApp.Student
{
    public partial class frmResult : Form
    {
        clsProfile obj_clsProfile = new clsProfile();
        string SPString;
        clsMainDB obj_clsMainDB = new clsMainDB();
        int count = 0;
        int panelWidth;
        bool hidden;
        DataTable DT = new DataTable();
        public frmResult()
        {

            InitializeComponent();
            panelWidth = panelslide.Width;
            hidden = false;
        }
        public void Profile()
        {
            SPString=string.Format("SP_Select_Student N'{0}',N'{1}',N'{2}'", Program.StudentID,"0","6");
            DT = obj_clsMainDB.SelectData(SPString);
            lblStudentName.Text= DT.Rows[0]["StudentName"].ToString();
            ////////////////////
            int studentid = Program.StudentID;
            obj_clsProfile.StudentID = studentid;
            byte[] image = new byte[0];
            image = (byte[])obj_clsProfile.showprofile();
            MemoryStream stream = new MemoryStream(image);

            picStudent.Image = Image.FromStream(stream);

        }

        private void xuiSuperButton4_Click(object sender, EventArgs e)
        {

        }

        private void clspic1_Click(object sender, EventArgs e)
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

        private void frmStudentHome_Load(object sender, EventArgs e)
        {
            Profile();
            showtop3();
            btnResult.BackgroundColor = Color.CadetBlue;
            dgvResultList.RowTemplate.Height = 60;
            showdatagridview();
        }
        public void showdatagridview()
        {
            SPString = string.Format("SP_Select_CourseDetail N'{0}',N'{1}',N'{2}'",Program.StudentID, "0", "3");
            dgvResultList.DataSource = obj_clsMainDB.SelectData(SPString);


            dgvResultList.Columns[1].Visible = false;
            dgvResultList.Columns[4].Visible = false;



            for (int i = 0; i < dgvResultList.Columns.Count; i++)
            {
                if (dgvResultList.Columns[i] is DataGridViewImageColumn)
                {
                    ((DataGridViewImageColumn)dgvResultList.Columns[i]).ImageLayout = DataGridViewImageCellLayout.Stretch;
                }

            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new frmTestList().ShowDialog();
        }
        public void showtop3()
        {
            SPString = string.Format("SP_Select_CourseDetail N'{0}',N'{1}',N'{2}'", Program.StudentID, "0", "3");
            DT = obj_clsMainDB.SelectData(SPString);
            count= DT.Rows.Count;
            if (DT.Rows.Count >= 3)
            {
                showpic(count);
                for (int i = 0; i < count; i++)
                {
                    if (i == 0)
                    {
                        lblCourseName1.Text = DT.Rows[i]["CourseName"].ToString();
                        lblPoint1.Text = DT.Rows[i]["Point"].ToString();

                    }
                    else if (i == 1)
                    {
                        lblCourse2.Text = DT.Rows[i]["CourseName"].ToString();
                        lblPoint2.Text = DT.Rows[i]["Point"].ToString();

                    }
                    else if (i == 2)
                    {
                        lblCourse3.Text = DT.Rows[i]["CourseName"].ToString();
                        lblPoint3.Text = DT.Rows[i]["Point"].ToString();
                    }
                }


                //upload for course1

            }
            else if (DT.Rows.Count < 3)
            {
                showpic(count);
                for (int i = 0; i < count; i++)
                {
                    if (i == 0)
                    {
                        lblCourseName1.Text = DT.Rows[i]["CourseName"].ToString();
                        lblPoint1.Text = DT.Rows[i]["Point"].ToString();

                    }
                    else if (i == 1)
                    {
                        lblCourse2.Text = DT.Rows[i]["CourseName"].ToString();
                        lblPoint2.Text = DT.Rows[i]["Point"].ToString();

                    }
                    else if (i == 2)
                    {
                        lblCourse3.Text = DT.Rows[i]["CourseName"].ToString();
                        lblPoint3.Text = DT.Rows[i]["Point"].ToString();
                    }
                }
            }
        }
        public void showpic(int count)
        {
            for (int i = 0; i < count; i++)
            {
                SqlCommand cmd = new SqlCommand(@"Select ROW_NUMBER()over(order by Point) as No, * from vi_CourseDetail where StudentID ='"+Program.StudentID+"' order by Point Desc", obj_clsMainDB.con);

                SqlDataAdapter sda = new SqlDataAdapter();
                DataTable dt = new DataTable();
                sda.SelectCommand = cmd;
                DataSet ds = new DataSet();
                byte[] md = new byte[0];
                sda.Fill(ds, "CImage");
                DataRow dr;
                dr = ds.Tables["CImage"].Rows[i];
                md = (byte[])dr["CImage"];
                MemoryStream stream = new MemoryStream(md);
                if (i == 0)
                {
                    picCourse1.Image = Image.FromStream(stream);
                }
                if (i == 1)
                {
                    picCourse2.Image = Image.FromStream(stream);
                }
                if (i == 2)
                {
                    picCourse3.Image = Image.FromStream(stream);
                }
            }
        }

        private void btnRank_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmRank frm = new frmRank();
            frm.ShowDialog();
           
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

        private void btnAbout_Click(object sender, EventArgs e)
        {
            About frm = new About();
            frm.ShowDialog();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmResult frm = new frmResult();
            frm.ShowDialog();
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
