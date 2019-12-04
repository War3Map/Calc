using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorCore
{
    public class State
    {
        public decimal CurrentState { get; set; }
        public string Operation { get; set; }
        Stack<decimal> memory;
        
        public State()
        {
            memory = new Stack<decimal>();
        }

 
        public void SetOperation(string operation)
        {
            Operation = operation;
        }

        public void ResetMemory()
        {
            memory.Clear();
        }
        public void ResetCurrent()
        {
            CurrentState = 0;
        }

        public void ResetOperation()
        {
            Operation = String.Empty;
        }

        public void AddToMem(decimal number)
        {
            memory.Push(number);
        }
        public decimal ExtractFromMem()
        {
            //чтобы не извлекать из стэка если он пустой
            //Э* Я думую тут по идее 0 будет не правильно, ведь тогда он сможет изъять его из памяти и умножить/делить на что-то
            
            //TODO: Э* Надо бы сделать так, чтобы при возвращении 0 он в область вывода ничего не писал. 
            return (memory.Count > 0)? memory.Pop():0;
        }
    }
}
