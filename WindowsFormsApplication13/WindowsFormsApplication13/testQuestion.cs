using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Timers;

namespace WindowsFormsApplication13
{
    public partial class testQuestion : Form
    {
        string[] lines;
        string answer;
        int i = 0;
        int index=0;
        int counter = 0;
        int score = 0;
        string value;
        int duration = 300;
        int questionNo = 0;
        int tmp;
        public testQuestion()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void testQuestion_Load(object sender, EventArgs e)
        {
            questionNo++;
            label1.Text = questionNo.ToString();
            timer1.Enabled = true;
            timer1.Start();
            lines = File.ReadAllLines(@"C:\Users\Tehreem Shazadi\Desktop\ooad\WindowsFormsApplication13\WindowsFormsApplication13\Resources\testttt.txt");
            lblquestion.Text = lines[index];
            radioButton1.Text = lines[++index];
            radioButton2.Text = lines[++index];
            radioButton3.Text = lines[++index];
            radioButton4.Text = lines[++index];
            answer = lines[++index];
            counter = index;

        }

        private void nxtbtn_Click(object sender, EventArgs e)
        {
            questionNo++;
            label1.Text = questionNo.ToString();
            lines = File.ReadAllLines(@"C:\Users\Tehreem Shazadi\Desktop\ooad\WindowsFormsApplication13\WindowsFormsApplication13\Resources\testttt.txt");
            if (File.ReadAllLines(@"C:\Users\Tehreem Shazadi\Desktop\ooad\WindowsFormsApplication13\WindowsFormsApplication13\Resources\testttt.txt") == null)
            {
                MessageBox.Show("test has been ended");
            }
           else if ((!radioButton1.Checked) && (!radioButton2.Checked) && (!radioButton3.Checked) && (!radioButton4.Checked))
            {
                MessageBox.Show("Select Atleast One Option");
            }
            else
            {
                lblquestion.Text = lines[++counter];
                radioButton1.Text = lines[++counter];
                radioButton2.Text = lines[++counter];
                radioButton3.Text = lines[++counter];
                radioButton4.Text = lines[++counter];
                answer = lines[++counter];
                tmp = counter - 6;
            }

        }

        private void submitbtn_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                value = radioButton1.Text;
            }
            else if (radioButton2.Checked)
            {
                value = radioButton2.Text;
            }
            else if (radioButton3.Checked)
            {
                value = radioButton3.Text;
            }
            else if (radioButton4.Checked)
            {
                value = radioButton4.Text;
            }


            if (answer == value)
            {
                score++;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            duration--;
            textBox1.Text = duration.ToString();
            if (duration == 0)
            {
                timer1.Stop();
                MessageBox.Show("time is up");
            }
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            if(tmp <=0 )
            {
                MessageBox.Show("that was the first question you cant go back");
            }
            else {
                questionNo--;
                label1.Text = questionNo.ToString();
                answer = lines[tmp];
                radioButton4.Text = lines[--tmp];
                radioButton3.Text = lines[--tmp];
                radioButton2.Text = lines[--tmp];
                radioButton1.Text = lines[--tmp];
                lblquestion.Text = lines[--tmp];


                tmp = tmp - 6;
            }
           


        }

        private void button1_Click(object sender, EventArgs e)
        {
            catagory_selection cat = new catagory_selection();
            this.Hide();
            cat.Show();
        }

        private void lblqtn_Click(object sender, EventArgs e)
        {

        }
    }
}
