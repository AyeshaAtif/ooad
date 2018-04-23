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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool isvaliduser;
            bool isvaliduserpassed;
            server.Service1 myserver = new server.Service1();
            myserver.isvaliduser(textBox1.Text, textBox2.Text, out isvaliduser, out isvaliduserpassed);
            if (isvaliduser == true) 
            {
                MessageBox.Show("validuser");
            }
            else
            {
                MessageBox.Show("invaliduser");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 frm = new Form1();
            this.Hide();
            frm.Show();
        }
    }
}
