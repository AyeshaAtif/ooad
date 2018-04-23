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
    public partial class test_type_selection : Form
    {
        public test_type_selection()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            catagory_selection frm = new catagory_selection();
            this.Hide();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked && checkBox2.Checked)
            {
                MessageBox.Show("Invalid choice");
            }
            else if (!checkBox1.Checked && !checkBox2.Checked)
            {
                MessageBox.Show("Make one choice");
            }
        }
    }
}
