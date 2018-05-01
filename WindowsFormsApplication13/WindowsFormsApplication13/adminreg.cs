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
    public partial class adminreg : Form
    {
        public adminreg()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            adminlogin l = new adminlogin();
            l.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            start s = new start();
            s.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 5 || !textBox2.Text.Contains("@gmail.com") || !textBox3.Text.Contains("!"))
            {
                MessageBox.Show("your name should be of length 5, email must contain @gmail.com , password must have one ! symbol");
            }
            else
            {

                server.Service1 myserver = new server.Service1();
                myserver.adminreg(textBox1.Text, textBox2.Text, textBox3.Text);

                MessageBox.Show("admin registered");
            }
        }
        

        private void adminreg_Load(object sender, EventArgs e)
        {

        }
    }
}
