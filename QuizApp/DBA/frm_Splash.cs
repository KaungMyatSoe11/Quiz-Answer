using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizApp.DBA
{
    public partial class frm_Splash : Form
    {
        public frm_Splash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panels.Width += 4;
            if (panels.Width > 500)
            {
                panels.Width = 0;
            }
            if (panels.Width < 0)
            {
                move = 3;
            }
        }

        public int move { get; set; }

        private void frm_Splash_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
