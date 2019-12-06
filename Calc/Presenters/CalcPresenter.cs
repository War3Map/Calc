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
        
        public void UpdateView(object data)
        {
            calcView.UpdateView(data);
        }

        public void SetMemoryState(string number)
        {
            calc.MemoryState.CurrentState = decimal.Parse(number);
        }
        // Ищу способ проверить на null не используя тип decimal?
        //public string GetMemory()
        //{
        //    return calc.MemoryState.CurrentState.ToString();
        //}
        public void TranslateToModel(string action, object data)
        {            
            object result = calc.Compute(data);
            UpdateView(result);
        }
    }
}
