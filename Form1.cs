using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int Counter = 0;


        private void timer1_Tick(object sender, EventArgs e)
        {
            Counter++;
            label1.Text = Counter.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled=true;
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;

        }

        private void btnTimerReset_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            Counter = 0;
            label1.Text = Counter.ToString();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
