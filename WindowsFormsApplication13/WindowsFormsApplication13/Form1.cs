using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length < 5)
            {
                MessageBox.Show("Please Enter a Username of Length 5 characters");
            }
            else if(!textBox2.Text.Contains("@gmail.com"))
                {
                    MessageBox.Show("Enter a valid email");
            }
            else
            {
                server.Service1 myserver = new server.Service1();
                myserver.registration(textBox1.Text, textBox2.Text);

                MessageBox.Show("user registered");
            }
           
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 frm = new Form2();
            this.Hide();
            frm.Show();
        }
    }
}
