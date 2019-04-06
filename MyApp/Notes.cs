using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MyApp
{
    public partial class Notes : UserControl
    {
        public Notes()
        {
            InitializeComponent();
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (subject.Text == "" || subject.Text == " ")
            {
                MessageBox.Show("Please Enter The Subject", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {

                SaveFileDialog save = new SaveFileDialog();
                save.Title = "Save Note";
                save.Filter = "Text Files (*.txt)|*.txt";
                save.FileName = subject.Text;

                if (save.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    StreamWriter write = new StreamWriter(File.Create(save.FileName));

                    write.Write(note.Text);
                    write.Dispose();
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "Open Note";
            open.Filter = "Text Files  (*.txt)|*.txt";
            

            if (open.ShowDialog() == DialogResult.OK)
            {
                
                StreamReader read = new StreamReader(File.OpenRead(open.FileName));
                note.Text = read.ReadToEnd();
                read.Dispose();

            }
    }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            note.BackColor = Color.FromArgb(49, 224, 28);
            note.ForeColor = Color.Black;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            note.BackColor = Color.FromArgb(237, 169, 16);
            note.ForeColor = Color.Black;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            note.BackColor = Color.FromArgb(234, 37, 37);
            note.ForeColor = Color.Black;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            note.BackColor = Color.White;
            note.ForeColor = Color.Black;
        }
    }
}
