namespace QuizApp.Student
{
    partial class frmTestList
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTestList));
            this.xuiGradientPanel1 = new XanderUI.XUIGradientPanel();
            this.btnExist = new System.Windows.Forms.Button();
            this.panelslide = new System.Windows.Forms.Panel();
            this.btnTest = new XanderUI.XUISuperButton();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.btnRank = new XanderUI.XUISuperButton();
            this.btnResult = new XanderUI.XUISuperButton();
            this.btnLogout = new XanderUI.XUISuperButton();
            this.btnAbout = new XanderUI.XUISuperButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panMain = new System.Windows.Forms.Panel();
            this.btnStartQuiz = new System.Windows.Forms.Button();
            this.lblCourse = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lable = new System.Windows.Forms.Label();
            this.picCourse = new System.Windows.Forms.PictureBox();
            this.dgvTestList = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.picStudent = new QuizApp.DBA.clspic();
            this.xuiGradientPanel1.SuspendLayout();
            this.panelslide.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCourse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // xuiGradientPanel1
            // 
            this.xuiGradientPanel1.BottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.xuiGradientPanel1.BottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.xuiGradientPanel1.Controls.Add(this.btnExist);
            this.xuiGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.xuiGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.xuiGradientPanel1.Name = "xuiGradientPanel1";
            this.xuiGradientPanel1.PrimerColor = System.Drawing.Color.White;
            this.xuiGradientPanel1.Size = new System.Drawing.Size(858, 38);
            this.xuiGradientPanel1.Style = XanderUI.XUIGradientPanel.GradientStyle.Corners;
            this.xuiGradientPanel1.TabIndex = 1;
            this.xuiGradientPanel1.TopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.xuiGradientPanel1.TopRight = System.Drawing.Color.Blue;
            // 
            // btnExist
            // 
            this.btnExist.BackColor = System.Drawing.Color.Transparent;
            this.btnExist.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExist.FlatAppearance.BorderSize = 0;
            this.btnExist.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnExist.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnExist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExist.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExist.ForeColor = System.Drawing.Color.Red;
            this.btnExist.Location = new System.Drawing.Point(821, 0);
            this.btnExist.Name = "btnExist";
            this.btnExist.Size = new System.Drawing.Size(37, 38);
            this.btnExist.TabIndex = 15;
            this.btnExist.Text = "X";
            this.btnExist.UseVisualStyleBackColor = false;
            this.btnExist.Click += new System.EventHandler(this.btnExist_Click);
            // 
            // panelslide
            // 
            this.panelslide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.panelslide.Controls.Add(this.btnTest);
            this.panelslide.Controls.Add(this.lblStudentName);
            this.panelslide.Controls.Add(this.picStudent);
            this.panelslide.Controls.Add(this.btnRank);
            this.panelslide.Controls.Add(this.btnResult);
            this.panelslide.Controls.Add(this.btnLogout);
            this.panelslide.Controls.Add(this.btnAbout);
            this.panelslide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelslide.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelslide.Location = new System.Drawing.Point(0, 38);
            this.panelslide.Name = "panelslide";
            this.panelslide.Size = new System.Drawing.Size(180, 430);
            this.panelslide.TabIndex = 2;
            // 
            // btnTest
            // 
            this.btnTest.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnTest.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnTest.ButtonImage")));
            this.btnTest.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.btnTest.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.btnTest.ButtonText = "Test";
            this.btnTest.CornerRadius = 5;
            this.btnTest.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnTest.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnTest.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(217)))), ((int)(((byte)(174)))));
            this.btnTest.HoverTextColor = System.Drawing.Color.White;
            this.btnTest.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.btnTest.Location = new System.Drawing.Point(0, 223);
            this.btnTest.Name = "btnTest";
            this.btnTest.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.btnTest.SelectedTextColor = System.Drawing.Color.White;
            this.btnTest.Size = new System.Drawing.Size(180, 40);
            this.btnTest.SuperSelected = false;
            this.btnTest.TabIndex = 5;
            this.btnTest.TextColor = System.Drawing.Color.White;
            this.btnTest.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // lblStudentName
            // 
            this.lblStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentName.ForeColor = System.Drawing.Color.Teal;
            this.lblStudentName.Location = new System.Drawing.Point(3, 133);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(174, 32);
            this.lblStudentName.TabIndex = 4;
            this.lblStudentName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblStudentName.Click += new System.EventHandler(this.lblStudentName_Click);
            // 
            // btnRank
            // 
            this.btnRank.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnRank.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnRank.ButtonImage")));
            this.btnRank.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.Default;
            this.btnRank.ButtonStyle = XanderUI.XUISuperButton.Style.Flat;
            this.btnRank.ButtonText = "Rank";
            this.btnRank.CornerRadius = 5;
            this.btnRank.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnRank.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnRank.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(217)))), ((int)(((byte)(174)))));
            this.btnRank.HoverTextColor = System.Drawing.Color.White;
            this.btnRank.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.btnRank.Location = new System.Drawing.Point(0, 263);
            this.btnRank.Name = "btnRank";
            this.btnRank.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.btnRank.SelectedTextColor = System.Drawing.Color.White;
            this.btnRank.Size = new System.Drawing.Size(180, 40);
            this.btnRank.SuperSelected = false;
            this.btnRank.TabIndex = 2;
            this.btnRank.TextColor = System.Drawing.Color.White;
            this.btnRank.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnRank.Click += new System.EventHandler(this.btnRank_Click);
            // 
            // btnResult
            // 
            this.btnResult.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnResult.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnResult.ButtonImage")));
            this.btnResult.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.Default;
            this.btnResult.ButtonStyle = XanderUI.XUISuperButton.Style.Flat;
            this.btnResult.ButtonText = "Result";
            this.btnResult.CornerRadius = 5;
            this.btnResult.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnResult.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnResult.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(217)))), ((int)(((byte)(174)))));
            this.btnResult.HoverTextColor = System.Drawing.Color.White;
            this.btnResult.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.btnResult.Location = new System.Drawing.Point(0, 303);
            this.btnResult.Name = "btnResult";
            this.btnResult.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.btnResult.SelectedTextColor = System.Drawing.Color.White;
            this.btnResult.Size = new System.Drawing.Size(180, 40);
            this.btnResult.SuperSelected = false;
            this.btnResult.TabIndex = 2;
            this.btnResult.TextColor = System.Drawing.Color.White;
            this.btnResult.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnLogout.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnLogout.ButtonImage")));
            this.btnLogout.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.btnLogout.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.btnLogout.ButtonText = "Log Out";
            this.btnLogout.CornerRadius = 5;
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnLogout.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(217)))), ((int)(((byte)(174)))));
            this.btnLogout.HoverTextColor = System.Drawing.Color.White;
            this.btnLogout.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.btnLogout.Location = new System.Drawing.Point(0, 343);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.btnLogout.SelectedTextColor = System.Drawing.Color.White;
            this.btnLogout.Size = new System.Drawing.Size(180, 42);
            this.btnLogout.SuperSelected = false;
            this.btnLogout.TabIndex = 1;
            this.btnLogout.TextColor = System.Drawing.Color.White;
            this.btnLogout.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnAbout.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnAbout.ButtonImage")));
            this.btnAbout.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.btnAbout.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.btnAbout.ButtonText = "About";
            this.btnAbout.CornerRadius = 5;
            this.btnAbout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAbout.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnAbout.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(217)))), ((int)(((byte)(174)))));
            this.btnAbout.HoverTextColor = System.Drawing.Color.White;
            this.btnAbout.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.btnAbout.Location = new System.Drawing.Point(0, 385);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.SelectedBackColor = System.Drawing.Color.Transparent;
            this.btnAbout.SelectedTextColor = System.Drawing.Color.White;
            this.btnAbout.Size = new System.Drawing.Size(180, 45);
            this.btnAbout.SuperSelected = false;
            this.btnAbout.TabIndex = 0;
            this.btnAbout.TextColor = System.Drawing.Color.White;
            this.btnAbout.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(180, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(44, 430);
            this.panel2.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panMain
            // 
            this.panMain.BackColor = System.Drawing.Color.White;
            this.panMain.Controls.Add(this.btnStartQuiz);
            this.panMain.Controls.Add(this.lblCourse);
            this.panMain.Controls.Add(this.lblTotal);
            this.panMain.Controls.Add(this.lable);
            this.panMain.Controls.Add(this.picCourse);
            this.panMain.Controls.Add(this.dgvTestList);
            this.panMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panMain.Location = new System.Drawing.Point(224, 38);
            this.panMain.Name = "panMain";
            this.panMain.Size = new System.Drawing.Size(634, 430);
            this.panMain.TabIndex = 5;
            this.panMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panMain_Paint);
            // 
            // btnStartQuiz
            // 
            this.btnStartQuiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartQuiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartQuiz.Location = new System.Drawing.Point(509, 122);
            this.btnStartQuiz.Name = "btnStartQuiz";
            this.btnStartQuiz.Size = new System.Drawing.Size(113, 27);
            this.btnStartQuiz.TabIndex = 30;
            this.btnStartQuiz.Text = "&StartQuiz";
            this.btnStartQuiz.UseVisualStyleBackColor = true;
            this.btnStartQuiz.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblCourse
            // 
            this.lblCourse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCourse.Font = new System.Drawing.Font("Microsoft YaHei", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourse.Location = new System.Drawing.Point(133, 16);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(105, 37);
            this.lblCourse.TabIndex = 12;
            this.lblCourse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(96)))), ((int)(((byte)(100)))));
            this.lblTotal.Location = new System.Drawing.Point(183, 97);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 19);
            this.lblTotal.TabIndex = 12;
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lable
            // 
            this.lable.AutoSize = true;
            this.lable.Font = new System.Drawing.Font("Microsoft YaHei", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable.Location = new System.Drawing.Point(129, 78);
            this.lable.Name = "lable";
            this.lable.Size = new System.Drawing.Size(109, 19);
            this.lable.TabIndex = 12;
            this.lable.Text = "Enrollment Total";
            // 
            // picCourse
            // 
            this.picCourse.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.picCourse.Location = new System.Drawing.Point(6, 16);
            this.picCourse.Name = "picCourse";
            this.picCourse.Size = new System.Drawing.Size(118, 121);
            this.picCourse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCourse.TabIndex = 11;
            this.picCourse.TabStop = false;
            // 
            // dgvTestList
            // 
            this.dgvTestList.AllowUserToAddRows = false;
            this.dgvTestList.AllowUserToDeleteRows = false;
            this.dgvTestList.AllowUserToResizeColumns = false;
            this.dgvTestList.AllowUserToResizeRows = false;
            this.dgvTestList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTestList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTestList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTestList.Location = new System.Drawing.Point(0, 155);
            this.dgvTestList.Name = "dgvTestList";
            this.dgvTestList.ReadOnly = true;
            this.dgvTestList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTestList.Size = new System.Drawing.Size(634, 275);
            this.dgvTestList.TabIndex = 0;
            this.dgvTestList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTestList_CellClick);
            this.dgvTestList.DoubleClick += new System.EventHandler(this.dgvTestList_DoubleClick);
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // picStudent
            // 
            this.picStudent.Location = new System.Drawing.Point(19, 2);
            this.picStudent.Name = "picStudent";
            this.picStudent.Size = new System.Drawing.Size(143, 120);
            this.picStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picStudent.TabIndex = 3;
            this.picStudent.TabStop = false;
            this.picStudent.Click += new System.EventHandler(this.picStudent_Click);
            // 
            // frmTestList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 468);
            this.Controls.Add(this.panMain);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelslide);
            this.Controls.Add(this.xuiGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTestList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmTestList";
            this.Load += new System.EventHandler(this.frmTestList_Load);
            this.xuiGradientPanel1.ResumeLayout(false);
            this.panelslide.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panMain.ResumeLayout(false);
            this.panMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCourse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStudent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private XanderUI.XUIGradientPanel xuiGradientPanel1;
        private System.Windows.Forms.Panel panelslide;
        private XanderUI.XUISuperButton btnTest;
        private System.Windows.Forms.Label lblStudentName;
        private DBA.clspic picStudent;
        private XanderUI.XUISuperButton btnRank;
        private XanderUI.XUISuperButton btnResult;
        private XanderUI.XUISuperButton btnLogout;
        private XanderUI.XUISuperButton btnAbout;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panMain;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnExist;
        private System.Windows.Forms.DataGridView dgvTestList;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.Label lable;
        private System.Windows.Forms.PictureBox picCourse;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnStartQuiz;
    }
}