namespace QuizApp.Admin
{
    partial class frmResult
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnResult = new System.Windows.Forms.Button();
            this.picLogo = new QuizApp.DBA.clspic();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnSetting = new System.Windows.Forms.Button();
            this.btnViewandUpdate = new System.Windows.Forms.Button();
            this.btnCreateQuiz = new System.Windows.Forms.Button();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cboCourseName = new System.Windows.Forms.ComboBox();
            this.lblPoint = new System.Windows.Forms.Label();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.picStudent = new System.Windows.Forms.PictureBox();
            this.button6 = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.dgvResult = new System.Windows.Forms.DataGridView();
            this.btnAbout = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnResult);
            this.panel2.Controls.Add(this.picLogo);
            this.panel2.Controls.Add(this.btnAbout);
            this.panel2.Controls.Add(this.btnLogout);
            this.panel2.Controls.Add(this.btnSetting);
            this.panel2.Controls.Add(this.btnViewandUpdate);
            this.panel2.Controls.Add(this.btnCreateQuiz);
            this.panel2.Controls.Add(this.btnAddStudent);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(164, 393);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 28);
            this.label1.TabIndex = 22;
            this.label1.Text = "ADMIN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnResult
            // 
            this.btnResult.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResult.Location = new System.Drawing.Point(-6, 245);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(172, 35);
            this.btnResult.TabIndex = 0;
            this.btnResult.Text = "&Student Result";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.Azure;
            this.picLogo.Image = global::QuizApp.Properties.Resources.Users_Administrator_icon;
            this.picLogo.Location = new System.Drawing.Point(24, 3);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(113, 110);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 2;
            this.picLogo.TabStop = false;
            // 
            // btnLogout
            // 
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Location = new System.Drawing.Point(-6, 345);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(172, 35);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "&Log Out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.Location = new System.Drawing.Point(-6, 279);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(172, 35);
            this.btnSetting.TabIndex = 0;
            this.btnSetting.Text = "&Setting";
            this.btnSetting.UseVisualStyleBackColor = true;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnViewandUpdate
            // 
            this.btnViewandUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnViewandUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewandUpdate.Location = new System.Drawing.Point(-6, 213);
            this.btnViewandUpdate.Name = "btnViewandUpdate";
            this.btnViewandUpdate.Size = new System.Drawing.Size(172, 35);
            this.btnViewandUpdate.TabIndex = 0;
            this.btnViewandUpdate.Text = "&View and Update";
            this.btnViewandUpdate.UseVisualStyleBackColor = true;
            this.btnViewandUpdate.Click += new System.EventHandler(this.btnViewandUpdate_Click);
            // 
            // btnCreateQuiz
            // 
            this.btnCreateQuiz.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCreateQuiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateQuiz.Location = new System.Drawing.Point(-6, 179);
            this.btnCreateQuiz.Name = "btnCreateQuiz";
            this.btnCreateQuiz.Size = new System.Drawing.Size(172, 35);
            this.btnCreateQuiz.TabIndex = 0;
            this.btnCreateQuiz.Text = "&Create Quiz";
            this.btnCreateQuiz.UseVisualStyleBackColor = true;
            this.btnCreateQuiz.Click += new System.EventHandler(this.btnCreateQuiz_Click);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAddStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStudent.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnAddStudent.Location = new System.Drawing.Point(-6, 149);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(172, 35);
            this.btnAddStudent.TabIndex = 0;
            this.btnAddStudent.Text = "&StudentList";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cboCourseName);
            this.panel1.Controls.Add(this.lblPoint);
            this.panel1.Controls.Add(this.lblStudentName);
            this.panel1.Controls.Add(this.picStudent);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.btnRemove);
            this.panel1.Controls.Add(this.dgvResult);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(164, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(788, 393);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(499, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 16);
            this.label2.TabIndex = 61;
            this.label2.Text = "CourseName :";
            // 
            // cboCourseName
            // 
            this.cboCourseName.FormattingEnabled = true;
            this.cboCourseName.Location = new System.Drawing.Point(610, 79);
            this.cboCourseName.Name = "cboCourseName";
            this.cboCourseName.Size = new System.Drawing.Size(151, 21);
            this.cboCourseName.TabIndex = 60;
            this.cboCourseName.SelectedIndexChanged += new System.EventHandler(this.cboCourseName_SelectedIndexChanged);
            // 
            // lblPoint
            // 
            this.lblPoint.BackColor = System.Drawing.Color.Transparent;
            this.lblPoint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPoint.Location = new System.Drawing.Point(129, 58);
            this.lblPoint.Name = "lblPoint";
            this.lblPoint.Size = new System.Drawing.Size(171, 33);
            this.lblPoint.TabIndex = 59;
            this.lblPoint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPoint.Click += new System.EventHandler(this.lblPoint_Click);
            // 
            // lblStudentName
            // 
            this.lblStudentName.BackColor = System.Drawing.Color.Transparent;
            this.lblStudentName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblStudentName.Location = new System.Drawing.Point(129, 15);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(171, 33);
            this.lblStudentName.TabIndex = 59;
            this.lblStudentName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picStudent
            // 
            this.picStudent.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.picStudent.Location = new System.Drawing.Point(5, 15);
            this.picStudent.Name = "picStudent";
            this.picStudent.Size = new System.Drawing.Size(118, 121);
            this.picStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picStudent.TabIndex = 10;
            this.picStudent.TabStop = false;
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(750, -1);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(37, 36);
            this.button6.TabIndex = 6;
            this.button6.Text = "X";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(808, 98);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 34);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.Text = "&Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // dgvResult
            // 
            this.dgvResult.AllowUserToAddRows = false;
            this.dgvResult.AllowUserToDeleteRows = false;
            this.dgvResult.AllowUserToResizeColumns = false;
            this.dgvResult.AllowUserToResizeRows = false;
            this.dgvResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResult.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvResult.Location = new System.Drawing.Point(0, 167);
            this.dgvResult.Name = "dgvResult";
            this.dgvResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResult.Size = new System.Drawing.Size(786, 224);
            this.dgvResult.TabIndex = 58;
            this.dgvResult.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResult_CellClick);
            // 
            // btnAbout
            // 
            this.btnAbout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Location = new System.Drawing.Point(-6, 311);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(172, 35);
            this.btnAbout.TabIndex = 0;
            this.btnAbout.Text = "&About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // frmResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 393);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmResult";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmResult";
            this.Load += new System.EventHandler(this.frmResult_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnResult;
        private DBA.clspic picLogo;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Button btnViewandUpdate;
        private System.Windows.Forms.Button btnCreateQuiz;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.PictureBox picStudent;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnRemove;
        public System.Windows.Forms.DataGridView dgvResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboCourseName;
        private System.Windows.Forms.Label lblPoint;
        private System.Windows.Forms.Button btnAbout;
    }
}