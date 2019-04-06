using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
