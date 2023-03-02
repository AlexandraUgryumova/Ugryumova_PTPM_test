using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Угрюмова_практика_7_19_
{
    public partial class Form1 : Form
    {
        Qetions qest = new Qetions();
        registr form = new registr();
        Student stud1 = new Student();
        int n = 0;
        public Form1()
        {
            InitializeComponent();
            form.ShowDialog();
            qest.longQetions = qest.LengthTest();
            qest.qetions = new string[qest.longQetions, 11];
            stud1.answer = new string[qest.longQetions];
            StreamReader sr = File.OpenText("test.txt");
            int i = 0, j;
            while (!sr.EndOfStream)
            {
                for (j = 0; j < qest.longQetions; j++)
                {
                    qest.qetions[i, j] = sr.ReadLine();
                }
                i++;
            }
            sr.Close();
            
            this.Text = "Вопрос " + (qest.curr_numb + 1);
            label1.Text = qest.qetions[0, 0];
            radioButton1.Text = qest.qetions[0, 1];
            radioButton2.Text = qest.qetions[0, 2];
            radioButton3.Text = qest.qetions[0, 3];
            //first qetions
            {
                if (qest.qetions[0, 5] == "")
                {
                    checkBox1.Visible = false;
                    checkBox2.Visible = false;
                    checkBox3.Visible = false;
                }
                else
                {
                    radioButton1.Visible = false;
                    radioButton2.Visible = false;
                    radioButton3.Visible = false;
                }
                if (qest.qetions[0, 7] != "")
                {
                    pictureBox1.Visible = true;
                    pictureBox1.Image = Image.FromFile(qest.qetions[qest.curr_numb, 7]);
                }
                else
                {
                    pictureBox1.Visible = false;
                }
                if (qest.qetions[0, 8] != "")
                {
                    pictureBox2.Visible = true;
                    pictureBox2.Image = Image.FromFile(qest.qetions[qest.curr_numb, 8]);
                }
                else
                {
                    pictureBox2.Visible = false;
                }
                if (qest.qetions[0, 9] != "")
                {
                    pictureBox3.Visible = true;
                    pictureBox3.Image = Image.FromFile(qest.qetions[qest.curr_numb, 9]);
                }
                else
                {
                    pictureBox3.Visible = false;
                }
                if (qest.qetions[0, 10] != "")
                {
                    pictureBox4.Visible = true;
                    pictureBox4.Image = Image.FromFile(qest.qetions[qest.curr_numb, 10]);
                }
                else
                {
                    pictureBox4.Visible = false;
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (qest.qetions[qest.curr_numb, 5] == "")
            {
                Chek1();
            }
            else
            {
                Chek2();
            }
            if (qest.curr_numb < qest.longQetions-1 && qest.qetions[qest.curr_numb + 1, 5] == "")
            {
                checkBox1.Visible = false;
                checkBox2.Visible = false;
                checkBox3.Visible = false;
                radioButton1.Visible = true;
                radioButton2.Visible = true;
                radioButton3.Visible = true;
            }
            else
            {
                checkBox1.Visible = true;
                checkBox2.Visible = true;
                checkBox3.Visible = true;
                radioButton1.Visible = false;
                radioButton2.Visible = false;
                radioButton3.Visible = false;
            }
            //qetions
            {
                if (qest.curr_numb < qest.qetions.GetLength(0) - 1)
                {
                    qest.curr_numb++;
                    this.Text = "Вопрос " + (qest.curr_numb + 1);
                    label1.Text = qest.qetions[qest.curr_numb, 0];
                    radioButton1.Text = qest.qetions[qest.curr_numb, 1];
                    radioButton2.Text = qest.qetions[qest.curr_numb, 2];
                    radioButton3.Text = qest.qetions[qest.curr_numb, 3];
                    checkBox1.Text = qest.qetions[qest.curr_numb, 1];
                    checkBox2.Text = qest.qetions[qest.curr_numb, 2];
                    checkBox3.Text = qest.qetions[qest.curr_numb, 3];
                    if (qest.qetions[qest.curr_numb, 7] != "")
                    {
                        pictureBox1.Visible = true;
                        pictureBox1.Image = Image.FromFile(qest.qetions[qest.curr_numb, 7]);
                    }
                    else
                    {
                        pictureBox1.Visible = false;
                    }
                    if (qest.qetions[qest.curr_numb, 8] != "")
                    {
                        pictureBox2.Visible = true;
                        pictureBox2.Image = Image.FromFile(qest.qetions[qest.curr_numb, 8]);
                    }
                    else
                    {
                        pictureBox2.Visible = false;
                    }
                    if (qest.qetions[qest.curr_numb, 9] != "")
                    {
                        pictureBox3.Visible = true;
                        pictureBox3.Image = Image.FromFile(qest.qetions[qest.curr_numb, 9]);
                    }
                    else
                    {
                        pictureBox3.Visible = false;
                    }
                    if (qest.qetions[qest.curr_numb, 10] != "")
                    {
                        pictureBox4.Visible = true;
                        pictureBox4.Image = Image.FromFile(qest.qetions[qest.curr_numb, 10]);
                    }
                    else
                    {
                        pictureBox4.Visible = false;
                    }
                }
                else
                {
                    button1.Enabled = false;
                    if (qest.curr_numb + 1 <= qest.answer)
                    {
                        MessageBox.Show("Вы ответили верно на все " + qest.curr_numb + 1 + " вопросов", "Результаты");
                    }
                    else
                    {
                        MessageBox.Show($"вы ответили верно лишь на {qest.curr_numb + 1} вопросов", "Результаты");
                    }
                }
            }
        }
        private void Chek1()
        {
            if (radioButton1.Checked)
            {
                if (radioButton1.Text == qest.qetions[qest.curr_numb, 4])
                {
                    stud1.answer[n] = "ответ: " + radioButton1.Text;
                    qest.answer++;
                    n += 1;
                }
            }
            if (radioButton2.Checked)
            {
                if (radioButton2.Text == qest.qetions[qest.curr_numb, 4])
                {
                    stud1.answer[n] = "ответ: " + radioButton2.Text;
                    qest.answer++;
                    n += 1;
                }
            }
            if (radioButton3.Checked)
            {
                if (radioButton3.Text == qest.qetions[qest.curr_numb, 4])
                {
                    stud1.answer[n] = "ответ: " + radioButton3.Text;
                    qest.answer++;
                    n += 1;
                }
            }
        }
        private void Chek2()
        {
            if (checkBox1.Checked)
            {
                if (checkBox1.Text == qest.qetions[qest.curr_numb, 4]|| checkBox1.Text == qest.qetions[qest.curr_numb, 5] || checkBox1.Text == qest.qetions[qest.curr_numb, 6])
                {
                    qest.answer+=0.5;
                }
            }
            if (checkBox2.Checked)
            {
                if (checkBox2.Text == qest.qetions[qest.curr_numb, 4] || checkBox2.Text == qest.qetions[qest.curr_numb, 5] || checkBox2.Text == qest.qetions[qest.curr_numb, 6])
                {
                    qest.answer+=0.5;
                }
            }
            if (checkBox3.Checked)
            {
                if (checkBox3.Text == qest.qetions[qest.curr_numb, 4] || checkBox3.Text == qest.qetions[qest.curr_numb, 5] || checkBox3.Text == qest.qetions[qest.curr_numb, 6])
                {
                    qest.answer+=0.5;
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
