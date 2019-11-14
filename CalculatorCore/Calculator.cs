using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorCore
{
    public class Calculator
    {

        public decimal PI { get; } = (decimal)Math.PI;
        public decimal Factorial(decimal number)
        {
            if (number < 0) return 0;//не хотелось чтобы калькулятор ломался  // Э* Тут по идее тоже, надо выдать юзеру сообщение, что так нельзя сделать
            else if (number == 0) return 1;
            else
            {
                return number * Factorial(number - 1);
            }
 
        }
        public decimal Sqrt(decimal number)
        {
            throw new NotImplementedException();
        }

        public decimal ToRadian(decimal degree) => degree * PI / 180;

        public decimal ToDegree(decimal radian) => radian * 180 / PI;

        public decimal ToPercent(decimal number, decimal percent) => number / 100 * percent;

        public decimal Add(decimal x, decimal y) => x + y;

        public decimal Sub(decimal x, decimal y) => x - y;

        public decimal Mult(decimal x, decimal y) => x * y;

        public decimal Div(decimal x, decimal y) => x / y;

        public decimal Sqr(decimal x, decimal y) => x *x;

        public decimal Pow(decimal number, decimal power)
        {
            throw new NotImplementedException();
        }
        public decimal Root(decimal number, decimal power)
        {
             throw new NotImplementedException();
        }

        public decimal Log(decimal number)
        {
            throw new NotImplementedException();
        }

        public decimal Sin(decimal angle)
        {
            throw new NotImplementedException();
        }

        public decimal Cos(decimal angle)
        {
            throw new NotImplementedException();
        }

        public decimal Tan(decimal angle)
        {
            throw new NotImplementedException();
        }

        public decimal Ctg(decimal angle)
        {
            throw new NotImplementedException();
        }
    }
}
