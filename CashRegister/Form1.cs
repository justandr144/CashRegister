using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashRegister
{
    public partial class Form1 : Form
    {
        //Global Variable
        double pizzaSize = 0;
        int toppingAmount;
        string pizzaLabel;


        public Form1()
        {
            InitializeComponent();
        }

        private void SmallButton_Click(object sender, EventArgs e)
        {
            pizzaSize = 5;
            pizzaLabel = "small";

            smallButton.BackColor = Color.Gray;
            mediumButton.BackColor = Color.Black;
            largeButton.BackColor = Color.Black;
            xLargeButton.BackColor = Color.Black;
        }

        private void MediumButton_Click(object sender, EventArgs e)
        {
            pizzaSize = 7;
            pizzaLabel = "medium";

            smallButton.BackColor = Color.Black;
            mediumButton.BackColor = Color.Gray;
            largeButton.BackColor = Color.Black;
            xLargeButton.BackColor = Color.Black;
        }

        private void LargeButton_Click(object sender, EventArgs e)
        {
            pizzaSize = 10;
            pizzaLabel = "large";

            smallButton.BackColor = Color.Black;
            mediumButton.BackColor = Color.Black;
            largeButton.BackColor = Color.Gray;
            xLargeButton.BackColor = Color.Black;
        }

        private void XLargeButton_Click(object sender, EventArgs e)
        {
            pizzaSize = 12;
            pizzaLabel = "xlarge";

            smallButton.BackColor = Color.Black;
            mediumButton.BackColor = Color.Black;
            largeButton.BackColor = Color.Black;
            xLargeButton.BackColor = Color.Gray;
        }



        private void CalculateButton_Click(object sender, EventArgs e)
        {
            double toppingBase = 1.25;

            try
            {
                toppingAmount = Convert.ToInt32(toppingsText.Text);
            }
            catch
            {
                outputLabel.Text = "Use a number in topping box.";
            }

            if (pizzaSize > 1)
            {
                double pizzaCost = toppingAmount * toppingBase + pizzaSize;
                outputLabel.Text = $"The price of a {pizzaLabel} pizza with {toppingAmount} topping(s) is:";
                outputLabel.Text += $"\n{pizzaCost.ToString("C")}";
            }
            else
            {
                outputLabel.Text = "Please select a pizza size";
            }

        }
    }
}
