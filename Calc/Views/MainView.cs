using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    public partial class MainView : Form
    {
        public MainView()
        {
            InitializeComponent();
        }

        private void One_Click(object sender, EventArgs e)
        {
            MainDisplay.Text += "1";
        }

        private void Two_Click(object sender, EventArgs e)
        {
            MainDisplay.Text += "2";
        }

        private void Three_Click(object sender, EventArgs e)
        {
            MainDisplay.Text += "3";
        }

        private void Four_Click(object sender, EventArgs e)
        {
            MainDisplay.Text += "4";
        }

        private void Five_Click(object sender, EventArgs e)
        {
            MainDisplay.Text += "5";
        }

        private void Six_Click(object sender, EventArgs e)
        {
            MainDisplay.Text += "6";
        }

        private void Seven_Click(object sender, EventArgs e)
        {
            MainDisplay.Text += "7";
        }

        private void Eight_Click(object sender, EventArgs e)
        {
            MainDisplay.Text += "8";
        }

        private void Nine_Click(object sender, EventArgs e)
        {
            MainDisplay.Text += "9";
        }

        private void Zero_Click(object sender, EventArgs e)
        {
            MainDisplay.Text += "0";
        }

        private void Addition_Click(object sender, EventArgs e)
        {
            MainDisplay.Text += "+";
        }

        private void Subtraction_Click(object sender, EventArgs e)
        {
            MainDisplay.Text += "-";
        }

        private void Multiplication_Click(object sender, EventArgs e)
        {
            MainDisplay.Text += "*";
        }

        private void Division_Click(object sender, EventArgs e)
        {
            MainDisplay.Text += "/";
        }

        private void OpenningBracket_Click(object sender, EventArgs e)
        {
            MainDisplay.Text += "(";
        }

        private void ClothingBracket_Click(object sender, EventArgs e)
        {
            MainDisplay.Text += ")";
        }

        private void Comma_Click(object sender, EventArgs e)
        {
            MainDisplay.Text += ",";
        }
        //memoryDisplay не сделан и первые две строки кроме + и скобок тоже
    }
}
