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
using QuizApp.Admin;
using System.Threading;
using QuizApp.Student;

namespace QuizApp
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            //Thread t = new Thread(new ThreadStart(formRun));
            //t.Start();
            //Thread.Sleep(3000);

            InitializeComponent();
            //t.Abort();
        }

        private void formRun()
        {
            //Application.Run(new frm_Splash());
        }

        

        


        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            clsMainDB obj_clsMainDB = new clsMainDB();
            DataTable DT = new DataTable();
            //frmMain obj_frmMain = new frmMain();
            //String UserName = "";
            //String Password = "";


            //txtUserName.Text = UserName;
            //txtPassword.Text = Password;
            

            if (txtUserName.Text.Trim().ToString() == string.Empty)
            {
                MessageBox.Show("Please Type User Name");
                txtUserName.Focus();
                return;

            }
            //UserName = txtUserName.Text;
            if (txtPassword.Text.Trim().ToString() == string.Empty)
            {
                MessageBox.Show("Please Type Password");
                txtPassword.Focus();
                return;
            }
            try
            {

                //Password = txtPassword.Text;
                string SPString = string.Format("SP_Select_Admin N'{0}',N'{1}',N'{2}'",
                    txtUserName.Text.Trim().ToString(), txtPassword.Text.Trim().ToString(), "0");
                DT = obj_clsMainDB.SelectData(SPString);
                int count = DT.Rows.Count;
                if (count == 1)
                {
                    //MessageBox.Show("Login Successful");
                    this.Hide();
                     Program.AdminID=Convert.ToInt32(DT.Rows[0]["AdminID"].ToString());
                    new frmAdmin().Show();
                   


                }
                else
                {
                    MessageBox.Show("Login Failed!");
                    txtUserName.Text = "";
                    txtPassword.Text = "";
                    txtUserName.Focus();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
        }

        private void btnLogIn_Click_2(object sender, EventArgs e)
        {
            clsMainDB obj_clsMainDB = new clsMainDB();
            DataTable DT = new DataTable();
            //frmMain obj_frmMain = new frmMain();





            if (txtUserName.Text.Trim().ToString() == string.Empty)
            {
                MessageBox.Show("Please Type User Name");
                txtUserName.Focus();
                return;

            }

            if (txtPassword.Text.Trim().ToString() == string.Empty)
            {
                MessageBox.Show("Please Type Password");
                txtPassword.Focus();
                return;
            }
            try
            {


                string SPString = string.Format("SP_Select_Student'{0}',N'{1}',N'{2}'",
                    txtUserName.Text.Trim().ToString(), txtPassword.Text.Trim().ToString(), "5");
                DT = obj_clsMainDB.SelectData(SPString);
                int count = DT.Rows.Count;
                if (count == 1)
                {
                    //MessageBox.Show("Login Successful");
                    this.Hide();
                    Program.StudentID = Convert.ToInt32(DT.Rows[0]["StudentID"].ToString());
                    new frmTestList().Show();



                }
                else
                {
                    MessageBox.Show("Login Failed!");
                    txtUserName.Text = "";
                    txtPassword.Text = "";
                    txtUserName.Focus();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            txtUserName.Focus();
            txtUserName.Text = "";
             txtPassword.Text = "";
             

        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void lblforgetpassword_Click(object sender, EventArgs e)
        {
            frmforgetpassword frm = new frmforgetpassword();
            frm.ShowDialog();
        }

        private void btnSginUp_Click(object sender, EventArgs e)
        {
            frmSignUp frm = new frmSignUp();
            frm.ShowDialog();
        }

        private void btnforget_Click(object sender, EventArgs e)
        {
            frmforgetpassword frm = new frmforgetpassword();
            frm.ShowDialog();
        }
    }
}
