using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorCore
{
    public class State
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
            //Э* Я думую тут по идее 0 будет не правильно, ведь тогда он сможет изъять его из памяти и умножить/делить на что-то
            //Э* Надо бы сделать так, чтобы при возвращении 0 он в область вывода ничего не писал. 
            return (Memory.Count > 0)? Memory.Pop():0;
        }
    }
}
