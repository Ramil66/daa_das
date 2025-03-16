namespace WindowsFormsApp1
{
    partial class Test
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Test));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button_Tabs_Control = new System.Windows.Forms.Button();
            this.main_Panel = new System.Windows.Forms.Panel();
            this.roundButton_next = new Курсовая.Design.RoundButton();
            this.roundButton_return = new Курсовая.Design.RoundButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.question = new System.Windows.Forms.Label();
            this.roundButton_Starts = new Курсовая.Design.RoundButton();
            this.Number = new System.Windows.Forms.Label();
            this.FIO = new System.Windows.Forms.Label();
            this.number_student_textBox = new System.Windows.Forms.TextBox();
            this.name_student_textBox = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2.SuspendLayout();
            this.main_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1200, 25);
            this.panel2.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Montserrat ExtraBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Команды процессора DAA, DAS";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Black;
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.Dock = System.Windows.Forms.DockStyle.Right;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Montserrat ExtraBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(1160, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(40, 25);
            this.button5.TabIndex = 5;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button_Tabs_Control
            // 
            this.button_Tabs_Control.BackColor = System.Drawing.Color.White;
            this.button_Tabs_Control.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.free_icon_menu_18288591;
            this.button_Tabs_Control.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Tabs_Control.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Tabs_Control.ForeColor = System.Drawing.Color.White;
            this.button_Tabs_Control.Location = new System.Drawing.Point(5, 35);
            this.button_Tabs_Control.Name = "button_Tabs_Control";
            this.button_Tabs_Control.Size = new System.Drawing.Size(30, 25);
            this.button_Tabs_Control.TabIndex = 13;
            this.button_Tabs_Control.UseVisualStyleBackColor = false;
            this.button_Tabs_Control.Click += new System.EventHandler(this.button_Tabs_Control_Click);
            // 
            // main_Panel
            // 
            this.main_Panel.BackColor = System.Drawing.Color.White;
            this.main_Panel.Controls.Add(this.roundButton_next);
            this.main_Panel.Controls.Add(this.roundButton_return);
            this.main_Panel.Controls.Add(this.radioButton4);
            this.main_Panel.Controls.Add(this.radioButton3);
            this.main_Panel.Controls.Add(this.radioButton2);
            this.main_Panel.Controls.Add(this.radioButton1);
            this.main_Panel.Controls.Add(this.question);
            this.main_Panel.Controls.Add(this.roundButton_Starts);
            this.main_Panel.Controls.Add(this.Number);
            this.main_Panel.Controls.Add(this.FIO);
            this.main_Panel.Controls.Add(this.number_student_textBox);
            this.main_Panel.Controls.Add(this.name_student_textBox);
            this.main_Panel.Location = new System.Drawing.Point(41, 31);
            this.main_Panel.Name = "main_Panel";
            this.main_Panel.Size = new System.Drawing.Size(1147, 657);
            this.main_Panel.TabIndex = 14;
            // 
            // roundButton_next
            // 
            this.roundButton_next.BackColor = System.Drawing.Color.White;
            this.roundButton_next.ColorPen = System.Drawing.Color.Transparent;
            this.roundButton_next.FlatAppearance.BorderSize = 0;
            this.roundButton_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton_next.Font = new System.Drawing.Font("Arial Narrow", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roundButton_next.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.roundButton_next.Location = new System.Drawing.Point(525, 424);
            this.roundButton_next.Name = "roundButton_next";
            this.roundButton_next.RoundingEnable = true;
            this.roundButton_next.Size = new System.Drawing.Size(150, 150);
            this.roundButton_next.TabIndex = 11;
            this.roundButton_next.Text = ">";
            this.roundButton_next.UseVisualStyleBackColor = false;
            this.roundButton_next.Click += new System.EventHandler(this.roundButton_next_Click);
            // 
            // roundButton_return
            // 
            this.roundButton_return.BackColor = System.Drawing.Color.White;
            this.roundButton_return.ColorPen = System.Drawing.Color.Transparent;
            this.roundButton_return.FlatAppearance.BorderSize = 0;
            this.roundButton_return.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton_return.Font = new System.Drawing.Font("Arial Narrow", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roundButton_return.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.roundButton_return.Location = new System.Drawing.Point(22, 229);
            this.roundButton_return.Name = "roundButton_return";
            this.roundButton_return.RoundingEnable = true;
            this.roundButton_return.Size = new System.Drawing.Size(150, 150);
            this.roundButton_return.TabIndex = 10;
            this.roundButton_return.Text = "<";
            this.roundButton_return.UseVisualStyleBackColor = false;
            this.roundButton_return.Click += new System.EventHandler(this.roundButton_return_Click);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton4.Location = new System.Drawing.Point(195, 525);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(162, 30);
            this.radioButton4.TabIndex = 9;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "radioButton4";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton3.Location = new System.Drawing.Point(200, 493);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(160, 30);
            this.radioButton3.TabIndex = 8;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton2.Location = new System.Drawing.Point(200, 469);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(160, 30);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton1.Location = new System.Drawing.Point(200, 437);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(156, 30);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // question
            // 
            this.question.AutoSize = true;
            this.question.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.question.Location = new System.Drawing.Point(255, 118);
            this.question.Name = "question";
            this.question.Size = new System.Drawing.Size(0, 33);
            this.question.TabIndex = 5;
            // 
            // roundButton_Starts
            // 
            this.roundButton_Starts.BackColor = System.Drawing.Color.White;
            this.roundButton_Starts.ColorPen = System.Drawing.Color.Transparent;
            this.roundButton_Starts.FlatAppearance.BorderSize = 0;
            this.roundButton_Starts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton_Starts.Font = new System.Drawing.Font("Montserrat ExtraBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roundButton_Starts.ForeColor = System.Drawing.Color.Black;
            this.roundButton_Starts.Location = new System.Drawing.Point(970, 229);
            this.roundButton_Starts.Name = "roundButton_Starts";
            this.roundButton_Starts.RoundingEnable = true;
            this.roundButton_Starts.Size = new System.Drawing.Size(150, 150);
            this.roundButton_Starts.TabIndex = 4;
            this.roundButton_Starts.Text = "Начать";
            this.roundButton_Starts.UseVisualStyleBackColor = false;
            this.roundButton_Starts.Click += new System.EventHandler(this.roundButton_Starts_Click);
            // 
            // Number
            // 
            this.Number.AutoSize = true;
            this.Number.Font = new System.Drawing.Font("Montserrat ExtraBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Number.Location = new System.Drawing.Point(231, 324);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(310, 29);
            this.Number.TabIndex = 3;
            this.Number.Text = "Номер зачетной книжки:";
            // 
            // FIO
            // 
            this.FIO.AutoSize = true;
            this.FIO.Font = new System.Drawing.Font("Montserrat ExtraBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FIO.Location = new System.Drawing.Point(231, 255);
            this.FIO.Name = "FIO";
            this.FIO.Size = new System.Drawing.Size(188, 29);
            this.FIO.TabIndex = 2;
            this.FIO.Text = "ФИО Студента:";
            // 
            // number_student_textBox
            // 
            this.number_student_textBox.Font = new System.Drawing.Font("Montserrat ExtraBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.number_student_textBox.Location = new System.Drawing.Point(547, 324);
            this.number_student_textBox.Name = "number_student_textBox";
            this.number_student_textBox.Size = new System.Drawing.Size(329, 33);
            this.number_student_textBox.TabIndex = 1;
            // 
            // name_student_textBox
            // 
            this.name_student_textBox.Font = new System.Drawing.Font("Montserrat ExtraBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name_student_textBox.Location = new System.Drawing.Point(547, 255);
            this.name_student_textBox.Name = "name_student_textBox";
            this.name_student_textBox.Size = new System.Drawing.Size(329, 33);
            this.name_student_textBox.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.main_Panel);
            this.Controls.Add(this.button_Tabs_Control);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Test";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test";
            this.Load += new System.EventHandler(this.Test_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.main_Panel.ResumeLayout(false);
            this.main_Panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_Tabs_Control;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel main_Panel;
        private System.Windows.Forms.Label Number;
        private System.Windows.Forms.Label FIO;
        private System.Windows.Forms.TextBox number_student_textBox;
        private System.Windows.Forms.TextBox name_student_textBox;
        private Курсовая.Design.RoundButton roundButton_Starts;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label question;
        private Курсовая.Design.RoundButton roundButton_return;
        private System.Windows.Forms.RadioButton radioButton4;
        private Курсовая.Design.RoundButton roundButton_next;
        private System.Windows.Forms.Timer timer1;
    }
}