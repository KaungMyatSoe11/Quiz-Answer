using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using QuizApp.DBA;
using QuizApp.Student;


namespace QuizApp.Admin
{
    public partial class frmResult : Form
    {
        string SPString;
        clsAdmin obj_clsCourseDetail = new clsAdmin();
        clsMainDB obj_clsMainDB = new clsMainDB();
        public frmResult()
        {
            InitializeComponent();
        }
        

        private void frmResult_Load(object sender, EventArgs e)
        {
            SPString = string.Format("SP_Select_Course N'{0}',N'{1}',N'{2}'", "0", "0", "0");
            obj_clsCourseDetail.AddCombo(ref cboCourseName, SPString, "CourseName", "CourseID");
            dgvResult.RowTemplate.Height = 80;
            btnResult.BackColor = Color.DeepPink;
            AdminLogo();
            ShowData();
        }

        private void cboCourseName_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowData();
            Showstudentprofile();
        }
        public void ShowData()
        {


            if (cboCourseName.SelectedIndex == 0)
            {
                SPString = string.Format("SP_Select_CourseDetail N'{0}',N'{1}',N'{2}'", "0", "0", "5");
                dgvResult.DataSource = obj_clsMainDB.SelectData(SPString);

                dgvResult.Columns[1].Visible = false;
                dgvResult.Columns[4].Visible = false;


                for (int i = 0; i < dgvResult.Columns.Count; i++)
                {
                    if (dgvResult.Columns[i] is DataGridViewImageColumn)
                    {
                        ((DataGridViewImageColumn)dgvResult.Columns[i]).ImageLayout = DataGridViewImageCellLayout.Stretch;
                    }
                }
            }
            else
            {
                SPString = string.Format("SP_Select_CourseDetail N'{0}',N'{1}',N'{2}'", Convert.ToInt32(cboCourseName.SelectedValue.ToString()), "0", "4");
                dgvResult.DataSource = obj_clsMainDB.SelectData(SPString);

                dgvResult.Columns[1].Visible = false;
                dgvResult.Columns[4].Visible = false;



                for (int i = 0; i < dgvResult.Columns.Count; i++)
                {
                    if (dgvResult.Columns[i] is DataGridViewImageColumn)
                    {
                        ((DataGridViewImageColumn)dgvResult.Columns[i]).ImageLayout = DataGridViewImageCellLayout.Stretch;
                    }
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

        private void dgvResult_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Showstudentprofile();
        }
        public void Showstudentprofile()
        {
            if (dgvResult.Rows.Count > 0)
            {
                SqlCommand cmd = new SqlCommand(@"Select StudentImage from Student Where StudentID=" + dgvResult.CurrentRow.Cells["StudentID"].Value.ToString() + "", obj_clsMainDB.con);

                SqlDataAdapter sda = new SqlDataAdapter();
                DataTable DT = new DataTable();
                sda.SelectCommand = cmd;
                DataSet ds = new DataSet();
                byte[] md = new byte[0];
                sda.Fill(ds, "StudentImage");
                DataRow dr;
                dr = ds.Tables["StudentImage"].Rows[0];
                md = (byte[])dr["StudentImage"];
                MemoryStream stream = new MemoryStream(md);
                picStudent.Image = Image.FromStream(stream);
            }
            else
            {
                picStudent.Image = null;
            }
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new frmResult().ShowDialog();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new frmAdmin().ShowDialog();
        }

        private void btnCreateQuiz_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new frmCreateQuiz().ShowDialog();
        }

        private void btnViewandUpdate_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new frmViewandUpdate().ShowDialog();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new frmSetting().ShowDialog();
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

        private void lblPoint_Click(object sender, EventArgs e)
        {

        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            About frm = new About();
            frm.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
