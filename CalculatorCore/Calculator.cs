using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorCore
{
    public class Calculator
    {
        public State MemoryState { get; set; }

        public Calculator()
        {
            MemoryState = new State();
        }

        public decimal PI { get; } = (decimal)Math.PI;
        public decimal Factorial(decimal number)
        {
            if (number < 0) return 0;
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

        public decimal Pow(decimal number) => number * number;

        public double NPow(double number, double power) => Math.Pow(number, power);

        public double SquareRoot(double number) => Math.Sqrt(number);

        public double Root(double number, double power) => Math.Pow(number, 1 / power);
        
        public double NaturalLog(double number) => Math.Log(number);

        public double DecimalLog(double number) => Math.Log10(number);

        public double Sin(double angle) => Math.Sin(angle);

        public double Cos(double angle) => Math.Cos(angle);

        public double Tan(double angle) => Math.Tan(angle);

        public double Ctg(double angle) => 1 / Math.Tan(angle);

        public object Compute(object data)
        {
            Tuple<string, string> tuple = (Tuple<string, string>)data;
            decimal number;
            string operation = tuple.Item1;

            switch (operation)
            {
                case "M+":

                    if (decimal.TryParse(tuple.Item2, out number))
                    {

                        return Add(MemoryState.PeekFromMem(), number).ToString();
                    }
                    else
                        return 0;
                case "M-":

                    if (decimal.TryParse(tuple.Item2, out number))
                    {
                        decimal test = Sub(MemoryState.PeekFromMem(), number);
                        string test2 = test.ToString();
                        return Sub(MemoryState.PeekFromMem(), number).ToString();
                    }
                    else
                        return 0;
                case "SQRT":

                    if (decimal.TryParse(tuple.Item2, out number))
                    {

                        return SquareRoot((double)number).ToString();
                    }
                    else
                        return 0;
                case "NSQRT":

                    if (decimal.TryParse(tuple.Item2, out number))
                    {
                        MemoryState.CurrentState = number;
                        MemoryState.SetOperation(tuple.Item1);
                        return String.Empty;
                    }
                    else
                        return 0;
                case "TG":

                    if (decimal.TryParse(tuple.Item2, out number))
                    {

                        return Tan((double)number).ToString();
                    }
                    else
                        return 0;
                case "CTG":

                    if (decimal.TryParse(tuple.Item2, out number))
                    {

                        return Ctg((double)number).ToString();
                    }
                    else
                        return 0;
                case "SIN":

                    if (decimal.TryParse(tuple.Item2, out number))
                    {

                        return Sin((double)number).ToString();
                    }
                    else
                        return 0;
                case "COS":

                    if (decimal.TryParse(tuple.Item2, out number))
                    {

                        return Cos((double)number).ToString();
                    }
                    else
                        return 0;
                case "x^2":

                    if (decimal.TryParse(tuple.Item2, out number))
                    {

                        return Pow(number).ToString();
                    }
                    else
                        return 0;
                case "x^n":

                    if (decimal.TryParse(tuple.Item2, out number))
                    {
                        MemoryState.CurrentState = number;
                        MemoryState.SetOperation(tuple.Item1);
                        return String.Empty;
                    }
                    else
                        return 0;
                case "LN":

                    if (decimal.TryParse(tuple.Item2, out number))
                    {

                        return NaturalLog((double)number).ToString();
                    }
                    else
                        return 0;
                case "LOG":

                    if (decimal.TryParse(tuple.Item2, out number))
                    {

                        return DecimalLog((double)number).ToString();
                    }
                    else
                        return 0;
                case "N!":

                    if (decimal.TryParse(tuple.Item2, out number))
                    {

                        return Factorial(number).ToString();
                    }
                    else
                        return 0;
                case "PI":
                    return PI;
                case "+":
                    if (decimal.TryParse(tuple.Item2, out number))
                    {

                        MemoryState.CurrentState = number;
                        MemoryState.SetOperation(tuple.Item1);
                        return String.Empty;
                    }
                    else
                        return String.Empty;
                case "-":
                    if (decimal.TryParse(tuple.Item2, out number))
                    {

                        MemoryState.CurrentState = number;
                        MemoryState.SetOperation(tuple.Item1);
                        return String.Empty;
                    }
                    else
                        return String.Empty;
                case "*":
                    if (decimal.TryParse(tuple.Item2, out number))
                    {

                        MemoryState.CurrentState = number;
                        MemoryState.SetOperation(tuple.Item1);
                        return String.Empty;
                    }
                    else
                        return String.Empty;
                case "/":
                    if (decimal.TryParse(tuple.Item2, out number))
                    {

                        MemoryState.CurrentState = number;
                        MemoryState.SetOperation(tuple.Item1);
                        return String.Empty;
                    }
                    else
                        return String.Empty;
                case "=":
                    if (decimal.TryParse(tuple.Item2, out number))
                    {
                        return ComputeBinary(number);
                    }
                    else
                        return 0;
                default:
                    return String.Empty;
            }
        }
        private object ComputeBinary(decimal number)
        {
            switch(MemoryState.Operation)
            {
                case "+":
                {
                    return Add(MemoryState.CurrentState, number);
                    //return MemoryState.CurrentState + number;

                }
                case "-":
                {
                    return Sub(MemoryState.CurrentState, number);
                    //return MemoryState.CurrentState - number;
                }
                case "*":
                {
                    return Mult(MemoryState.CurrentState, number);
                    //return MemoryState.CurrentState * number;
                }
                case "/":
                {
                    return Div(MemoryState.CurrentState, number);
                    //return MemoryState.CurrentState / number;

                }
                case "x^n":
                {
                    return NPow((double)MemoryState.CurrentState, (double)number);
                }
                case "NSQRT":
                {
                    return Root((double)MemoryState.CurrentState, (double)number);
                }

                default :
                {
                    return String.Empty;
                }
            }
        }
    }
}
