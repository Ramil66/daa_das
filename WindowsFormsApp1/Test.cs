using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Курсовая.Design;

namespace WindowsFormsApp1
{
    public partial class Test : Form
    {

        List<string> questions_array=new List<string>();        //Массив вопросов
        List<string> answers_array = new List<string>();        //Массив вариантов ответа
        List<int> currect_answer_array = new List<int>();       //Массив правильных ответов
        int countAnswer = 12;                                   //Количество вопросов в тесте
        List<int> selected_answer_array = new List<int>();      //Массив выбранных пользователем ответов
        int selected_answer = 0;                                //Номер выбранного ответа
        int number_answer = 0;                                  //Номер вопроса
        private void read_file()
        {
            StreamReader stream = new StreamReader(@"test.txt");
            for(int i = 0; i < 12; i++)
            {
                questions_array.Add(stream.ReadLine());
                answers_array.Add(stream.ReadLine());
                answers_array.Add(stream.ReadLine());
                answers_array.Add(stream.ReadLine());
                answers_array.Add(stream.ReadLine());
                currect_answer_array.Add(Convert.ToInt16(stream.ReadLine()));
            }
        }
        public Test()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ShowQuestion()
        {
            question.Text = questions_array[number_answer];
            radioButton1.Text = answers_array[number_answer*4];
            radioButton2.Text = answers_array[number_answer * 4 + 1];
            radioButton3.Text = answers_array[number_answer * 4 + 2];
            radioButton4.Text = answers_array[number_answer * 4 + 3];
            if (selected_answer_array[number_answer] == 0)
            {
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;
            }
            if (selected_answer_array[number_answer] == 1)
                radioButton1.Checked = true;
            if (selected_answer_array[number_answer]==2)
                radioButton2.Checked = true;
            if (selected_answer_array[number_answer]==3)
                radioButton3.Checked = true;
            if (selected_answer_array[number_answer]==4)
                radioButton4.Checked = true;
        }
        private void roundButton_Starts_Click(object sender, EventArgs e)
        {
            read_file();
            string NameStudent = "", NumberStudent = "";
            NameStudent = name_student_textBox.Text;
            NumberStudent = number_student_textBox.Text;
            if (NameStudent.Length != 0 && NumberStudent.Length != 0&&Regex.IsMatch(NameStudent,@"\w")&&Regex.IsMatch(NumberStudent,@"\d"))
            {
                main_Panel.Controls.Remove(FIO);
                main_Panel.Controls.Remove(Number);
                main_Panel.Controls.Remove(name_student_textBox);
                main_Panel.Controls.Remove(number_student_textBox);
                roundButton_Starts.Visible = false;
                question.Visible = true;
                radioButton1.Visible = true;
                radioButton2.Visible = true;
                radioButton3.Visible = true;
                radioButton4.Visible = true;
                roundButton_next.Visible = true;
                roundButton_return.Visible = true;
                roundButton_return.Enabled = false;
                button_Tabs_Control.Enabled = false;
                roundButton_next.Location = new Point(970, 229);
                roundButton_next.Enabled = false;
                question.Location = new Point(140, 118);
                radioButton1.Location = new Point(261, 245);
                radioButton2.Location = new Point(261, 285);
                radioButton3.Location = new Point(261, 325);
                radioButton4.Location = new Point(261, 365);
                number_answer = 0;
                ShowQuestion();
            }
            if (roundButton_Starts.Text == "Завершить")
            {
                roundButton_return.Visible = false;
                roundButton_Starts.Text = "Заново";
                roundButton_Starts.Visible=true;
                roundButton_next.Visible = false;
                radioButton1.Visible = false;
                radioButton2.Visible = false;
                radioButton3.Visible = false;
                radioButton4.Visible = false;
                 int count_current_answers = 0;
                int grade = 0;
                for(int i = 0; i < countAnswer; i++)
                {
                    if (currect_answer_array[i] == selected_answer_array[i])
                        count_current_answers++;
                }
                if (count_current_answers / countAnswer < 1 / 2)
                    grade = 2;
                if (count_current_answers / countAnswer < 4 / 5)
                    grade = 3;
                if (count_current_answers / countAnswer < 1)
                    grade = 4;
                if (count_current_answers / countAnswer == 1)
                    grade = 5;
                StreamWriter stream = new StreamWriter("Grades.txt", true);
                stream.WriteLine("ФИО: " + NameStudent.ToString() + ". Номер зачетки: " + NumberStudent.ToString() + ". Оценка" + grade.ToString()
                    + "(" + count_current_answers.ToString() + "/" + countAnswer.ToString() + ")");
                stream.Close();
                question.Location = new Point(140, 180);
                question.Text = "Результат:\n\n";
                question.Text += NameStudent + "            " + grade.ToString() + " оценка(" + count_current_answers.ToString() + "/" + countAnswer.ToString() + ")";
            }
            else if(roundButton_Starts.Text == "Заново")
            {
                Test new_test_form = new Test();
                new_test_form.Show();
                this.Close();
            }
        }
        private void button_Tabs_Control_Click(object sender, EventArgs e)
        {
            Form backGround = new Form();
            using (Form1 tabsControl = new Form1())
            {
                backGround.StartPosition = FormStartPosition.Manual;
                backGround.FormBorderStyle = FormBorderStyle.None;
                backGround.Opacity = 0.5d;
                backGround.BackColor = Color.Black;
                backGround.Size = this.Size;
                backGround.Location = this.Location;
                backGround.ShowInTaskbar = false;
                backGround.Show();
                tabsControl.Owner = backGround;

                tabsControl.ShowDialog();
                backGround.Dispose();
            }
        }

        private void Test_Load(object sender, EventArgs e)
        {
            question.Visible = false;
            radioButton1.Visible = false;
            radioButton2.Visible = false;
            radioButton3.Visible = false;
            radioButton4.Visible = false;
            roundButton_next.Visible = false;
            roundButton_return.Visible = false;
            for(int i = 0; i < countAnswer; i++)
            {
                selected_answer_array.Add(0);
            }
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            selected_answer = 1;
            roundButton_next.Enabled = true;
            roundButton_Starts.Enabled = true;
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            selected_answer = 2;
            roundButton_next.Enabled = true;
            roundButton_Starts.Enabled = true;
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            selected_answer = 3;
            roundButton_next.Enabled = true;
            roundButton_Starts.Enabled = true;
        }
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            selected_answer = 4;
            roundButton_next.Enabled = true;
            roundButton_Starts.Enabled = true;
        }

        private void roundButton_next_Click(object sender, EventArgs e)
        {

            selected_answer_array[number_answer] = selected_answer;
            selected_answer = 0;
            number_answer++;
            ShowQuestion();
            if (selected_answer_array[number_answer] == 0)
                roundButton_next.Enabled = false;
            roundButton_return.Enabled = true;
            if (number_answer == countAnswer - 1)
            {
                roundButton_Starts.Visible = true;
                roundButton_next.Visible = false;
                roundButton_Starts.Text = "Завершить";
                roundButton_Starts.Enabled = false;
            }
        }
        private void roundButton_return_Click(object sender, EventArgs e)
        {
            number_answer--;
            if (number_answer == 0)
                roundButton_return.Enabled = false;
            if (roundButton_Starts.Text == "Завершить")
            {
                roundButton_next.Visible = true;
                roundButton_Starts.Visible = false;
                roundButton_Starts.Text = "Начать";
            }
            ShowQuestion();
        }
    }
}
