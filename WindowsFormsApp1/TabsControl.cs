using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Location = new Point(MainForms.parentX, MainForms.parentY+25);
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

        private void button3_Click(object sender, EventArgs e)
        {
            Form testingForms = new Test();
            testingForms.Show();
            this.Close();
            Form Close_Form = Application.OpenForms[1];
            Form First_Form = Application.OpenForms[0];
            Close_Form.Close();
            First_Form.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form theoryForms = new MainForms();
            theoryForms.Show();
            this.Close();
            Form Close_Form = Application.OpenForms[1];
            Form First_Form = Application.OpenForms[0];
            Close_Form.Close();
            First_Form.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form demonstration_Forms = new Demonstration();
            demonstration_Forms.Show();
            this.Close();     
            Form Close_Form = Application.OpenForms[1];
            Form First_Form = Application.OpenForms[0];
            Close_Form.Close();
            First_Form.Hide();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Form backGround = new Form();
            using (AboutProgramm rulesForm = new AboutProgramm())
            {
                backGround.StartPosition = FormStartPosition.Manual;
                backGround.FormBorderStyle = FormBorderStyle.None;
                backGround.Opacity = 0.5d;
                backGround.BackColor = Color.Black;
                backGround.Size = this.Size;
                backGround.Location = this.Location;
                backGround.ShowInTaskbar = false;
                backGround.Show();
                rulesForm.Owner = backGround;

                rulesForm.ShowDialog();
                backGround.Dispose();
            }
        }
    }
}
