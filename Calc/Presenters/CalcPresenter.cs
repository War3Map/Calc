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
 


        //private double ChangeStringToDouble(string target)
        //{
        //    return double.Parse(target);
        //}

        //private decimal ChangeStringToDecimal(string target)
        //{
        //    return decimal.Parse(target);
        //}
        
        


        public void UpdateView(object data)
        {
            calcView.UpdateView(data);
        }

        public void TranslateToModel(string action, object data)
        {            
            object result = calc.Compute(data);
            UpdateView(result);
        }
    }
}
