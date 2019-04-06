using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyApp
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            panel.Height = btnHome.Height;
            panel.Top = btnHome.Top;

            home1.Show();
            home1.BringToFront();
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            panel.Height = btnApps.Height;
            panel.Top = btnApps.Top;

            apps1.Show();
            apps1.BringToFront();

        }

        private void button3_Click(object sender, EventArgs e)
        {
         
            panel.Height = btnMedia.Height;
            panel.Top = btnMedia.Top;

            media1.Show();
            media1.BringToFront();
        }

      

        private void button4_Click(object sender, EventArgs e)
        {
      
            panel.Height = btnFiles.Height;
            panel.Top = btnFiles.Top;
        }

        private void button5_Click(object sender, EventArgs e)
        {

            panel.Height = btnLout.Height;
            panel.Top = btnLout.Top;

           

            
        }
       

        private void button6_Click(object sender, EventArgs e)
        {
            panel.Height = btnEmail.Height;
            panel.Top = btnEmail.Top;

            email1.Show();
            email1.BringToFront();
        
        }

        private void button7_Click(object sender, EventArgs e)
        {
            panel.Height = btnNotes.Height;
            panel.Top = btnNotes.Top;

            notes1.Show();
            notes1.BringToFront();
        
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {       
            home1.BringToFront();
        }

        
    }
}
