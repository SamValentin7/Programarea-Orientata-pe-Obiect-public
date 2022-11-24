using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock
{
    public partial class Intro : Form
    {
        public Intro()
        {
            InitializeComponent();
        }

        int progress_value = 0;
        private void Intro_Load(object sender, EventArgs e)
        {
            bunifuCircleProgressbar1.IsAccessible = true;
            bunifuCircleProgressbar1.animated = false;
            bunifuCircleProgressbar1.Value = 0;

            timer1.Enabled = true;
            timer1.Interval = 100;
            timer1.Tick += timer1_Tick;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(progress_value < 101)
            {
                bunifuCircleProgressbar1.Value = progress_value;
                progress_value += 1;
            }
            else
            {
                timer1.Enabled = false;
                this.Hide();
                Login Obj = new Login();
                Obj.Show();
            }
        }

        
    }
}
