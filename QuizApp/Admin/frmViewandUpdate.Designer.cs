namespace QuizApp.Admin
{
    partial class frmViewandUpdate
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
            this.Panel = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cboCourse = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblCourse = new System.Windows.Forms.Label();
            this.dgvQuiz = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtCorrectAnswer = new System.Windows.Forms.TextBox();
            this.txtAnswer2 = new System.Windows.Forms.TextBox();
            this.txtAnswer3 = new System.Windows.Forms.TextBox();
            this.txtAnswer4 = new System.Windows.Forms.TextBox();
            this.txtAnswer1 = new System.Windows.Forms.TextBox();
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnResult = new System.Windows.Forms.Button();
            this.btnSetting = new System.Windows.Forms.Button();
            this.btnViewandUpdate = new System.Windows.Forms.Button();
            this.btnCreateQuiz = new System.Windows.Forms.Button();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.picLogo = new QuizApp.DBA.clspic();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnAbout = new System.Windows.Forms.Button();
            this.Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuiz)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel
            // 
            this.Panel.BackColor = System.Drawing.Color.SteelBlue;
            this.Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel.Controls.Add(this.btnSearch);
            this.Panel.Controls.Add(this.cboCourse);
            this.Panel.Controls.Add(this.label3);
            this.Panel.Controls.Add(this.label2);
            this.Panel.Controls.Add(this.button1);
            this.Panel.Controls.Add(this.lblCourse);
            this.Panel.Controls.Add(this.dgvQuiz);
            this.Panel.Controls.Add(this.btnDelete);
            this.Panel.Controls.Add(this.btnUpdate);
            this.Panel.Controls.Add(this.txtSearch);
            this.Panel.Controls.Add(this.txtCorrectAnswer);
            this.Panel.Controls.Add(this.txtAnswer2);
            this.Panel.Controls.Add(this.txtAnswer3);
            this.Panel.Controls.Add(this.txtAnswer4);
            this.Panel.Controls.Add(this.txtAnswer1);
            this.Panel.Controls.Add(this.txtQuestion);
            this.Panel.Location = new System.Drawing.Point(164, 0);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(991, 461);
            this.Panel.TabIndex = 12;
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(523, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(101, 34);
            this.btnSearch.TabIndex = 19;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cboCourse
            // 
            this.cboCourse.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cboCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCourse.FormattingEnabled = true;
            this.cboCourse.Location = new System.Drawing.Point(69, 10);
            this.cboCourse.Name = "cboCourse";
            this.cboCourse.Size = new System.Drawing.Size(157, 23);
            this.cboCourse.TabIndex = 18;
            this.cboCourse.SelectedIndexChanged += new System.EventHandler(this.cboCourse_SelectedIndexChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 18);
            this.label3.TabIndex = 17;
            this.label3.Text = "Course";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(245, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 18);
            this.label2.TabIndex = 17;
            this.label2.Text = "Search:";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(791, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 36);
            this.button1.TabIndex = 14;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblCourse
            // 
            this.lblCourse.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblCourse.Location = new System.Drawing.Point(658, 11);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(126, 21);
            this.lblCourse.TabIndex = 13;
            this.lblCourse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCourse.Click += new System.EventHandler(this.lblCourse_Click);
            // 
            // dgvQuiz
            // 
            this.dgvQuiz.AllowUserToAddRows = false;
            this.dgvQuiz.AllowUserToDeleteRows = false;
            this.dgvQuiz.AllowUserToResizeColumns = false;
            this.dgvQuiz.AllowUserToResizeRows = false;
            this.dgvQuiz.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQuiz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuiz.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvQuiz.Location = new System.Drawing.Point(0, 192);
            this.dgvQuiz.Name = "dgvQuiz";
            this.dgvQuiz.ReadOnly = true;
            this.dgvQuiz.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQuiz.Size = new System.Drawing.Size(989, 267);
            this.dgvQuiz.TabIndex = 12;
            this.dgvQuiz.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQuiz_CellContentClick);
            this.dgvQuiz.DoubleClick += new System.EventHandler(this.dgvQuiz_DoubleClick);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(709, 152);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 34);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(580, 152);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 34);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtSearch.Location = new System.Drawing.Point(329, 8);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(177, 27);
            this.txtSearch.TabIndex = 7;
            this.txtSearch.Click += new System.EventHandler(this.textBox1_Click);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // txtCorrectAnswer
            // 
            this.txtCorrectAnswer.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtCorrectAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorrectAnswer.Location = new System.Drawing.Point(315, 154);
            this.txtCorrectAnswer.Name = "txtCorrectAnswer";
            this.txtCorrectAnswer.Size = new System.Drawing.Size(167, 21);
            this.txtCorrectAnswer.TabIndex = 7;
            // 
            // txtAnswer2
            // 
            this.txtAnswer2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtAnswer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnswer2.Location = new System.Drawing.Point(204, 127);
            this.txtAnswer2.Name = "txtAnswer2";
            this.txtAnswer2.Size = new System.Drawing.Size(183, 21);
            this.txtAnswer2.TabIndex = 7;
            // 
            // txtAnswer3
            // 
            this.txtAnswer3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtAnswer3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnswer3.Location = new System.Drawing.Point(401, 127);
            this.txtAnswer3.Name = "txtAnswer3";
            this.txtAnswer3.Size = new System.Drawing.Size(183, 21);
            this.txtAnswer3.TabIndex = 7;
            // 
            // txtAnswer4
            // 
            this.txtAnswer4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtAnswer4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnswer4.Location = new System.Drawing.Point(598, 127);
            this.txtAnswer4.Name = "txtAnswer4";
            this.txtAnswer4.Size = new System.Drawing.Size(183, 21);
            this.txtAnswer4.TabIndex = 7;
            // 
            // txtAnswer1
            // 
            this.txtAnswer1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtAnswer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnswer1.Location = new System.Drawing.Point(7, 127);
            this.txtAnswer1.Multiline = true;
            this.txtAnswer1.Name = "txtAnswer1";
            this.txtAnswer1.Size = new System.Drawing.Size(183, 21);
            this.txtAnswer1.TabIndex = 7;
            // 
            // txtQuestion
            // 
            this.txtQuestion.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtQuestion.Location = new System.Drawing.Point(6, 48);
            this.txtQuestion.Multiline = true;
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.Size = new System.Drawing.Size(774, 73);
            this.txtQuestion.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnAbout);
            this.panel2.Controls.Add(this.btnLogout);
            this.panel2.Controls.Add(this.btnResult);
            this.panel2.Controls.Add(this.btnSetting);
            this.panel2.Controls.Add(this.btnViewandUpdate);
            this.panel2.Controls.Add(this.btnCreateQuiz);
            this.panel2.Controls.Add(this.btnAddStudent);
            this.panel2.Controls.Add(this.picLogo);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(1, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(164, 457);
            this.panel2.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 28);
            this.label1.TabIndex = 27;
            this.label1.Text = "ADMIN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Location = new System.Drawing.Point(-2, 344);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(176, 35);
            this.btnLogout.TabIndex = 22;
            this.btnLogout.Text = "&Log Out";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnResult
            // 
            this.btnResult.BackColor = System.Drawing.Color.Transparent;
            this.btnResult.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResult.Location = new System.Drawing.Point(-2, 246);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(176, 35);
            this.btnResult.TabIndex = 23;
            this.btnResult.Text = "&Student Result";
            this.btnResult.UseVisualStyleBackColor = false;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.BackColor = System.Drawing.Color.Transparent;
            this.btnSetting.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.Location = new System.Drawing.Point(-2, 280);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(176, 35);
            this.btnSetting.TabIndex = 23;
            this.btnSetting.Text = "&Setting";
            this.btnSetting.UseVisualStyleBackColor = false;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnViewandUpdate
            // 
            this.btnViewandUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnViewandUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnViewandUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewandUpdate.Location = new System.Drawing.Point(-2, 214);
            this.btnViewandUpdate.Name = "btnViewandUpdate";
            this.btnViewandUpdate.Size = new System.Drawing.Size(176, 35);
            this.btnViewandUpdate.TabIndex = 24;
            this.btnViewandUpdate.Text = "&View and Update";
            this.btnViewandUpdate.UseVisualStyleBackColor = false;
            this.btnViewandUpdate.Click += new System.EventHandler(this.btnViewandUpdate_Click);
            // 
            // btnCreateQuiz
            // 
            this.btnCreateQuiz.BackColor = System.Drawing.Color.Transparent;
            this.btnCreateQuiz.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCreateQuiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateQuiz.Location = new System.Drawing.Point(-2, 180);
            this.btnCreateQuiz.Name = "btnCreateQuiz";
            this.btnCreateQuiz.Size = new System.Drawing.Size(176, 35);
            this.btnCreateQuiz.TabIndex = 25;
            this.btnCreateQuiz.Text = "&Create Quiz";
            this.btnCreateQuiz.UseVisualStyleBackColor = false;
            this.btnCreateQuiz.Click += new System.EventHandler(this.btnCreateQuiz_Click);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.BackColor = System.Drawing.Color.Transparent;
            this.btnAddStudent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAddStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStudent.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnAddStudent.Location = new System.Drawing.Point(-2, 150);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(176, 35);
            this.btnAddStudent.TabIndex = 26;
            this.btnAddStudent.Text = "&StudentList";
            this.btnAddStudent.UseVisualStyleBackColor = false;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.Azure;
            this.picLogo.Image = global::QuizApp.Properties.Resources.Users_Administrator_icon;
            this.picLogo.Location = new System.Drawing.Point(30, 3);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(113, 110);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 3;
            this.picLogo.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.Color.Transparent;
            this.btnAbout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Location = new System.Drawing.Point(-2, 311);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(176, 35);
            this.btnAbout.TabIndex = 22;
            this.btnAbout.Text = "&About";
            this.btnAbout.UseVisualStyleBackColor = false;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // frmViewandUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 393);
            this.Controls.Add(this.Panel);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmViewandUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmViewandUpdate";
            this.Load += new System.EventHandler(this.frmViewandUpdate_Load);
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuiz)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtCorrectAnswer;
        private System.Windows.Forms.TextBox txtAnswer2;
        private System.Windows.Forms.TextBox txtAnswer3;
        private System.Windows.Forms.TextBox txtAnswer4;
        private System.Windows.Forms.TextBox txtAnswer1;
        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private DBA.clspic picLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Button btnViewandUpdate;
        private System.Windows.Forms.Button btnCreateQuiz;
        private System.Windows.Forms.Button btnAddStudent;
        public System.Windows.Forms.DataGridView dgvQuiz;
        private System.Windows.Forms.ComboBox cboCourse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.Button btnAbout;
    }
}