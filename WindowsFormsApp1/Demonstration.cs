using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Demonstration : Form
    {
        public Demonstration()
        {
            InitializeComponent();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Demonstration_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("DAA");
            comboBox1.Items.Add("DAS");
            comboBox1.SelectedIndex = 0;
            pictureBox_Arow.SendToBack();
        }
        int number1 = 0, number2 = 0;
        bool stage_one = true, stage_two = false, stage_three = false, stage_four = false;
        string highPart, lowPart;
        private void roundButton1_Click(object sender, EventArgs e)
        {
            ShowRegister("00000000");
            textBox_Flags_AF.Text = "0";
            textBox_Flags_CF.Text = "0";
            label_Actions_Register.Text = "";
            stage_one = true;
            stage_two = false;
            stage_three = false;
            stage_four = false;
            try
            {
                number1 = Convert.ToInt16(textBox_number1.Text);
                number2 = Convert.ToInt16(textBox_number2.Text);
                richTextBox_assembler.Text = ".686\r\n.model FLAT, C\r\n.code";
                richTextBox_assembler.Text += "\n\n\n\n\nmov AL, " + number1.ToString();
                if (comboBox1.SelectedIndex == 0)
                {
                    richTextBox_assembler.Text += "\nadd AL, " + number2.ToString();
                    richTextBox_assembler.Text += "\ndaa";
                }
                else
                {
                    richTextBox_assembler.Text += "\nsub AL, " + number2.ToString();
                    richTextBox_assembler.Text += "\ndas";
                }
                pictureBox_Arow.Location = new Point(828, 443);
                richTextBox_assembler.Text += "\n\n\n\nEND";
                ShowNumberRegister(number1);
                timer1.Enabled = true;
            }
            catch { }
        }
        //Вывод двоичного числа в регистр
        private void ShowRegister(string binaryNumber)
        {
            textBox8.Text = binaryNumber[binaryNumber.Length - 1].ToString();
            textBox7.Text = binaryNumber[binaryNumber.Length - 2].ToString();
            textBox6.Text = binaryNumber[binaryNumber.Length - 3].ToString();
            textBox5.Text = binaryNumber[binaryNumber.Length - 4].ToString();
            textBox4.Text = binaryNumber[binaryNumber.Length - 5].ToString();
            textBox3.Text = binaryNumber[binaryNumber.Length - 6].ToString();
            textBox2.Text = binaryNumber[binaryNumber.Length - 7].ToString();
            textBox1.Text = binaryNumber[binaryNumber.Length - 8].ToString();
        }
        //Вывод десятичного числа в регистр
        private void ShowNumberRegister(int number)
        {
            int partNumber = 0;
            string binaryPartNumber,binaryNumber;
            partNumber = (number / 10) % 10;
            binaryPartNumber = Convert.ToString(partNumber, 2);
            while (binaryPartNumber.Length < 4)
            {
                binaryPartNumber = "0" + binaryPartNumber;
            }
            binaryNumber = binaryPartNumber;
            partNumber = number % 10;
            binaryPartNumber = Convert.ToString(partNumber, 2);
            while (binaryPartNumber.Length < 4)
            {
                binaryPartNumber = "0" + binaryPartNumber;
            }
            binaryNumber += binaryPartNumber;
            ShowRegister(binaryNumber);
        }
        //Визуализация команды ADD процессора 
        private void ShowSumRegister(int number1,int number2)
        {
            string number1_str, number2_str, tempPartBinaryNumber ;
            number1_str = Convert.ToString((number1 / 10) % 10, 2);
            while (number1_str.Length < 4)
            {
                number1_str = "0" + number1_str;
            }
            tempPartBinaryNumber= Convert.ToString(number1 % 10, 2);
            while (tempPartBinaryNumber.Length < 4)
            {
                tempPartBinaryNumber = "0" + tempPartBinaryNumber;
            }
            number1_str += tempPartBinaryNumber;
            number2_str = Convert.ToString((number2 / 10) % 10, 2);
            while (number2_str.Length < 4)
            {
                number2_str = "0" + number2_str;
            }
            tempPartBinaryNumber = Convert.ToString(number2 % 10, 2);
            while (tempPartBinaryNumber.Length < 4)
            {
                tempPartBinaryNumber = "0" + tempPartBinaryNumber;
            }
            number2_str += tempPartBinaryNumber;
            string result = Convert.ToString(Convert.ToInt32(number1_str, 2) + Convert.ToInt64(number2_str, 2), 2);
            while (result.Length < 8)
            { 
                result = "0" + result;
            }
            if (result.Length > 8) {
                result = result.Substring(result.Length - 8, 8);
                textBox_Flags_CF.Text = "1";
            }
            highPart =result.Substring(0, 4);
            lowPart = result.Substring(4, 4);
            if (Convert.ToInt32(lowPart,2) >= Convert.ToInt32("1010",2)) {
                textBox_Flags_AF.Text = "1";
            }
            if (Convert.ToInt32(highPart, 2) >= Convert.ToInt32("1010", 2))
            {
                textBox_Flags_CF.Text = "1";
            }
            ShowRegister(result);
        }
        //Визуализация команды SUB процессора 
        private void ShowDifRegister(int number1, int number2)
        {
            string number1_str, number2_str, tempPartBinaryNumber;
            number1_str = Convert.ToString((number1 / 10) % 10, 2);
            while (number1_str.Length < 4)
            {
                number1_str = "0" + number1_str;
            }
            tempPartBinaryNumber = Convert.ToString(number1 % 10, 2);
            while (tempPartBinaryNumber.Length < 4)
            {
                tempPartBinaryNumber = "0" + tempPartBinaryNumber;
            }
            number1_str += tempPartBinaryNumber;
            number2_str = Convert.ToString((number2 / 10) % 10, 2);
            while (number2_str.Length < 4)
            {
                number2_str = "0" + number2_str;
            }
            tempPartBinaryNumber = Convert.ToString(number2 % 10, 2);
            while (tempPartBinaryNumber.Length < 4)
            {
                tempPartBinaryNumber = "0" + tempPartBinaryNumber;
            }
            number2_str += tempPartBinaryNumber;
            string result = Convert.ToString(Convert.ToInt32(number1_str, 2) - Convert.ToInt32(number2_str, 2), 2);
            while (result.Length < 8)
            {
                result = "0" + result;
            }
            if (result.Length > 8)
            {
                result = result.Substring(result.Length - 8, 8);
                textBox_Flags_CF.Text = "1";
            }
            highPart = result.Substring(0, 4);
            lowPart = result.Substring(4, 4);
            if (Convert.ToInt32(lowPart, 2) >= Convert.ToInt32("1010", 2))
            {
                textBox_Flags_AF.Text = "1";
            }
            if (Convert.ToInt32(highPart, 2) >= Convert.ToInt32("1010", 2))
            {
                textBox_Flags_CF.Text = "1";
            }
            ShowRegister(result);
        }
        //Функция для прибавления 6 числу в регистре AL
        private void SixLowPart()
        {
            string tempBinaryNumber = highPart + lowPart;
            if (comboBox1.SelectedIndex == 0)
                tempBinaryNumber = Convert.ToString(Convert.ToInt32(tempBinaryNumber, 2) + Convert.ToInt32("110", 2), 2);
            else
                tempBinaryNumber = Convert.ToString(Convert.ToInt32(tempBinaryNumber, 2) - Convert.ToInt32("110", 2), 2);
            while (tempBinaryNumber.Length < 8)
            {
                tempBinaryNumber = "0" + tempBinaryNumber;
            }
            if (tempBinaryNumber.Length > 8)
            {
                tempBinaryNumber = tempBinaryNumber.Substring(tempBinaryNumber.Length - 8, 8);
                textBox_Flags_CF.Text = "1";
            }
            highPart = tempBinaryNumber.Substring(0, 4);
            lowPart = tempBinaryNumber.Substring(4, 4);
            ShowRegister(tempBinaryNumber);
        }
        //Функция для прибавления 60 числу в регистре AL
        private void SixtyHighPart()
        {
            string tempBinaryNumber = highPart + lowPart;
            if (comboBox1.SelectedIndex == 0)
                tempBinaryNumber = Convert.ToString(Convert.ToInt32(tempBinaryNumber, 2) + Convert.ToInt32("1100000", 2), 2);
            else
                tempBinaryNumber = Convert.ToString(Convert.ToInt32(tempBinaryNumber, 2) - Convert.ToInt32("1100000", 2), 2);
            while (tempBinaryNumber.Length < 8)
            {
                tempBinaryNumber = "0" + tempBinaryNumber;
            }
            if (tempBinaryNumber.Length > 8)
            {
                tempBinaryNumber = tempBinaryNumber.Substring(tempBinaryNumber.Length - 8, 8);
            }
            highPart = tempBinaryNumber.Substring(0, 4);
            lowPart = tempBinaryNumber.Substring(4, 4);
            ShowRegister(tempBinaryNumber);
        }
        //Таймер для визуализации работы регистра
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (stage_one)
            {
                pictureBox_Arow.Location = new Point(828, 458);
                if (comboBox1.SelectedIndex == 0)
                {
                    ShowSumRegister(number1, number2);
                    label_Actions_Register.Text = "+" + number2.ToString();
                }
                if (comboBox1.SelectedIndex == 1)
                {
                    ShowDifRegister(number1, number2);
                    label_Actions_Register.Text = "-" + number2.ToString();
                }
                stage_one = false;
                if (textBox_Flags_AF.Text == "0" && textBox_Flags_CF.Text == "0")
                {
                    stage_four = true;
                }
                else
                {
                    stage_two = true;
                }
            }
            else if (stage_two)
            {
                pictureBox_Arow.Location = new Point(828, 473);
                if (textBox_Flags_AF.Text == "1")
                {
                    label_Actions_Register.Text = "+6";
                    SixLowPart();
                    textBox_Flags_AF.Text = "0";
                }
                if (Convert.ToInt32(highPart, 2) >= Convert.ToInt32("1010", 2))
                {
                    textBox_Flags_CF.Text = "1";
                }
                stage_two = false;
                if (textBox_Flags_AF.Text == "0" && textBox_Flags_CF.Text == "0")
                {
                    stage_four = true;
                }
                else
                {
                    stage_three = true;
                }
            }
            else if (stage_three)
            {
                label_Actions_Register.Text = "+60";
                SixtyHighPart();
                textBox_Flags_CF.Text = "0";
                stage_three = false;
                stage_four = true;
            }
            else
            {
                pictureBox_Arow.Location = new Point(828, 539);
                if (number1 - number2 > 0 || comboBox1.SelectedIndex == 0)
                    label_Actions_Register.Text = "=" + Convert.ToInt32(highPart, 2) + Convert.ToInt32(lowPart, 2);
                else if (number1 == number2)
                    label_Actions_Register.Text = "=0";
                else
                    label_Actions_Register.Text = "=" + (100 - Convert.ToInt32(highPart, 2) * 10 - Convert.ToInt32(lowPart, 2)).ToString();

                timer1.Enabled = false;
            }
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

                rulesForm.ShowDialog();
                backGround.Dispose();
            }
        }
    }
}
