namespace QuizApp.Student
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmResult));
            this.xuiGradientPanel1 = new XanderUI.XUIGradientPanel();
            this.btnExist = new System.Windows.Forms.Button();
            this.panelslide = new System.Windows.Forms.Panel();
            this.btnTest = new XanderUI.XUISuperButton();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.picStudent = new QuizApp.DBA.clspic();
            this.btnRank = new XanderUI.XUISuperButton();
            this.btnResult = new XanderUI.XUISuperButton();
            this.btnLogout = new XanderUI.XUISuperButton();
            this.btnAbout = new XanderUI.XUISuperButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pancourse3 = new System.Windows.Forms.Panel();
            this.picCourse3 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblPoint3 = new System.Windows.Forms.Label();
            this.lblCourse3 = new System.Windows.Forms.Label();
            this.pancourse2 = new System.Windows.Forms.Panel();
            this.picCourse2 = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblPoint2 = new System.Windows.Forms.Label();
            this.lblCourse2 = new System.Windows.Forms.Label();
            this.pancourse1 = new System.Windows.Forms.Panel();
            this.picCourse1 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblPoint1 = new System.Windows.Forms.Label();
            this.lblCourseName1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dgvResultList = new System.Windows.Forms.DataGridView();
            this.xuiGradientPanel1.SuspendLayout();
            this.panelslide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStudent)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.pancourse3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCourse3)).BeginInit();
            this.panel4.SuspendLayout();
            this.pancourse2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCourse2)).BeginInit();
            this.panel6.SuspendLayout();
            this.pancourse1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCourse1)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultList)).BeginInit();
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
            this.xuiGradientPanel1.TabIndex = 0;
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
            this.panelslide.TabIndex = 1;
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
            // picStudent
            // 
            this.picStudent.Location = new System.Drawing.Point(19, 6);
            this.picStudent.Name = "picStudent";
            this.picStudent.Size = new System.Drawing.Size(143, 120);
            this.picStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picStudent.TabIndex = 3;
            this.picStudent.TabStop = false;
            this.picStudent.Click += new System.EventHandler(this.clspic1_Click);
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
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(180, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(38, 430);
            this.panel2.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pancourse3);
            this.panel3.Controls.Add(this.pancourse2);
            this.panel3.Controls.Add(this.pancourse1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(218, 38);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(640, 154);
            this.panel3.TabIndex = 3;
            // 
            // pancourse3
            // 
            this.pancourse3.Controls.Add(this.picCourse3);
            this.pancourse3.Controls.Add(this.panel4);
            this.pancourse3.Location = new System.Drawing.Point(448, 6);
            this.pancourse3.Name = "pancourse3";
            this.pancourse3.Size = new System.Drawing.Size(131, 137);
            this.pancourse3.TabIndex = 0;
            // 
            // picCourse3
            // 
            this.picCourse3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picCourse3.ErrorImage = null;
            this.picCourse3.Location = new System.Drawing.Point(0, 0);
            this.picCourse3.Name = "picCourse3";
            this.picCourse3.Size = new System.Drawing.Size(131, 102);
            this.picCourse3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCourse3.TabIndex = 2;
            this.picCourse3.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblPoint3);
            this.panel4.Controls.Add(this.lblCourse3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 102);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(131, 35);
            this.panel4.TabIndex = 1;
            // 
            // lblPoint3
            // 
            this.lblPoint3.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoint3.Location = new System.Drawing.Point(45, 19);
            this.lblPoint3.Name = "lblPoint3";
            this.lblPoint3.Size = new System.Drawing.Size(38, 15);
            this.lblPoint3.TabIndex = 1;
            this.lblPoint3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCourse3
            // 
            this.lblCourse3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCourse3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCourse3.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourse3.Location = new System.Drawing.Point(0, 0);
            this.lblCourse3.Name = "lblCourse3";
            this.lblCourse3.Size = new System.Drawing.Size(131, 35);
            this.lblCourse3.TabIndex = 0;
            this.lblCourse3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pancourse2
            // 
            this.pancourse2.Controls.Add(this.picCourse2);
            this.pancourse2.Controls.Add(this.panel6);
            this.pancourse2.Location = new System.Drawing.Point(242, 6);
            this.pancourse2.Name = "pancourse2";
            this.pancourse2.Size = new System.Drawing.Size(131, 137);
            this.pancourse2.TabIndex = 0;
            // 
            // picCourse2
            // 
            this.picCourse2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picCourse2.ErrorImage = null;
            this.picCourse2.Location = new System.Drawing.Point(0, 0);
            this.picCourse2.Name = "picCourse2";
            this.picCourse2.Size = new System.Drawing.Size(131, 102);
            this.picCourse2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCourse2.TabIndex = 2;
            this.picCourse2.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.lblPoint2);
            this.panel6.Controls.Add(this.lblCourse2);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 102);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(131, 35);
            this.panel6.TabIndex = 1;
            // 
            // lblPoint2
            // 
            this.lblPoint2.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoint2.Location = new System.Drawing.Point(45, 19);
            this.lblPoint2.Name = "lblPoint2";
            this.lblPoint2.Size = new System.Drawing.Size(38, 15);
            this.lblPoint2.TabIndex = 1;
            this.lblPoint2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCourse2
            // 
            this.lblCourse2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCourse2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCourse2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourse2.Location = new System.Drawing.Point(0, 0);
            this.lblCourse2.Name = "lblCourse2";
            this.lblCourse2.Size = new System.Drawing.Size(131, 35);
            this.lblCourse2.TabIndex = 0;
            this.lblCourse2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pancourse1
            // 
            this.pancourse1.Controls.Add(this.picCourse1);
            this.pancourse1.Controls.Add(this.panel5);
            this.pancourse1.Location = new System.Drawing.Point(27, 6);
            this.pancourse1.Name = "pancourse1";
            this.pancourse1.Size = new System.Drawing.Size(131, 136);
            this.pancourse1.TabIndex = 0;
            // 
            // picCourse1
            // 
            this.picCourse1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picCourse1.ErrorImage = null;
            this.picCourse1.Location = new System.Drawing.Point(0, 0);
            this.picCourse1.Name = "picCourse1";
            this.picCourse1.Size = new System.Drawing.Size(131, 101);
            this.picCourse1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCourse1.TabIndex = 2;
            this.picCourse1.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lblPoint1);
            this.panel5.Controls.Add(this.lblCourseName1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 101);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(131, 35);
            this.panel5.TabIndex = 1;
            // 
            // lblPoint1
            // 
            this.lblPoint1.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoint1.Location = new System.Drawing.Point(45, 19);
            this.lblPoint1.Name = "lblPoint1";
            this.lblPoint1.Size = new System.Drawing.Size(38, 15);
            this.lblPoint1.TabIndex = 1;
            this.lblPoint1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCourseName1
            // 
            this.lblCourseName1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCourseName1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCourseName1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseName1.Location = new System.Drawing.Point(0, 0);
            this.lblCourseName1.Name = "lblCourseName1";
            this.lblCourseName1.Size = new System.Drawing.Size(131, 35);
            this.lblCourseName1.TabIndex = 0;
            this.lblCourseName1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dgvResultList
            // 
            this.dgvResultList.AllowUserToAddRows = false;
            this.dgvResultList.AllowUserToDeleteRows = false;
            this.dgvResultList.AllowUserToResizeColumns = false;
            this.dgvResultList.AllowUserToResizeRows = false;
            this.dgvResultList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResultList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvResultList.Location = new System.Drawing.Point(218, 192);
            this.dgvResultList.Name = "dgvResultList";
            this.dgvResultList.Size = new System.Drawing.Size(640, 276);
            this.dgvResultList.TabIndex = 4;
            // 
            // frmResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 468);
            this.Controls.Add(this.dgvResultList);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelslide);
            this.Controls.Add(this.xuiGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmResult";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "StudentHome";
            this.Load += new System.EventHandler(this.frmStudentHome_Load);
            this.xuiGradientPanel1.ResumeLayout(false);
            this.panelslide.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picStudent)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.pancourse3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCourse3)).EndInit();
            this.panel4.ResumeLayout(false);
            this.pancourse2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCourse2)).EndInit();
            this.panel6.ResumeLayout(false);
            this.pancourse1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCourse1)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private XanderUI.XUIGradientPanel xuiGradientPanel1;
        private System.Windows.Forms.Panel panelslide;
        private XanderUI.XUISuperButton btnLogout;
        private XanderUI.XUISuperButton btnAbout;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private XanderUI.XUISuperButton btnRank;
        private DBA.clspic picStudent;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Timer timer1;
        private XanderUI.XUISuperButton btnTest;
        private System.Windows.Forms.Button btnExist;
        private System.Windows.Forms.Panel pancourse3;
        private System.Windows.Forms.PictureBox picCourse3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblPoint3;
        private System.Windows.Forms.Label lblCourse3;
        private System.Windows.Forms.Panel pancourse2;
        private System.Windows.Forms.PictureBox picCourse2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblPoint2;
        private System.Windows.Forms.Label lblCourse2;
        private System.Windows.Forms.Panel pancourse1;
        private System.Windows.Forms.PictureBox picCourse1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblPoint1;
        private System.Windows.Forms.Label lblCourseName1;
        private System.Windows.Forms.DataGridView dgvResultList;
        private XanderUI.XUISuperButton btnResult;
    }
}