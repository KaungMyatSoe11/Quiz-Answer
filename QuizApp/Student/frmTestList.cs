using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using QuizApp.DBA;
using System.Data.SqlClient;
using System.IO;

namespace QuizApp.Student
{
    public partial class frmTestList : Form
    {
        clsProfile obj_clsProfile = new clsProfile();
   //     SqlConnection con = new SqlConnection(@"Data Source=WINDOWS-C6RB5G6;Initial Catalog=QuizApplication;User ID=sa;Password=kms1998");
        //for storge courseid
        int _CourseID = 0;
        int top = 1;
        int Counts = 1;
        int panelWidth;
        bool hidden;
        DataTable DT = new DataTable();
        string SPString;
        clsMainDB obj_clsMainDB = new clsMainDB();
        clsCourseDetail obj_clsCourseDeatil = new clsCourseDetail();
        public frmTestList()
        {
            
            InitializeComponent();
            panelWidth = panelslide.Width;
            hidden = false;
        }
        frmResult studenthome = new frmResult();
        
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
        //public System.Windows.Forms.Panel addpanel(int left, int distance, string CourseName, int Enorll)
        //{
        //    System.Windows.Forms.Panel pan = new System.Windows.Forms.Panel();
        //    panMain.Controls.Add(pan);
        //    pan.BackColor = Color.Blue;
        //    pan.Top = top * distance;
        //    pan.Left = left;

        //    pan.Size = new System.Drawing.Size(130, 146);
        //    System.Windows.Forms.Label newlable = new System.Windows.Forms.Label();
        //    newlable.Dock = System.Windows.Forms.DockStyle.Bottom;
        //    newlable.BackColor = Color.Black;
        //    newlable.Size = new System.Drawing.Size(130, 31);
        //    System.Windows.Forms.Label lblCount = new System.Windows.Forms.Label();
        //    lblCount.Dock = System.Windows.Forms.DockStyle.Left;
        //    lblCount.Size = new System.Drawing.Size(60, 30);
        //    lblCount.Text = Enorll.ToString();
        //    lblCount.ForeColor = Color.White;
        //    lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        //    //lblCount.BackColor = Color.Navy;
        //    System.Windows.Forms.Label lblCoursename = new System.Windows.Forms.Label();
        //    lblCoursename.Dock = System.Windows.Forms.DockStyle.Right;
        //    lblCoursename.Size = new System.Drawing.Size(60, 40);
        //    lblCoursename.Text = CourseName;
        //    lblCoursename.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        //    lblCoursename.ForeColor = Color.White;
        //    //lblCoursename.BackColor = Color.AliceBlue;
        //    newlable.Controls.Add(lblCount);
        //    newlable.Controls.Add(lblCoursename);
        //    pan.Controls.Add(newlable);
        //    pan.Controls.Add(lblCourse(CourseName));

        //    top = top + 8;
            
        //    return pan;

        //}
        //System.Windows.Forms.Label lblCourse(string coursename)
        //{
        //    System.Windows.Forms.Label lbl= new System.Windows.Forms.Label();
        //    lbl.Dock = System.Windows.Forms.DockStyle.Fill;
        //    lbl.AutoSize = false;
        //    lbl.BackColor = Color.Red;
        //    lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        //    lbl.Text = coursename;
        //    lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //    return lbl;

        //}
        //public void Show()
        //{
        //    SPString = string.Format("SP_Select_Course N'{0}',N'{1}',N'{2}'", "0", "0", "0");
        //    DT = obj_clsMainDB.SelectData(SPString);

        //    for (int i = 0; i < DT.Rows.Count; i++)
        //    {
        //        string Coursename = DT.Rows[i]["CourseName"].ToString();
        //        SPString = string.Format("SP_Select_CourseDetail N'{0}',N'{1}',N'{2}'", Coursename, "0", "0");
        //        DataTable DTcount = obj_clsMainDB.SelectData(SPString);
        //        int Enorll = Convert.ToInt32(DTcount.Rows.Count);
        //        if (Counts < 3)
        //        {

        //            addpanel(27, 25, Coursename, Enorll);
        //            Counts++;
        //        }
        //        else if (Counts >= 3 && Counts < 5)
        //        {
        //            if (Counts == 3)
        //            {
        //                top = 1;
        //            }
        //            addpanel((27+130+27), 25, Coursename, Enorll);
        //            Counts++;

