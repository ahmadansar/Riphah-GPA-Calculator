using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Riphah_GPA_Clc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int gpa1 = 0, gpa2 = 0, gpa3 = 0, gpa4 = 0, gpa5 = 0, gpa6 = 0;
            int m1 = Int32.Parse(textBox1.Text);
            int m2 = Int32.Parse(textBox2.Text);
            int m3 = Int32.Parse(textBox3.Text);
            int m4 = Int32.Parse(textBox4.Text);
            int m5 = Int32.Parse(textBox5.Text);
            int m6 = Int32.Parse(textBox6.Text);
            int s1 = Int32.Parse(comboBox1.Text);
            int s2 = Int32.Parse(comboBox2.Text);
            int s3 = Int32.Parse(comboBox3.Text);
            int s4 = Int32.Parse(comboBox4.Text);
            int s5 = Int32.Parse(comboBox5.Text);
            int s6 = Int32.Parse(comboBox6.Text);
            if (m1 < 0 || m1 > 100 || m2 < 0 || m2 > 100 || m3 < 0 || m3 > 100 || m4 < 0 || m4 > 100 || m5 < 0 || m5 > 100 || m6 < 0 || m6 > 100)
            {
                MessageBox.Show("Enter Marks btw 0-100 ! ");
            }
            else
            {
                if (checkBox1.Checked == true)
                {
                    m1 = 0;
                    s1 = 0;
                }
                if (checkBox2.Checked == true)
                {
                    m2 = 0;
                    s2 = 0;
                }
                if (checkBox3.Checked == true)
                {
                    m3 = 0;
                    s3 = 0;
                }
                if (checkBox4.Checked == true)
                {
                    m4 = 0;
                    s4 = 0;
                }
                if (checkBox5.Checked == true)
                {
                    m5 = 0;
                    s5 = 0;
                }
                if (checkBox6.Checked == true)
                {
                    m6 = 0;
                    s6 = 0;
                }

                if (m1 >= 80)
                {
                    gpa1 = s1 * 4;
                }
                else if (m1 >= 70 && m1 < 80)
                {
                    gpa1 = s1 * 3;
                }
                else if (m1 >= 60 && m1 < 70)
                {
                    gpa1 = s1 * 2;
                }
                else if (m1 >= 50 && m1 < 60)
                {
                    gpa1 = s1 * 1;
                }
                else
                {
                    gpa1 = s1 * 0;
                }

                if (m2 >= 80)
                {
                    gpa1 = s2 * 4;
                }
                else if (m2 >= 70 && m2 < 80)
                {
                    gpa1 = s2 * 3;
                }
                else if (m2 >= 60 && m2 < 70)
                {
                    gpa1 = s2 * 2;
                }
                else if (m2 >= 50 && m2 < 60)
                {
                    gpa1 = s2 * 1;
                }
                else
                {
                    gpa1 = s2 * 0;
                }

                if (m3 >= 80)
                {
                    gpa1 = s3 * 4;
                }
                else if (m3 >= 70 && m3 < 80)
                {
                    gpa1 = s3 * 3;
                }
                else if (m3 >= 60 && m3 < 70)
                {
                    gpa1 = s3 * 2;
                }
                else if (m3 >= 50 && m3 < 60)
                {
                    gpa1 = s3 * 1;
                }
                else
                {
                    gpa1 = s3 * 0;
                }

                if (m4 >= 80)
                {
                    gpa1 = s4 * 4;
                }
                else if (m4 >= 70 && m4 < 80)
                {
                    gpa1 = s4 * 3;
                }
                else if (m4 >= 60 && m4 < 70)
                {
                    gpa1 = s4 * 2;
                }
                else if (m4 >= 50 && m4 < 60)
                {
                    gpa1 = s4 * 1;
                }
                else
                {
                    gpa1 = s4 * 0;
                }

                if (m5 >= 80)
                {
                    gpa1 = s5 * 4;
                }
                else if (m5 >= 70 && m5 < 80)
                {
                    gpa1 = s5 * 3;
                }
                else if (m5 >= 60 && m5 < 70)
                {
                    gpa1 = s5 * 2;
                }
                else if (m5 >= 50 && m5 < 60)
                {
                    gpa1 = s5 * 1;
                }
                else
                {
                    gpa1 = s5 * 0;
                }

                if (m6 >= 80)
                {
                    gpa1 = s6 * 4;
                }
                else if (m6 >= 70 && m6 < 80)
                {
                    gpa1 = s6 * 3;
                }
                else if (m6 >= 60 && m6 < 70)
                {
                    gpa1 = s6 * 2;
                }
                else if (m6 >= 50 && m6 < 60)
                {
                    gpa1 = s6 * 1;
                }
                else
                {
                    gpa1 = s6 * 0;
                }
                int gpa = gpa1 + gpa2 + gpa3 + gpa4 + gpa5 + gpa6;
                float GPA = gpa / s1 + s2 + s3 + s4 + s5 + s6;
                GPA = GPA / 6;
                label11.Text = " GPA is : " + GPA.ToString();
                label11.Visible = true;
                button2.Visible = true;
            }

        }

        private void label11_Click(object sender, EventArgs e)
        {
            label11.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label11.Visible=false;
            button2.Visible=false;
        }
    }
}
