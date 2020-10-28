namespace QuizApp.Student
{
    partial class frmRank
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRank));
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
            this.cboCourseName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvRank = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.xuiGradientPanel1.SuspendLayout();
            this.panelslide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStudent)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRank)).BeginInit();
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
            // picStudent
            // 
            this.picStudent.Location = new System.Drawing.Point(19, 6);
            this.picStudent.Name = "picStudent";
            this.picStudent.Size = new System.Drawing.Size(143, 120);
            this.picStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picStudent.TabIndex = 3;
            this.picStudent.TabStop = false;
            this.picStudent.Click += new System.EventHandler(this.picStudent_Click);
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
            this.panel2.TabIndex = 4;
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
            // cboCourseName
            // 
            this.cboCourseName.FormattingEnabled = true;
            this.cboCourseName.Location = new System.Drawing.Point(338, 42);
            this.cboCourseName.Name = "cboCourseName";
            this.cboCourseName.Size = new System.Drawing.Size(151, 21);
            this.cboCourseName.TabIndex = 5;
            this.cboCourseName.SelectedIndexChanged += new System.EventHandler(this.cboCourseName_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(227, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "CourseName :";
            // 
            // dgvRank
            // 
            this.dgvRank.AllowUserToAddRows = false;
            this.dgvRank.AllowUserToDeleteRows = false;
            this.dgvRank.AllowUserToResizeColumns = false;
            this.dgvRank.AllowUserToResizeRows = false;
            this.dgvRank.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRank.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRank.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvRank.Location = new System.Drawing.Point(224, 171);
            this.dgvRank.Name = "dgvRank";
            this.dgvRank.ReadOnly = true;
            this.dgvRank.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRank.Size = new System.Drawing.Size(634, 297);
            this.dgvRank.TabIndex = 7;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmRank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 468);
            this.Controls.Add(this.dgvRank);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboCourseName);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelslide);
            this.Controls.Add(this.xuiGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRank";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmResult";
            this.Load += new System.EventHandler(this.frmRank_Load);
            this.xuiGradientPanel1.ResumeLayout(false);
            this.panelslide.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picStudent)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRank)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private XanderUI.XUIGradientPanel xuiGradientPanel1;
        private System.Windows.Forms.Button btnExist;
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
        private System.Windows.Forms.ComboBox cboCourseName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvRank;
        private System.Windows.Forms.Timer timer1;

    }
}