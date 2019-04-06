using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace MyApp
{
    public partial class Apps : UserControl
    {
        public Apps()
        {
            InitializeComponent();
        }



        private void Apps_Load(object sender, EventArgs e)
        {
            Show();
            BringToFront();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Process.Start("vlc");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Process.Start("wmplayer");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process.Start("chrome");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("firefox");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process.Start("iexplore");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Process.Start("calc");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //Process.Start("Alarm & Clock");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //Process.Start("calen");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Process.Start("notepad");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Process.Start("mspaint");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Process.Start("winword");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Process.Start("excel");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Process.Start("powerpnt");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("outlook");
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            Process.Start("cmd");
           
        }
    }
}
