using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuizApp.DBA;
using System.Windows.Forms;

namespace QuizApp.Admin
{
    public partial class frmSignUp : Form
    {
        string Gender = "";
        string SPString;
        clsMainDB obj_ClsMainDB = new clsMainDB();
        clsStudent obj_Student = new clsStudent();
        DataTable DT = new DataTable();
        public frmSignUp()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int bornyear = dtpBirthday.Value.Year;
            int thisyear = DateTime.Now.Year;

            if (txtStudentName.Text.Trim() == "")
            {
                MessageBox.Show("Please Type Student Name!!");
                txtStudentName.Focus();
            }
            else if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Your confirm password should be same password!", "Password");

            }

            else if (thisyear - bornyear < 7 || thisyear - bornyear > 70)
            {
                MessageBox.Show("Student Age Must Between 10 and 70 Year.");
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
            else if ((rdoMale.Checked == false) && (rdoFemale.Checked == false))
            {
                MessageBox.Show("Please Choose Gender!!");
            }
            else if (txthnitanswer.Text == string.Empty)
            {
                MessageBox.Show("Please Type Your hnit Answer");
                txthnitanswer.Focus();
            }


            else
            {
                if (rdoMale.Checked)
                {
                    Gender = "Male";
                }
                if (rdoFemale.Checked)
                {
                    Gender = "Female";
                }

                SPString = string.Format("SP_Select_Student N'{0}',N'{1}',N'{2}'", txtNRC.Text, "0", "1");
                DT = obj_ClsMainDB.SelectData(SPString);
                if (DT.Rows.Count > 0)
                {

                    MessageBox.Show("This StudentName and NRC is Already Exist.");
                    txtNRC.Clear();
                    txtStudentName.Focus();
                    txtStudentName.SelectAll();

                }
                else
                {
                    obj_Student.STUDENTNAME = txtStudentName.Text;
                    obj_Student.STUDENTPASSWORD = txtPassword.Text;
                    obj_Student.NRC = txtNRC.Text;
                    obj_Student.UPDATE = DateTime.Now.ToLongTimeString();
                    MemoryStream stream = new MemoryStream();
                    picStudent.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                    byte[] pic = stream.ToArray();
                    obj_Student.SIMAGE = pic;
                    obj_Student.GENDER = Gender;
                    obj_Student.PHONE = txtPhone.Text;
                    obj_Student.Address = txtAddress.Text;
                    obj_Student.BDATE = dtpBirthday.Text;
                    obj_Student.Hnit = txthnit.Text;
                    obj_Student.HnitAnswer = txthnitanswer.Text;
                    obj_Student.ACTION = 0;
                    obj_Student.SaveData();
                    MessageBox.Show("Successfully Save", "Save");

                    this.Close();

                }
            }
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

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == 8 || e.KeyChar == 45)
            {
                e.Handled = false;
            }
            else
            {
                MessageBox.Show("Please Enter Number");
                e.Handled = true;
            }
        }

        private void rdoMale_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Male";
            rdoMale.ForeColor = Color.DarkBlue;
            rdoFemale.ForeColor = Color.Black;
        }

        private void rdoFemale_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Female";
            rdoMale.ForeColor = Color.Black;
            rdoFemale.ForeColor = Color.DarkBlue;
        }
        private void ClearData()
        {
            txtStudentName.Text = "";
            txtPassword.Text = "";
            txtStudentName.Focus();
            txtAddress.Text = "";
            txtNRC.Text = "";
            picStudent.Image = null;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
