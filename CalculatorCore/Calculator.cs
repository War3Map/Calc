using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorCore
{
    public class Calculator
    {

        public decimal PI { get; } = Math.PI;

        public decimal Get_log(decimal number) => Math.Log(number);

        public decimal Get_sin(decimal angle) => Math.Sin(angle);

        public decimal Get_cos(decimal angle) => Math.Cos(angle);

        public decimal Get_tg(decimal angle) => Math.Tan(angle);

        public decimal Get_ctg(decimal angle) => 1 / Math.Tan(angle);

        public decimal Get_factorial(decimal number)
        {
            try
            {
                if (number == 0)
                {
                    return 1;
                }
                else
                {
                    return number * Get_factorial(number - 1);
                }
            }
            catch (Exception StackOverFlow)
            {
                Console.WriteLine("Факториала отрицательного числа не существует!");
                Console.WriteLine($"Отчет: {StackOverFlow.Message} \n {StackOverFlow.Source}");
            }
        }
        public decimal Get_sqrt(decimal number) => Math.Sqrt(number);

        public decimal ConversionGR(decimal degree) => degree * PI / 180;

        public decimal ConversionRG(decimal radian) => radian * 180 / PI;

        public decimal Get_persent(decimal number, decimal persent) => number / 100 * persent;

        public decimal Add(decimal x, decimal y) => x + y;

        public decimal Sub(decimal x, decimal y) => x - y;

        public decimal Mult(decimal x, decimal y) => x * y;

        public decimal Div(decimal x, decimal y) => x / y;

        public decimal Pow(decimal number, decimal power) => Math.Pow(number, power);

        public decimal MoreSQRT(decimal number, decimal power)
        {
            return 0;
        }
    }
}
