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
using WindowsFormsApp1.Properties;

namespace WindowsFormsApp1
{
    public partial class MainForms : Form
    {
        public MainForms()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void button3_Click(object sender, EventArgs e)
        {

        }
        public static int parentX, parentY;

        private void MainForms_Load(object sender, EventArgs e)
        {
            richTextBox1.LoadFile(@"Theory.rtf");
        }
        //Открытие формы для переходов между формами
        private void button1_Click(object sender, EventArgs e)
        {
            Form backGround = new Form();
            using (Form1 rulesForm = new Form1())
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

                parentX = this.Location.X;
                parentY = this.Location.Y;

                rulesForm.ShowDialog();
                backGround.Dispose();
            }
        }
    }
}
