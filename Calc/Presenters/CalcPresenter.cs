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
    class CalcPresenter: IPresenter
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
        public void UpdateMemoryView(object data)
        {
            calcView.UpdateMemoryView(data);
        }

        public void SetMemoryState(string number)
        {
            decimal count;
            if(decimal.TryParse(number, out count))
            {
                calc.MemoryState.AddToMem(count);
                UpdateMemoryView(calc.MemoryState.PeekFromMem());
            } 
        }

        public void CleanMemory()
        {
            calc.MemoryState.ResetMemory();
            UpdateMemoryView(String.Empty);
        }

        public void PopStateMemory()
        {
            decimal popNumber = calc.MemoryState.ExtractFromMem();
            UpdateView(popNumber);
            UpdateMemoryView(calc.MemoryState.PeekFromMem());
        }
        
        public void TranslateToModel(string action, object data)
        {            
            object result = calc.Compute(data);
            UpdateView(result);
        }
    }
}
