/*
 * Gurvir Uppal
 * Magic 8 Ball
 * May 6 2021
 * Mr. T 
 * ICS 3U
 * */




using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace magic8Ball
{
    public partial class Form1 : Form
    {
        Random randGen = new Random();

        int number = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void pressButton_Click(object sender, EventArgs e)
        {

            number = randGen.Next(1, 7);
            switch (number)
            {
                case 1:
                    outputLabel.Text = "Most definatly"; 
                    break;
                case 2:
                    outputLabel.Text = "Probably";
                    break;
                case 3:
                    outputLabel.Text = "Maybe";
                    break;
                case 4:
                    outputLabel.Text = "Probably not";
                    break;
                case 5:
                    outputLabel.Text = "Not happening";
                    break;
                case 6:
                    outputLabel.Text = "Not in a million  years buddy";
                    break;
            }
        }
    }
}
