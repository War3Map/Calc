using Calc.Functionality;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc.Presenters
{
    interface IPresenter
    {
        void TranslateToModel(string action,object data);//передача действия модели
        void SetMemoryState(string number);//передача текущего числа в память
        //string GetMemory();
    }
}
