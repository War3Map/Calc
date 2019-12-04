using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorCore
{
    public class Calculator
    {
        public State stateOfMemory { get; set; }

        public Calculator()
        {
            stateOfMemory = new State();
        }

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

        public decimal SquaredNumber(decimal x) => x * x;
        //Тут поменял возвращаемое значение и аргументы метода на double, геометрию на decimal не переведем
        //Быстрее родного алгоритма Pow, пока не получилось сделать, почему ты решил, что он медленно работает?
        //Тебе удовалось сделать быстрее?
        public double Pow(double number, double power) => Math.Pow(number, power);

        public double SquareRoot(double number) => Math.Sqrt(number);

        public double Root(double number, double power) => Math.Pow(number, 1 / power);
        
        public double Log(double number) => Math.Log(number);

        public double Sin(double angle) => Math.Sin(angle);

        public double Cos(double angle) => Math.Cos(angle);

        public double Tan(double angle) => Math.Tan(angle);

        public double Ctg(double angle) => 1 / Math.Tan(angle);
    }
}
