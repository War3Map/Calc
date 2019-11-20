using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorCore;


namespace Calc.Presenters
{
    class CalcPresenter
    {
       public CalcPresenter(Calculator calculator, State memoryState, MainView gui)
       {
            calculator = new Calculator();
            memoryState = new State();
            gui = new MainView();
       }
    }
}
