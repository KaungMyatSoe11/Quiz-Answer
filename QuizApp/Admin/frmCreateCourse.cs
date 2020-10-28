using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using QuizApp.DBA;

using System.Data.SqlClient;
using System.IO;

namespace QuizApp.Admin
{
    public partial class frmCreateCourse : Form
    {
        int J = 0;
       // SqlConnection con = new SqlConnection(@"Data Source=WINDOWS-C6RB5G6;Initial Catalog=QuizApplication;User ID=sa;Password=kms1998");
        string SPString;
        DataTable DT = new DataTable();
        clsMainDB obj_clsMainDB = new clsMainDB();
        clsCourse obj_Course = new clsCourse();

        public frmCreateCourse()
        {
            InitializeComponent();
        }

       

        private void btnCreate_Click(object sender, EventArgs e)
        {
            SPString = string.Format("SP_Select_Course N'{0}',N'{1}',N'{2}'", txtCourseName.Text.ToString(), "0", "1");
            DT = obj_clsMainDB.SelectData(SPString);
            if (DT.Rows.Count > 0)
            {
                MessageBox.Show("This Course is Already Exit");
                txtCourseName.Focus();
                txtCourseName.SelectAll();
            }
            else
            {
                obj_clsMainDB.con.Open();
                SqlCommand cmd = new SqlCommand(@"insert into Course (CourseName,Date,CImage) values ('" + txtCourseName.Text + "','" + DateTime.Now.ToLongTimeString() + "',@pic)", obj_clsMainDB.con);
                MemoryStream stream = new MemoryStream();
                picCourse.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] pic = stream.ToArray();
                cmd.Parameters.AddWithValue("@pic", pic);
                cmd.ExecuteNonQuery();
                obj_clsMainDB.con.Close();
                
                MessageBox.Show("Successfully Save", "Save", MessageBoxButtons.OK);
               txtCourseName.Clear();
               txtCourseName.Focus();
                ShowData();
                this.Close();

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
        public void ShowData()
        {
            //SPString = string.Format("SP_Select_Class N'{0}',N'{1}',N'{2}'", "0", "0", "0");
            //obj_clsMainDB.AddCombo(ref cboClass, SPString, "ClassTime", "ClassID");


            SPString = string.Format("SP_Select_Course N'{0}',N'{1}',N'{2}'", "0", "0", "0");
            dgvCourse.DataSource = obj_clsMainDB.SelectData(SPString);

            //dgvStudent.Columns[0].Width = (dgvStudent.Width / 100) * 6;
            //dgvStudent.Columns[1].Visible = false;
            //dgvStudent.Columns[2].Width = (dgvStudent.Width / 100) * 20;
            //dgvStudent.Columns[3].Width = (dgvStudent.Width / 100) * 20;
            //dgvStudent.Columns[4].Width = (dgvStudent.Width / 100) * 20;
            //dgvStudent.Columns[5].Width = (dgvStudent.Width / 100) * 20;
            //dgvStudent.Columns[6].Width = (dgvStudent.Width / 100) * 20;
            dgvCourse.Columns[1].Visible = false;
           



            for (int i = 0; i < dgvCourse.Columns.Count; i++)
            {
                if (dgvCourse.Columns[i] is DataGridViewImageColumn)
                {
                    ((DataGridViewImageColumn)dgvCourse.Columns[i]).ImageLayout = DataGridViewImageCellLayout.Stretch;
                }
            }



            // obj_clsMainDB.ToolStripTextBoxData(ref tstSearch, SPString, "StudentName");

        }

        private void frmCreateCourse_Load(object sender, EventArgs e)
        {
            dgvCourse.RowTemplate.Height = 80;
            ShowData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            
            if (dgvCourse.CurrentRow.Cells[0].Value.ToString() == string.Empty)
            {
                MessageBox.Show("there is No Data");
            }
            else
            {
                if (MessageBox.Show("Are You Sure You Want To Delete?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    obj_clsMainDB.con.Open();
                    SqlCommand cmd = new SqlCommand(@"DELETE from Course WHERE (CourseID='" + dgvCourse.SelectedRows[0].Cells[1].Value.ToString() + "')", obj_clsMainDB.con);
                    cmd.ExecuteNonQuery();
                    obj_clsMainDB.con.Close();
                    MessageBox.Show("Record Delete Successfully!");


                    ShowData();
                    
               }
            }
        }

        private void clspic1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All Files(*.*)|*.*";
            DialogResult res = ofd.ShowDialog();
            if (res == DialogResult.OK)
            {
                picCourse.Image = Image.FromFile(ofd.FileName);
            }
        }
    }
}
