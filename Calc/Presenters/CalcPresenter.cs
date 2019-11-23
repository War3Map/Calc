using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorCore;
using Calc.Functionality;

namespace Calc.Presenters
{   
    class CalcPresenter
    {
        IView calcView;
        Calculator calc;

        void Compute()
        {           
            calcView.UpdateData(AnalyzeData(calcView.GetData()));
        }

        object AnalyzeData(object data)
        {


            
           return 0;
        }

        public CalcPresenter(IView calcView)
        {
            this.calcView = calcView;
            calc = new Calculator();
        }


    }
}
