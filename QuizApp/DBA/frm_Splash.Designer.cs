namespace QuizApp.DBA
{
    partial class frm_Splash
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
            this.xuiGradientPanel1 = new XanderUI.XUIGradientPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panels = new XanderUI.XUIGradientPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.xuiGradientPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // xuiGradientPanel1
            // 
            this.xuiGradientPanel1.BottomLeft = System.Drawing.Color.DodgerBlue;
            this.xuiGradientPanel1.BottomRight = System.Drawing.Color.Navy;
            this.xuiGradientPanel1.Controls.Add(this.panel1);
            this.xuiGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xuiGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.xuiGradientPanel1.Name = "xuiGradientPanel1";
            this.xuiGradientPanel1.PrimerColor = System.Drawing.Color.White;
            this.xuiGradientPanel1.Size = new System.Drawing.Size(783, 483);
            this.xuiGradientPanel1.Style = XanderUI.XUIGradientPanel.GradientStyle.Corners;
            this.xuiGradientPanel1.TabIndex = 0;
            this.xuiGradientPanel1.TopLeft = System.Drawing.SystemColors.MenuHighlight;
            this.xuiGradientPanel1.TopRight = System.Drawing.Color.SteelBlue;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panels);
            this.panel1.Location = new System.Drawing.Point(157, 319);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(473, 10);
            this.panel1.TabIndex = 0;
            // 
            // panels
            // 
            this.panels.BottomLeft = System.Drawing.Color.Navy;
            this.panels.BottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panels.Location = new System.Drawing.Point(-1, 0);
            this.panels.Name = "panels";
            this.panels.PrimerColor = System.Drawing.Color.White;
            this.panels.Size = new System.Drawing.Size(181, 12);
            this.panels.Style = XanderUI.XUIGradientPanel.GradientStyle.Corners;
            this.panels.TabIndex = 1;
            this.panels.TopLeft = System.Drawing.Color.DeepSkyBlue;
            this.panels.TopRight = System.Drawing.Color.DeepSkyBlue;
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frm_Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 483);
            this.Controls.Add(this.xuiGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Splash";
            this.Text = "frm_Splash";
            this.Load += new System.EventHandler(this.frm_Splash_Load);
            this.xuiGradientPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private XanderUI.XUIGradientPanel xuiGradientPanel1;
        private System.Windows.Forms.Panel panel1;
        private XanderUI.XUIGradientPanel panels;
        private System.Windows.Forms.Timer timer1;

    }
}