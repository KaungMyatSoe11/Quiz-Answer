using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using QuizApp.DBA;
using System.Data.SqlClient;
using System.IO;
using QuizApp.Student;


namespace QuizApp.Admin
{
    public partial class frmAdmin : Form
    {
        //SqlConnection con = new SqlConnection(@"Data Source=WINDOWS-C6RB5G6;Initial Catalog=QuizApplication;User ID=sa;Password=kms1998");
        clsStudent obj_clsStudent = new clsStudent();
        clsMainDB obj_clsMainDB = new clsMainDB();

        DataTable DT = new DataTable();
        DataTable DTClass = new DataTable();
        public bool _IsEdit = false;
        public int _StudentID = 0;
        string SPString = "";
        int Count = 0;
        public int _ClassID = 0;
        clsClassDetail obj_clsClassDetail = new clsClassDetail();

        public frmAdmin()
        {
            InitializeComponent();
        }
       
        public void TotalStudent()
        {
            lblTotalStudent.Text = "Total Students:" + dgvStudent.Rows.Count;
            ShowData();
        }
        public void ShowData()
        {
            //SPString = string.Format("SP_Select_Class N'{0}',N'{1}',N'{2}'", "0", "0", "0");
            //obj_clsMainDB.AddCombo(ref cboClass, SPString, "ClassTime", "ClassID");


            SPString = string.Format("SP_Select_Student N'{0}',N'{1}',N'{2}'", "0", "0", "0");
            dgvStudent.DataSource = obj_clsMainDB.SelectData(SPString);

            //dgvStudent.Columns[0].Width = (dgvStudent.Width / 100) * 6;
            //dgvStudent.Columns[1].Visible = false;
            //dgvStudent.Columns[2].Width = (dgvStudent.Width / 100) * 20;
            //dgvStudent.Columns[3].Width = (dgvStudent.Width / 100) * 20;
            //dgvStudent.Columns[4].Width = (dgvStudent.Width / 100) * 20;
            //dgvStudent.Columns[5].Width = (dgvStudent.Width / 100) * 20;
            //dgvStudent.Columns[6].Width = (dgvStudent.Width / 100) * 20;
            dgvStudent.Columns[0].Width = (dgvStudent.Width / 100) * 5;
            dgvStudent.Columns[1].Visible = false;
            dgvStudent.Columns[3].Visible = false;
            dgvStudent.Columns[11].Visible = false;
            dgvStudent.Columns[12].Visible = false;


            for (int i = 0; i < dgvStudent.Columns.Count; i++)
            {
                if (dgvStudent.Columns[i] is DataGridViewImageColumn)
                {
                    ((DataGridViewImageColumn)dgvStudent.Columns[i]).ImageLayout = DataGridViewImageCellLayout.Stretch;
                }
            }
            


           // obj_clsMainDB.ToolStripTextBoxData(ref tstSearch, SPString, "StudentName");

        }
        private void frmAdmin_Load(object sender, EventArgs e)
        {
          //  string Day = string.Format("{0:D2}", DateTime.Now.Day);
          //  string Month = string.Format("{0:D2}", DateTime.Now.Month);
          //  string Year = string.Format("{0:D2}", DateTime.Now.Year);
          ////  lblUpdateDate.Text = Month + "/" + Day + "/" + Year;
            dgvStudent.Rows.Clear();
            dgvStudent.RowTemplate.Height = 80;
            btnAddStudent.BackColor = Color.DeepPink;
            AdminLogo();
            ShowData();
            TotalStudent();

        }
        

        private void ShowEntry()
        {
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

     
       

        private void dgvStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        public void Showprofile()
        {
            SqlCommand cmd = new SqlCommand(@"Select StudentImage from Student Where StudentID=" + dgvStudent.CurrentRow.Cells["StudentID"].Value.ToString() + "", obj_clsMainDB.con);

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

        private void dgvStudent_DoubleClick(object sender, EventArgs e)
        {
            ShowEntry();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            
            if (dgvStudent.CurrentRow.Cells[0].Value.ToString() == string.Empty)
            {
                MessageBox.Show("there is No Data");
            }
            else
            {
                if (MessageBox.Show("Are You Sure You Want To Delete?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    obj_clsMainDB.con.Open();
                    SqlCommand cmd = new SqlCommand(@"DELETE from Student WHERE (StudentID='" + dgvStudent.SelectedRows[0].Cells[1].Value.ToString() + "')",obj_clsMainDB.con);
                    cmd.ExecuteNonQuery();
                    obj_clsMainDB.con.Close();
                    MessageBox.Show("Record Delete Successfully!");

                    
                    ShowData();
                    TotalStudent();
                }
            }
        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }


        
       

        

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnimage_Click(object sender, EventArgs e)
        {

        }

       

        

        private void btnSetting_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmSetting setting = new frmSetting();
            setting.ShowDialog();
        }
        public void AdminLogo()
        {
            SPString = string.Format("SP_Select_Admin N'{0}',N'{1}',N'{2}'", Program.AdminID, "0", "2");
            DT = obj_clsMainDB.SelectData(SPString);
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
            

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Logout", "Confirm Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                About frm = new About();
                frm.ShowDialog();

            }
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

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new frmAdmin().ShowDialog();
        }

        private void dgvStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Showprofile();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new frmResult().ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            //this.Visible = false;
            new About().ShowDialog();
        }

      

        

       
    }
    }

    

