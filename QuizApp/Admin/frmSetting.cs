using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using QuizApp.DBA;
using System.IO;
using QuizApp.Student;


namespace QuizApp.Admin
{
    public partial class frmSetting : Form
    {
        clsAdmin obj_clsAdmin = new clsAdmin();
        clsMainDB obj_clsMainDB = new clsMainDB();
        string SPstring;
        
        public frmSetting()
        {
            InitializeComponent();
        }
        void cleardata()
        {
            txtName.Text = "";
            txtConfirmPassword.Text = "";
            txtNewPassword.Text = "";
            txtCurrentPassword.Text = "";
            txtName.Focus();
            picAdmin.Image = null;
        }

        private void frmSetting_Load(object sender, EventArgs e)
        {
            cleardata();
            AdminLogo();
            btnSetting.BackColor = Color.DeepPink;
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text == string.Empty)
            {
                txtName.Focus();
                txtName.SelectAll();
            }
            if (txtConfirmPassword.Text != txtNewPassword.Text)
            {
                MessageBox.Show("Confirmpassword is not correct");
            }
            if (txtConfirmPassword.Text == string.Empty)
            {
                txtConfirmPassword.Focus();
                txtConfirmPassword.SelectAll();
            }
            else if (txtCurrentPassword.Text ==string.Empty)
            {
                MessageBox.Show("Please type current Password","Warnning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txtCurrentPassword.Focus();
            }
            else if (txtNewPassword.Text == string.Empty)
            {
                txtNewPassword.Focus();
                txtNewPassword.SelectAll();
            }
            else if (picAdmin.Image == null)
            {
                MessageBox.Show("Please Upload a Logo", "Upload", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                picAdmin.Focus();
            }
            else if (txtCurrentPassword.Text == string.Empty)
            {
                txtCurrentPassword.Focus();
                txtCurrentPassword.SelectAll();
            }

            else
            {
                SPstring = string.Format("SP_Select_Admin N'{0}',N'{1}',N'{2}'", Program.AdminID, "0", "1");

                DataTable DT = new DataTable();
                DT = obj_clsMainDB.SelectData(SPstring);

                if (DT.Rows.Count > 0)
                {
                    if (txtCurrentPassword.Text != DT.Rows[0]["Password"].ToString())
                    {
                        MessageBox.Show("Currentpassword should be same");
                        txtCurrentPassword.Focus();
                        txtCurrentPassword.SelectAll();

                    }
                    else
                    {

                        obj_clsAdmin.ADMINID = Program.AdminID;
                        obj_clsAdmin.ADMINNAME = txtName.Text;
                        obj_clsAdmin.PASSWORD = txtConfirmPassword.Text;
                        MemoryStream stream = new MemoryStream();
                        picAdmin.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                        byte[] pic = stream.ToArray();
                        obj_clsAdmin.LOGO = pic;
                        obj_clsAdmin.ACTION = 1;
                        obj_clsAdmin.SaveData();
                        MessageBox.Show("Successfully save", "Successfuly", MessageBoxButtons.OK);
                        if (MessageBox.Show("Do you Want to LogIn?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            this.Visible = false;
                            new frmLogin().ShowDialog();
                        }
                        else
                        {
                            this.ShowDialog();
                            new frmSetting().ShowDialog();
                        }
                        cleardata();
                    }
                }


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void btnDelete_Click(object sender, EventArgs e)
        {
            cleardata();
        }

        private void clspic1_Click(object sender, EventArgs e)
        {

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

        private void picAdmin_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All Files(*.*)|*.*";
            DialogResult res = ofd.ShowDialog();
            if (res == DialogResult.OK)
            {
                picAdmin.Image = Image.FromFile(ofd.FileName);
            }
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

        private void Panel_Paint(object sender, PaintEventArgs e)
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
