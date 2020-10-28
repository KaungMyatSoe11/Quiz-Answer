using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using QuizApp.DBA;
using System.IO;
using System.Data.SqlClient;

namespace QuizApp.Student
{
    public partial class frmStudentprofilechange : Form
    {
        
      //  SqlConnection con = new SqlConnection(@"Data Source=WINDOWS-C6RB5G6;Initial Catalog=QuizApplication;User ID=sa;Password=kms1998");
        string SPString;
        clsStudent obj_Student = new clsStudent();
        DataTable DT = new DataTable();
        clsMainDB obj_clsMainDB = new clsMainDB();
        public frmStudentprofilechange()
        {
            InitializeComponent();
        }

        private void picStudent_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All Files(*.*)|*.*";
            DialogResult res = ofd.ShowDialog();
            if (res == DialogResult.OK)
            {
                picStudent.Image = Image.FromFile(ofd.FileName);
            }
        }
        public void showstudendata()
        {
            SPString = string.Format("SP_Select_Student N'{0}',N'{1}',N'{2}'", Program.StudentID, "0", "6");
            DT = obj_clsMainDB.SelectData(SPString);
            txtStudentName.Text = DT.Rows[0]["StudentName"].ToString();
            txtNRC.Text = DT.Rows[0]["NRC"].ToString();
            txtPhone.Text = DT.Rows[0]["Phone"].ToString();
            txtConfirmPassword.Text = DT.Rows[0]["Password"].ToString();
            txtPassword.Text = DT.Rows[0]["Password"].ToString();
            txtAddress.Text = DT.Rows[0]["Address"].ToString();
            txthnit.Text = DT.Rows[0]["hnit"].ToString();
            txthnitanswer.Text = DT.Rows[0]["hnitanswer"].ToString();


            SPString = string.Format("SP_Select_Student N'{0}',N'{1}',N'{2}'",Program.StudentID, "0", "7");
            DT = obj_clsMainDB.SelectData(SPString);

            byte[] md = new byte[0];
            md = (byte[])DT.Rows[0]["StudentImage"];
            MemoryStream stream = new MemoryStream(md);
            picStudent.Image = Image.FromStream(stream);
        }
        public void editvisiblefalse()
        {
            txthnitanswer.Enabled = false;
            txthnit.Enabled = false;
            txtConfirmPassword.Enabled = false;
            txtAddress.Enabled = false;
            txtNRC.Enabled = false;
            txtPhone.Enabled = false;
            txtStudentName.Enabled = false;
            txtPassword.Enabled = false;
            picStudent.Enabled=false;

        }
        public void editvisibletrue()
        {
            txthnitanswer.Enabled = true;
            txthnit.Enabled = true;
            txtConfirmPassword.Enabled = false;
            txtAddress.Enabled = true;
            txtNRC.Enabled = true;
            txtPhone.Enabled = true;
            txtStudentName.Enabled = true;
            txtPassword.Enabled = false;
            picStudent.Enabled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnChange.Text == "Change Information")
            {
                btnPC.Text = "Cancel";
                btnChange.Text = "Save";
                editvisibletrue();
                showstudendata();

            }
            else if (btnChange.Text =="Cancel")
            {
                this.Visible = false;
                new frmTestList().ShowDialog();
            }
            else if (btnChange.Text == "Save")
            {

                if (txtStudentName.Text.Trim() == "")
                {
                    MessageBox.Show("Please Type Student Name!!");
                    txtStudentName.Focus();
                }

                else if (txtPhone.Text.Trim() == "")
                {
                    MessageBox.Show("Please Type Mobile Number!!");
                    txtPhone.Focus();
                }
                else if (txtAddress.Text.Trim() == "")
                {
                    MessageBox.Show("Please Type Address!!");
                    txtAddress.Focus();
                }
                else if (txtNRC.Text.Trim() == "")
                {
                    MessageBox.Show("Please Type NRC!!");
                    txtNRC.Focus();
                }
                else if (picStudent.Image == null)
                {
                    MessageBox.Show("Please Upload Image!!");
                    picStudent.Focus();
                }

                else if (txthnitanswer.Text == string.Empty)
                {
                    MessageBox.Show("Please Type Your hnit Answer");
                    txthnitanswer.Focus();
                }


                else
                {

                    SPString = string.Format("SP_Select_Student N'{0}',N'{1}',N'{2}'", txtNRC.Text, "0", "1");
                    DT = obj_clsMainDB.SelectData(SPString);
                    if (DT.Rows.Count > 0)
                    {


                        obj_clsMainDB.con.Open();
                        SqlCommand cmd = new SqlCommand(@"Update Student  set StudentName ='" + txtStudentName.Text + "',NRC='" + txtNRC.Text + "',ChangeDate='" + DateTime.Now.ToLongDateString() + "',Phone='" + txtPhone.Text + "',Address='" + txtAddress.Text + "',hnit='" + txthnit.Text + "',hnitanswer='" + txthnitanswer.Text + "',StudentImage = @pic where StudentID='" + Program.StudentID + "'", obj_clsMainDB.con);

                        MemoryStream stream = new MemoryStream();
                        picStudent.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                        byte[] pic = stream.ToArray();
                        cmd.Parameters.AddWithValue("@pic", pic);
                        cmd.ExecuteNonQuery();
                        obj_clsMainDB.con.Close();

                        //    obj_Student.STUDENTNAME = txtStudentName.Text;
                        //    obj_Student.STUDENTPASSWORD = txtPassword.Text;
                        //    obj_Student.NRC = txtNRC.Text;
                        //    obj_Student.UPDATE = DateTime.Now.ToLongTimeString();
                        //    MemoryStream stream = new MemoryStream();
                        //    picStudent.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                        //    byte[] pic = stream.ToArray();
                        //    obj_Student.SIMAGE = pic;

                        //    obj_Student.PHONE = txtPhone.Text;
                        //    obj_Student.Address = txtAddress.Text;
                        //,Password='" + txtPassword.Text + "'
                        //    obj_Student.Hnit = txthnit.Text;
                        //    obj_Student.ACTION = 0;
                        //    obj_Student.SaveData();
                        MessageBox.Show("Successfully Edit", "Edit");
                        this.Visible = false;
                        new frmTestList().ShowDialog();
                    }

                }
            }
        }

        private void btnPC_Click(object sender, EventArgs e)
        {
            if (btnPC.Text == "Password Change")
            {
                btnPC.Text = "Save";
                btnChange.Text = "Cancel";
                txtPassword.Enabled = true;
                txtConfirmPassword.Enabled = true;

            }
            else if (btnPC.Text == "Save")
            {
                if (txtPassword.Text == string.Empty || txtConfirmPassword.Text == string.Empty)
                {
                    MessageBox.Show("Please type date", "Warnning");
                    txtConfirmPassword.Focus();
                }
                if (txtPassword.Text != txtConfirmPassword.Text)
                {
                    MessageBox.Show("Your confirmPassword should be same Password", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtConfirmPassword.Focus();
                }
                else
                {
                    SqlCommand cmd = new SqlCommand(@"Update Student set Password ='" + txtPassword.Text + "',ChangeDate='" + DateTime.Now.ToLongDateString() + "'", obj_clsMainDB.con);
                    obj_clsMainDB.con.Open();
                    cmd.ExecuteNonQuery();
                    obj_clsMainDB.con.Close();
                    MessageBox.Show("Successfully Save", "Save");
                    this.Visible = false;
                    new frmTestList().ShowDialog();
                }
            }
            else if (btnPC.Text == "Cancel")
            {
                this.Visible = false;
                new frmTestList().ShowDialog();
            }
        }

        private void frmStudentprofilechange_Load(object sender, EventArgs e)
        {
            showstudendata();
            editvisiblefalse();

        }

        private void btnExist_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
