using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blok
{
    public partial class Form1 : Form
    {
        public int x;
        public Form1()
        {
            InitializeComponent();
        }

        private bool Try()
        {
            try
            {
                x = Convert.ToInt32(textBox1.Text);
                return false;
            }
            catch
            {
                return true;
            }   

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Try() == false)
            {
                textBox2.Text = "Good";
            }
            else
            {
                textBox2.Text = "Error";
            }
        }
    }
}
