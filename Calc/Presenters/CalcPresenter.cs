using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorCore;
using Calc.Functionality;
using Ninject.Modules;
using Ninject;


namespace Calc.Presenters
{   
    class CalcPresenter
    {
        IView calcView;
        Calculator calc;
        State stateOfMemory;

        public CalcPresenter(IView calcView)
        {
            this.calcView = calcView;
            calc = new Calculator();
            stateOfMemory = new State();
        }

        public void Compute()
        {           
            calcView.UpdateData(AnalyzeData(calcView.GetData()));
        }

        private object AnalyzeData((string, string) data)
        {
            double number = double.Parse(data.Item1);
            
            return Choose(data.Item2, number);
        }

        private double ChangeStringToDouble(string target)
        {
            return double.Parse(target);
        }

        private decimal ChangeStringToDecimal(string target)
        {
            return decimal.Parse(target);
        }

        private string Choose(string operation, double number)
        {
            switch (operation)
            {
                case "SQRT":
                    return calc.SquareRoot(number).ToString();
                default:
                    return "999999";
            }
        }

    }
}