        //        }
        //        else if (Counts >= 5 && Counts < 7)
        //        {
        //            if (Counts == 5)
        //            {
        //                top = 1;
        //            }
        //            addpanel((27 + 130 +27+130+ 27), 25, Coursename, Enorll);
        //            Counts++;
        //        }
        //    }
        //}

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void frmTestList_Load(object sender, EventArgs e)
        {
            Profile();
            SPString = string.Format("SP_Select_CourseDetail N'{0}',N'{1}',N'{2}'", "0", "0", "0");
            DT = obj_clsMainDB.SelectData(SPString);
            dgvTestList.RowTemplate.Height = 80;
            btnTest.BackgroundColor = Color.CadetBlue;
            showlist();
       
           
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
        public void showlist()
        {
          
            //SPString = string.Format("SP_Select_Class N'{0}',N'{1}',N'{2}'", "0", "0", "0");
            //obj_clsMainDB.AddCombo(ref cboClass, SPString, "ClassTime", "ClassID");


            SPString = string.Format("SP_Select_Course N'{0}',N'{1}',N'{2}'", "0", "0", "0");
            dgvTestList.DataSource = obj_clsMainDB.SelectData(SPString);

            dgvTestList.Columns[1].Visible = false;
           




            for (int i = 0; i < dgvTestList.Columns.Count; i++)
            {
                if (dgvTestList.Columns[i] is DataGridViewImageColumn)
                {
                    ((DataGridViewImageColumn)dgvTestList.Columns[i]).ImageLayout = DataGridViewImageCellLayout.Stretch;
                }
            }
            


           // obj_clsMainDB.ToolStripTextBoxData(ref tstSearch, SPString, "StudentName");

        }
        

        private void panMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvTestList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            totestpage();
        }
        //to test method
        public void totestpage()
        {
            SqlCommand cmd = new SqlCommand(@"Select CImage from Course where CourseID=" + dgvTestList.CurrentRow.Cells["CourseID"].Value.ToString() + "", obj_clsMainDB.con);

            SqlDataAdapter sda = new SqlDataAdapter();
            DataTable DT = new DataTable();
            sda.SelectCommand = cmd;
            DataSet ds = new DataSet();
            byte[] md = new byte[0];
            sda.Fill(ds, "CImage");
            DataRow dr;
            dr = ds.Tables["CImage"].Rows[0];
            md = (byte[])dr["CImage"];
            MemoryStream stream = new MemoryStream(md);
            picCourse.Image = Image.FromStream(stream);
            ////
            SPString = string.Format("SP_Select_Course N'{0}',N'{1}',N'{2}'", dgvTestList.CurrentRow.Cells["CourseID"].Value.ToString(), "0", "2");
            DT = obj_clsMainDB.SelectData(SPString);
            lblCourse.Text = DT.Rows[0]["CourseName"].ToString();
            _CourseID = Convert.ToInt32(DT.Rows[0]["CourseID"].ToString());
            //for enrollment
            string sp = string.Format("SP_Select_CourseDetail N'{0}',N'{1}',N'{2}'", dgvTestList.CurrentRow.Cells["CourseID"].Value.ToString(), "0", "1");
            DataTable dt = obj_clsMainDB.SelectData(sp);
            lblTotal.Text = dt.Rows.Count.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {


            QuizSart();

        }
        //meth goto testpage
        public void QuizSart()
        {
            if (_CourseID == 0)
            {
                MessageBox.Show("You should choose Course!", "Select Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SPString = string.Format("SP_Select_Quiz N'{0}',N'{1}',N'{2}'", _CourseID, "0", "2");
                DT = obj_clsMainDB.SelectData(SPString);
                if (DT.Rows.Count > 0)
                {
                    totestpage();
                    saveCoursedetails();
                    frmTest frm = new frmTest();

                    frm._CouseID = _CourseID;//id transfer
                    frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("This Course haven't Quiz", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvTestList.Focus();
                }


            }
        }
        public void saveCoursedetails()
        {
            SPString = string.Format("SP_Select_CourseDetail N'{0}',N'{1}',N'{2}'", _CourseID, Program.StudentID, "2");
                DT=obj_clsMainDB.SelectData(SPString);
            //obj_clsCourseDeatil.CourseID = _CourseID;
            //obj_clsCourseDeatil.StudentID = Program.StudentID;
            //obj_clsCourseDeatil.Date = DateTime.Now.ToShortDateString();
            //obj_clsCourseDeatil.Point = 1;
           
        //    obj_clsCourseDeatil.SaveData();
       }

        private void dgvTestList_DoubleClick(object sender, EventArgs e)
        {
            QuizSart();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
          //  this.Visible = false;
            new frmTestList().ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Logout", "Confirm Message",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Visible = false;
                frmLogin frm = new frmLogin();
                frm.ShowDialog();

            }
        }

        private void btnRank_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmRank frm = new frmRank();
            frm.ShowDialog();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmResult frm = new frmResult();
            frm.ShowDialog();
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

        private void btnExist_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblStudentName_Click(object sender, EventArgs e)
        {
            new frmStudentprofilechange().ShowDialog();
        }
       


       
        
        
        //private void profile()
        //{
        //    SPString = string.Format("SP_Select_Student N'{0}',N'{1}',N'{2}'", Program.StudentID, "0", "6");
        //    DT = obj_clsMainDB.SelectData(SPString);
            
        //}

        
    }
}
