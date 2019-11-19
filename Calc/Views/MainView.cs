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

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        //Корректировка ввода
        private void MainDisplay_TextChanged(object sender, EventArgs e)
        {
            char[] allowedSymbols = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            bool isCorrectInput=false;
            string currentText=MainDisplay.Text;
            StringBuilder correctedText = new StringBuilder();
            int inputLength = currentText.Length;
            int commasCount = 0;//число запятых

            if (inputLength > 1)
            {
                for(int i=0;i<inputLength;i++)
                {
                    isCorrectInput = false;
                    foreach (var symbol in allowedSymbols)
                    if (currentText[i] == symbol)
                    {
                        
                        isCorrectInput = true;
                        break;
                    }

                    if (currentText[i] == ',' & i != 0)
                    {
                        commasCount++;
                        if (commasCount == 1) isCorrectInput = true;
                    }                    

                    if (isCorrectInput)                         
                        correctedText.Append(currentText[i]);

                }
                
                MainDisplay.Text = correctedText.ToString();
                MainDisplay.SelectionStart = MainDisplay.Text.Length; //курсор в конец
            }
        }
        
    }
}
