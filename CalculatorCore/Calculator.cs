using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorCore
{
    public class Calculator
    {
        private State MemoryState { get; set; }

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
        public string TrueFactorial(decimal number) => Factorial(number).ToString();


        public decimal ToRadian(decimal degree) => degree * PI / 180;
        public decimal ToDegree(decimal radian) => radian * 180 / PI;
        public decimal ToPercent(decimal number, decimal percent) => number / 100 * percent;

        public void AddToMem(decimal number)
        {
            MemoryState.AddToMem(number);
        }

        public object PeekFromMem()
        {
            return MemoryState.PeekFromMem();
        }

        public void ResetMemory()
        {
            MemoryState.ResetMemory();
        }

        public decimal ExtractFromMem()
        {
            return MemoryState.ExtractFromMem();
        }

        //public decimal Add(decimal x, decimal y) => x + y;
        public string Add(decimal x, decimal y) => (x + y).ToString();

        //public decimal Sub(decimal x, decimal y) => x - y;
        public string Sub(decimal x, decimal y) => (x - y).ToString();

        //public decimal Mult(decimal x, decimal y) => x * y;
        public string Mult(decimal x, decimal y) => (x * y).ToString();

        //public decimal Div(decimal x, decimal y) => x / y;
        public string Div(decimal x, decimal y) => (x / y).ToString();

        //public decimal Pow(decimal number) => number * number;
        public string Pow(decimal number) => (number * number).ToString();

        public double NPow(double number, double power) => Math.Pow(number, power);

        //public double SquareRoot(double number) => Math.Sqrt(number);
        public string SquareRoot(decimal number) => Math.Sqrt((double)number).ToString();
        public double Root(double number, double power) => Math.Pow(number, 1 / power);
        
        //public double NaturalLog(double number) => Math.Log(number);
        public string NaturalLog(decimal number) => Math.Log((double)number).ToString();

        //public double DecimalLog(double number) => Math.Log10(number);
        public string DecimalLog(decimal number) => Math.Log10((double)number).ToString();

        //public double Sin(double angle) => Math.Sin(angle);
        public string Sin(decimal angle) => Math.Sin((double)angle).ToString();

        //public double Cos(double angle) => Math.Cos(angle);
        public string Cos(decimal angle) => Math.Cos((double)angle).ToString();

        //public double Tan(double angle) => Math.Tan(angle);
        public string Tan(decimal angle) => Math.Tan((double)angle).ToString();

        //public double Ctg(double angle) => 1 / Math.Tan(angle);
        public string Ctg(decimal angle) => (1 / Math.Tan((double)angle)).ToString();



        public object Compute(object data)
        {
            Tuple<string, string> tuple = (Tuple<string, string>)data;
            decimal number;
            string operation = tuple.Item1;
            //TODO: Сократить код
            //Можно сделать словарь с ключом операция
            //Словарь<string operation, Func<decimal,string> operationResult >
            decimal.TryParse(tuple.Item2, out number); //Подумать как красиво сделать относительно всех, if на все в крайнем случае
            
            Dictionary<string, Func<decimal, string>> computeDictiounary = new Dictionary<string, Func<decimal, string>>
            {
                ["SQRT"] = new Func<decimal, string>(SquareRoot),
                ["TG"] = new Func<decimal, string>(Tan),
                ["CTG"] = new Func<decimal, string>(Ctg),
                ["SIN"] = new Func<decimal, string>(Sin),
                ["x^2"] = new Func<decimal, string>(Pow),
                ["COS"] = new Func<decimal, string>(Cos),
                ["LN"] = new Func<decimal, string>(NaturalLog),
                ["LOG"] = new Func<decimal, string>(DecimalLog), //Нашел баг, если передаваемое число крайне мало, то может вывести просто "-"
                ["N!"] = new Func<decimal, string>(TrueFactorial)
                //Нужно доделать PI, нормально сделать Factorial, решить как поступить с бинарными операциями
            };

            if(computeDictiounary.ContainsKey(operation))
            {
                return computeDictiounary[operation].Invoke(number);
            }
            else
            {
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
                            return Sub(MemoryState.PeekFromMem(), number).ToString();
                        }
                        else
                            return 0;
                    case "PI":
                        return PI;
                    #region Закоменчена старая реализация унарных операций на время тестов словаря
                    //case "SQRT":

                    //    if (decimal.TryParse(tuple.Item2, out number))
                    //    {

                    //        return SquareRoot((double)number).ToString();
                    //    }
                    //    else
                    //        return 0;

                    //case "TG":

                    //    if (decimal.TryParse(tuple.Item2, out number))
                    //    {

                    //        return Tan((double)number).ToString();
                    //    }
                    //    else
                    //        return 0;
                    //case "CTG":

                    //    if (decimal.TryParse(tuple.Item2, out number))
                    //    {

                    //        return Ctg((double)number).ToString();
                    //    }
                    //    else
                    //        return 0;
                    //case "SIN":

                    //    if (decimal.TryParse(tuple.Item2, out number))
                    //    {

                    //        return Sin((double)number).ToString();
                    //    }
                    //    else
                    //        return 0;
                    //case "COS":

                    //    if (decimal.TryParse(tuple.Item2, out number))
                    //    {

                    //        return Cos((double)number).ToString();
                    //    }
                    //    else
                    //        return 0;
                    //case "x^2":

                    //    if (decimal.TryParse(tuple.Item2, out number))
                    //    {

                    //        return Pow(number).ToString();
                    //    }
                    //    else
                    //        return 0;

                    //case "LN":

                    //    if (decimal.TryParse(tuple.Item2, out number))
                    //    {

                    //        return NaturalLog((double)number).ToString();
                    //    }
                    //    else
                    //        return 0;
                    //case "LOG":

                    //    if (decimal.TryParse(tuple.Item2, out number))
                    //    {

                    //        return DecimalLog((double)number).ToString();
                    //    }
                    //    else
                    //        return 0;
                    //case "N!":

                    //    if (decimal.TryParse(tuple.Item2, out number))
                    //    {

                    //        return Factorial(number).ToString();
                    //    }
                    //    else
                    //        return 0;
                    #endregion
                    case "NSQRT":

                        if (decimal.TryParse(tuple.Item2, out number))
                        {
                            MemoryState.CurrentState = number;
                            MemoryState.SetOperation(tuple.Item1);
                            return String.Empty;
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
                    case "+":
                        if (decimal.TryParse(tuple.Item2, out number))
                        {

                            MemoryState.CurrentState = number;
                            MemoryState.SetOperation(tuple.Item1);
                            return String.Empty;
                        }
                        else
                            return String.Empty;
                    case "+/-":
                        if (decimal.TryParse(tuple.Item2, out number))
                        {

                            return Calculator.Negate(number);
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
        }

        private static object Negate(decimal number)
        {
            return -number;
        }

        private object ComputeBinary(decimal number)
        {
            switch(MemoryState.Operation)
            {
                case "+":
                {
                    return Add(MemoryState.CurrentState, number);
                }
                case "-":
                {
                    return Sub(MemoryState.CurrentState, number);
                }
                case "*":
                {
                    return Mult(MemoryState.CurrentState, number);
                }
                case "/":
                {
                    return Div(MemoryState.CurrentState, number);
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
