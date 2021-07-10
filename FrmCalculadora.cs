using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pantallas_proyecto
{
    public partial class TxtResultBox : Form
    {
        public TxtResultBox()
        {
            InitializeComponent();
        }

        private void click_button(object sender, EventArgs e)
        {
            Button
            TxtResulttxt.Text = TxtResulttxt.Text + "1";
        }
    }
}
