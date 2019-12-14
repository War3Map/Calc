using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calc.Presenters;
using Calc.Functionality;
using Ninject.Modules;
using Ninject;


namespace Calc
{
    public partial class MainView : Form, IView
    {
        IPresenter presenter;
        
        public MainView()
        {
            //здесь дб IoC

            presenter = new CalcPresenter(this);
            InitializeComponent();
        }

        private void DisplayInput(object sender, EventArgs e)
        {
            MainDisplay.Text += (sender as Button).Text;
        }

        private void OperationCompute(object sender, EventArgs e)
        {
            string operation = (sender as Button).Text;
            string content = MainDisplay.Text;
            presenter.TranslateToModel("Compute",new Tuple<string,string>(operation, content));
        }

        private void SaveNumber(object sender, EventArgs e)
        {
            string content = MainDisplay.Text;
            presenter.SetMemoryState(content);
        }
        private void MemoryCleanClick(object sender, EventArgs e)
        {
            presenter.CleanMemory();
        }

        private void MemoryReadClick(object sender, EventArgs e)
        {
            presenter.PopStateMemory();
        }

        private void CleanEntryClick(object sender, EventArgs e)
        {
            if(MainDisplay.Text.Length > 0)
            {
                string newText = MainDisplay.Text.Remove(MainDisplay.Text.Length - 1);
                MainDisplay.Text = newText;
            }       
        }
        private void CleanAllClick(object sender, EventArgs e)
        {
            MainDisplay.Text = null;
        }
       
        //Корректировка ввода
        private void MainDisplayTextChanged(object sender, EventArgs e)
        {
            char[] allowedSymbols = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9'  };
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
                    if (currentText[i] == '-' & i == 0) isCorrectInput = true;

                    if (isCorrectInput)                         
                        correctedText.Append(currentText[i]);

                }
                
                MainDisplay.Text = correctedText.ToString();
                MainDisplay.SelectionStart = MainDisplay.Text.Length; //курсор в конец
            }
        }
        private void MemoryDisplayTextChanged(object sender, EventArgs e)
        {
            
        }

        public void UpdateMemoryView(object data)
        {
            MemoryDisplay.Text = data.ToString();
        }
        public void UpdateView(object data)
        {   
            MainDisplay.Text = data.ToString();
        }
    }
}
