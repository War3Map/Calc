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
    class CalcPresenter:IPresenter
    {
        IView calcView;
        Calculator calc;        

        public CalcPresenter(IView calcView)
        {
            this.calcView = calcView;
            calc = new Calculator();            
        }


        private object AnalyzeAndCompute(object data)
        {
            Tuple<string, string> tuple = (Tuple<string,string>) data;
            double number;

            if (double.TryParse(tuple.Item2, out number))
            {

                string operation = tuple.Item1;
                return SelectAndComputeOperaion(operation, number);
            }
            else
                return 0;
        }

        private double ChangeStringToDouble(string target)
        {
            return double.Parse(target);
        }

        private decimal ChangeStringToDecimal(string target)
        {
            return decimal.Parse(target);
        }
        
        //TODO:Нужно добавить операции
        private string SelectAndComputeOperaion(string operation, double number)
        {
            switch (operation)
            {
                case "SQRT":
                    return calc.SquareRoot(number).ToString();
                default:
                    return "999999";
            }
        }

        public void UpdateView(object data)
        {
            calcView.UpdateView(data);
        }

        public void TranslateToModel(string action, object data)
        {            
            object result = AnalyzeAndCompute(data);
            UpdateView(result);
        }
    }
}
