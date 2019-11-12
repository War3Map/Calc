using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorCore
{
    class State
    {
        public Stack<decimal> Memory { get; set; }
        public State()
        {
            Memory = new Stack<decimal>();
        }

        public void Reset()
        {
            Memory.Clear();
        }

        public void AddToMem(decimal number)
        {
            Memory.Push(number);
        }
        public decimal ExtractFromMem()
        {
            //чтобы не извлекать из стэка если он пустой
            return (Memory.Count > 0)? Memory.Pop():0;
        }
    }
}
