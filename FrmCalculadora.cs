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
        Double resultValue = 0;
        string OperatorClicked = "";

        public TxtResultBox()
        {
            InitializeComponent();
        }

        private void click_button(object sender, EventArgs e)
        {
            if (TxtResulttxt.Text == "0")
            {
                TxtResulttxt.Clear();
                //
                Button button = (Button)sender;
                TxtResulttxt.Text = TxtResulttxt.Text + button.Text;

            }



        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            OperatorClicked = button.Text;
            resultValue = Double.Parse(TxtResulttxt.Text);
           }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtResulttxt.Text = "0";
            resultValue = 0;
        }

        private void btnigual_Click(object sender, EventArgs e)
        {
            switch (OperatorClicked) {
                case "+":
                    TxtResulttxt.Text = (resultValue + Double.Parse(TxtResulttxt.Text)).ToString();
                    break;

                case "-":
                    TxtResulttxt.Text = (resultValue - Double.Parse(TxtResulttxt.Text)).ToString();
                    break;

                case "x":
                    TxtResulttxt.Text = (resultValue * double.Parse(TxtResulttxt.Text)).ToString();
                    break;

                case "÷":
                    TxtResulttxt.Text = (resultValue / double.Parse(TxtResulttxt.Text)).ToString();
                    break;
                default:
                    break;

            }
        }
    }
}
