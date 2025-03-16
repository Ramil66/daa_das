using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AboutProgramm : Form
    {
        public AboutProgramm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Opacity >= 1)
            {
                timer1.Stop();
            }
            else
            {
                Opacity += 0.03d;
            }
        }
        private void AboutProgramm_Load(object sender, EventArgs e)
        {
            this.Location = new Point(MainForms.parentX+150, MainForms.parentY+100);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
