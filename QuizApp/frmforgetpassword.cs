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
using System.Data.SqlClient;


namespace QuizApp
{
    
    public partial class frmforgetpassword : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=WINDOWS-C6RB5G6\KMS;Initial Catalog=QuizApplication;User ID=sa;Password=kmsoe1998");
        string SPString;
        DataTable DT = new DataTable();
        clsMainDB obj_clsMainDB = new clsMainDB();
        int _StudentID = 0;
        bool chkadmin;
        int _AdminID = 0;
        

        public frmforgetpassword()
        {
            InitializeComponent();
        }

        private void btnExist_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void admin()
        {
            if (txtpassword.Visible == false)
            {
                SPString = string.Format("SP_Select_Admin N'{0}',N'{1}',N'{2}'", txthnitanswer.Text, "0", "3");
                DT = obj_clsMainDB.SelectData(SPString);
                if(DT.Rows.Count>0)
                {

                _AdminID = Convert.ToInt32(DT.Rows[0]["AdminID"].ToString());
                lblpassword.Visible = true;
                txtpassword.Visible = true;
                lblpassword.Text="Password";
                btnChange.Text = "Change";
                chk.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Your Admin Name is not correct","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            else if(btnChange.Text=="Change")
            {
                SqlCommand cmd = new SqlCommand(@"Update Admin set AdminName='" + txthnitanswer.Text + "',Password='" + txtpassword.Text + "' where AdminID ='" + _AdminID + "'", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfully Save", "Save");
                this.Close();
            }
        }  


        private void btnChange_Click(object sender, EventArgs e)
        {
           
            if(btnChange.Text=="Show hnit")
            { //fro admin
             
                //txtnrc.Text = "";
               
                if (chkadmin)
                {
                    admin();
                }
                else
                {
                   
                    
                    //txthnitanswer represent txtphone
                    //txtpassword represent txtnrc
                    SPString = string.Format("SP_Select_Student N'{0}',N'{1}',N'{2}'", txthnitanswer.Text, txtnrc.Text, "9");
                    DT = obj_clsMainDB.SelectData(SPString);

                    if (DT.Rows.Count > 0)
                    {

                        
                       // lblh.Text = "Your hnit";
                        lblName.Visible = true;
                       // lblN.Text = "Name";
                        lblhanswer.Text = "Hnit Answer";
                        //lblpassword.Text = "Password";
                        lblpassword.Visible = true;
                       // label.Visible = false;
                        btnChange.Text = "Change";
                        lblName.Text = DT.Rows[0]["StudentName"].ToString();
                        lblhnit.Text = DT.Rows[0]["hnit"].ToString();
                        // clear/////
                        txthnitanswer.Text = "";
                        txtpassword.Text = "";
                        txtpassword.Visible = true;
                        lblpassword.Visible = true;
                        txtnrc.Visible = false;
                        lblh.Visible = true;
                        lblN.Visible = true;
                        lblnrc.Visible = false;
                        chk.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Check your phone number and NRC", "Warnning");
                        txthnitanswer.Focus();
                        //txthnitanswer represent txtphone
                    }
                }
            }
            else if (btnChange.Text == "Change")
            {
                if (chkadmin)
                {
                    admin();
                }
                else
                {
                SPString = string.Format("SP_Select_Student N'{0}',N'{1}',N'{2}'", txthnitanswer.Text,"0","10");
                DT = obj_clsMainDB.SelectData(SPString);
                //update password
               _StudentID=Convert.ToInt32( DT.Rows[0]["StudentID"].ToString());
                //for check your hnitanswer
                string hnitanswer = DT.Rows[0]["hnitanswer"].ToString();
                if (txthnitanswer.Text.Trim() == hnitanswer)
                {
                    SqlCommand cmd = new SqlCommand(@"Update Student set Password='" + txtpassword.Text + "' where StudentID ='" + _StudentID + "'", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Successully Save", "Save");
                    btnChange.Text = "Show hnit";
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Check your hnit", "Check Data");
                    txthnitanswer.Focus();
                }
            }
            }
        
        }

        private void frmforgetpassword_Load(object sender, EventArgs e)
        {
            lblN.Visible = false;
            lblh.Visible = false;
            lblName.Text = "";
            lblhnit.Text = "";
            lblhanswer.Text = "Phone Number";
            txtpassword.Visible = false;
            txtnrc.Visible = true;
           // lblpassword.Text = "NRC";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chk.Checked == true)
            {
                lblpassword.Visible = false;
                txtpassword.Visible = false;
                lblhanswer.Text = "Name";
                //lblpassword.Text = "New Password";
                txtnrc.Visible = false;
                lblnrc.Visible = false;
                chkadmin = true;
            }
            else
            {
                lblpassword.Visible = false;
                lblnrc.Visible = true;
                txtpassword.Visible = true;
                lblhanswer.Text = "hnit Answer  :";
            }
        }
    }
}
