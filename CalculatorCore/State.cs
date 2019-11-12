using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorCore
{
    class State
    {

        public State()
        {

        }

        public Stack<decimal> Memory { get; set; }

        public void AddToMem(decimal number)
        {
            Memory.Push(number);
        }
        public decimal ExtractFromMem() => Memory.Pop();
    }
}
