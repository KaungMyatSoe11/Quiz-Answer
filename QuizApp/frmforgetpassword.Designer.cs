namespace QuizApp
{
    partial class frmforgetpassword
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lblN = new System.Windows.Forms.Label();
            this.lblh = new System.Windows.Forms.Label();
            this.lblhanswer = new System.Windows.Forms.Label();
            this.lblpassword = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.txthnitanswer = new System.Windows.Forms.TextBox();
            this.lblhnit = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chk = new System.Windows.Forms.CheckBox();
            this.lblnrc = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnExist = new System.Windows.Forms.Button();
            this.txtnrc = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(193, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Forget Password";
            // 
            // lblN
            // 
            this.lblN.AutoSize = true;
            this.lblN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblN.Location = new System.Drawing.Point(122, 81);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(57, 16);
            this.lblN.TabIndex = 1;
            this.lblN.Text = "Name :";
            // 
            // lblh
            // 
            this.lblh.AutoSize = true;
            this.lblh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblh.Location = new System.Drawing.Point(101, 146);
            this.lblh.Name = "lblh";
            this.lblh.Size = new System.Drawing.Size(78, 16);
            this.lblh.TabIndex = 1;
            this.lblh.Text = "your hnit  :";
            // 
            // lblhanswer
            // 
            this.lblhanswer.AutoSize = true;
            this.lblhanswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhanswer.Location = new System.Drawing.Point(51, 33);
            this.lblhanswer.Name = "lblhanswer";
            this.lblhanswer.Size = new System.Drawing.Size(98, 16);
            this.lblhanswer.TabIndex = 1;
            this.lblhanswer.Text = "hnit Answer  :";
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpassword.Location = new System.Drawing.Point(31, 90);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(118, 16);
            this.lblpassword.TabIndex = 1;
            this.lblpassword.Text = "New Password :";
            this.lblpassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblpassword.Visible = false;
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(167, 87);
            this.txtpassword.Multiline = true;
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(204, 24);
            this.txtpassword.TabIndex = 2;
            this.txtpassword.Visible = false;
            // 
            // txthnitanswer
            // 
            this.txthnitanswer.Location = new System.Drawing.Point(167, 25);
            this.txthnitanswer.Multiline = true;
            this.txthnitanswer.Name = "txthnitanswer";
            this.txthnitanswer.Size = new System.Drawing.Size(204, 24);
            this.txthnitanswer.TabIndex = 2;
            // 
            // lblhnit
            // 
            this.lblhnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhnit.Location = new System.Drawing.Point(198, 146);
            this.lblhnit.Name = "lblhnit";
            this.lblhnit.Size = new System.Drawing.Size(207, 41);
            this.lblhnit.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtnrc);
            this.groupBox1.Controls.Add(this.chk);
            this.groupBox1.Controls.Add(this.lblhanswer);
            this.groupBox1.Controls.Add(this.txtpassword);
            this.groupBox1.Controls.Add(this.txthnitanswer);
            this.groupBox1.Controls.Add(this.lblnrc);
            this.groupBox1.Controls.Add(this.lblpassword);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox1.Location = new System.Drawing.Point(34, 190);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(398, 141);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "fill Data";
            // 
            // chk
            // 
            this.chk.AutoSize = true;
            this.chk.Location = new System.Drawing.Point(233, 115);
            this.chk.Name = "chk";
            this.chk.Size = new System.Drawing.Size(70, 20);
            this.chk.TabIndex = 3;
            this.chk.Text = "Admin";
            this.chk.UseVisualStyleBackColor = true;
            this.chk.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // lblnrc
            // 
            this.lblnrc.AutoSize = true;
            this.lblnrc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnrc.Location = new System.Drawing.Point(97, 90);
            this.lblnrc.Name = "lblnrc";
            this.lblnrc.Size = new System.Drawing.Size(48, 16);
            this.lblnrc.TabIndex = 1;
            this.lblnrc.Text = "NRC :";
            this.lblnrc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(198, 81);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(207, 41);
            this.lblName.TabIndex = 1;
            // 
            // btnChange
            // 
            this.btnChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChange.Location = new System.Drawing.Point(150, 337);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(162, 27);
            this.btnChange.TabIndex = 31;
            this.btnChange.Text = "Show hnit";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnExist
            // 
            this.btnExist.BackColor = System.Drawing.Color.Transparent;
            this.btnExist.FlatAppearance.BorderSize = 0;
            this.btnExist.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnExist.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnExist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExist.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExist.Location = new System.Drawing.Point(496, -2);
            this.btnExist.Name = "btnExist";
            this.btnExist.Size = new System.Drawing.Size(37, 38);
            this.btnExist.TabIndex = 32;
            this.btnExist.Text = "X";
            this.btnExist.UseVisualStyleBackColor = false;
            this.btnExist.Click += new System.EventHandler(this.btnExist_Click);
            // 
            // txtnrc
            // 
            this.txtnrc.Location = new System.Drawing.Point(167, 87);
            this.txtnrc.Multiline = true;
            this.txtnrc.Name = "txtnrc";
            this.txtnrc.Size = new System.Drawing.Size(204, 24);
            this.txtnrc.TabIndex = 4;
            // 
            // frmforgetpassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(166)))), ((int)(((byte)(177)))));
            this.ClientSize = new System.Drawing.Size(533, 376);
            this.Controls.Add(this.lblN);
            this.Controls.Add(this.lblh);
            this.Controls.Add(this.btnExist);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblhnit);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(6)))), ((int)(((byte)(51)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmforgetpassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmforgetpassword";
            this.Load += new System.EventHandler(this.frmforgetpassword_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblN;
        private System.Windows.Forms.Label lblh;
        private System.Windows.Forms.Label lblhanswer;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.TextBox txthnitanswer;
        private System.Windows.Forms.Label lblhnit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnExist;
        private System.Windows.Forms.CheckBox chk;
        private System.Windows.Forms.Label lblnrc;
        private System.Windows.Forms.TextBox txtnrc;
    }
}