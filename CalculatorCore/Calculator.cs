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
        private Dictionary<string, Func<decimal, decimal, string>> computeBinaryDictionary;

        public Calculator()
        {
            MemoryState = new State();
        }

        //public decimal PI { get; } = (decimal)Math.PI;
        public string PI() => Math.PI.ToString(); // Тутпроблема, не оторбразится пока, что либо не будет введено в maindisplay

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


        //public decimal ToRadian(decimal degree) => degree * PI / 180;
        //public decimal ToDegree(decimal radian) => radian * 180 / PI;
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

        public string Add(decimal x, decimal y) => (x + y).ToString();
       
        public string Sub(decimal x, decimal y) => (x - y).ToString();
       
        public string Mult(decimal x, decimal y) => (x * y).ToString();
       
        public string Div(decimal x, decimal y) => (x / y).ToString();
       
        public string Pow(decimal number) => (number * number).ToString();
       
        public string NPow(decimal number, decimal power) => Math.Pow((double)number, (double)power).ToString();
       
        public string SquareRoot(decimal number) => Math.Sqrt((double)number).ToString();
        
        public string Root(decimal number, decimal power) => Math.Pow((double)number, 1 / (double)power).ToString();
        
        public string NaturalLog(decimal number) => Math.Log((double)number).ToString();

        public string DecimalLog(decimal number) => Math.Log10((double)number).ToString();

        public string Sin(decimal angle) => Math.Sin((double)angle).ToString();

        public string Cos(decimal angle) => Math.Cos((double)angle).ToString();

        public string Tan(decimal angle) => Math.Tan((double)angle).ToString();

        public string Ctg(decimal angle) => (1 / Math.Tan((double)angle)).ToString();

        private string Negate(decimal number) => (-number).ToString();

        private string Equal(decimal number) => ComputeBinary(number);

        private string ComputeBinary(decimal number)
        {
            if (MemoryState.Operation != null)
                return computeBinaryDictionary[MemoryState.Operation]?.Invoke(MemoryState.CurrentState, number);
            else return number.ToString();
        }

        public object Compute(object data)
        {
            Tuple<string, string> tuple = (Tuple<string, string>)data;
            decimal number;
            string operation = tuple.Item1;
            //TODO: Сократить код
            //Можно сделать словарь с ключом операция
            //Словарь<string operation, Func<decimal,string> operationResult >

            Dictionary<string, Func<decimal, string>> computeDictionary = new Dictionary<string, Func<decimal, string>>
            {
                ["SQRT"] = new Func<decimal, string>(SquareRoot),
                ["TG"] = new Func<decimal, string>(Tan),
                ["CTG"] = new Func<decimal, string>(Ctg),
                ["SIN"] = new Func<decimal, string>(Sin),
                ["x^2"] = new Func<decimal, string>(Pow),
                ["COS"] = new Func<decimal, string>(Cos),
                ["LN"] = new Func<decimal, string>(NaturalLog),
                ["LOG"] = new Func<decimal, string>(DecimalLog), //Нашел баг, если передаваемое число крайне мало, то может вывести просто "-"
                ["N!"] = new Func<decimal, string>(TrueFactorial),
                ["+/-"] = new Func<decimal, string>(Negate),
                ["="] = new Func<decimal, string>(Equal)
                //Нужно доделать PI
            };

            Dictionary<string, Func<decimal, decimal, string>> computeBinaryDictionary = new Dictionary<string, Func<decimal, decimal, string>>
            {
                ["+"] = new Func<decimal, decimal, string>(Add),
                ["-"] = new Func<decimal, decimal, string>(Sub),
                ["*"] = new Func<decimal, decimal, string>(Mult),
                ["/"] = new Func<decimal, decimal, string>(Div),
                ["x^n"] = new Func<decimal, decimal, string>(NPow),
                ["NSQRT"] = new Func<decimal, decimal, string>(Root),
                ["M+"] = new Func<decimal, decimal, string>(Add),
                ["M-"] = new Func<decimal, decimal, string>(Sub)
            };
            this.computeBinaryDictionary = computeBinaryDictionary;

            Dictionary<string, Func<string>> constantDictionary = new Dictionary<string, Func<string>>
            {
                ["PI"] = new Func<string>(PI)
            };

            if (decimal.TryParse(tuple.Item2, out number))
            {
                if (computeDictionary.ContainsKey(operation))
                {
                    return computeDictionary[operation].Invoke(number);
                }
                else if (computeBinaryDictionary.ContainsKey(operation))
                {
                    if (operation == "M+" || operation == "M-")
                    {
                        return computeBinaryDictionary[operation].Invoke(MemoryState.PeekFromMem(), number);
                    }
                    else
                    {
                        MemoryState.CurrentState = number;
                        MemoryState.SetOperation(tuple.Item1);
                        return String.Empty;
                    }
                    #region Cтарая реализация унарных операций на время тестов словаря
                    //    //case "SQRT":

                    //    //    if (decimal.TryParse(tuple.Item2, out number))
                    //    //    {

                    //    //        return SquareRoot((double)number).ToString();
                    //    //    }
                    //    //    else
                    //    //        return 0;

                    //    //case "TG":

                    //    //    if (decimal.TryParse(tuple.Item2, out number))
                    //    //    {

                    //    //        return Tan((double)number).ToString();
                    //    //    }
                    //    //    else
                    //    //        return 0;
                    //    //case "CTG":

                    //    //    if (decimal.TryParse(tuple.Item2, out number))
                    //    //    {

                    //    //        return Ctg((double)number).ToString();
                    //    //    }
                    //    //    else
                    //    //        return 0;
                    //    //case "SIN":

                    //    //    if (decimal.TryParse(tuple.Item2, out number))
                    //    //    {

                    //    //        return Sin((double)number).ToString();
                    //    //    }
                    //    //    else
                    //    //        return 0;
                    //    //case "COS":

                    //    //    if (decimal.TryParse(tuple.Item2, out number))
                    //    //    {

                    //    //        return Cos((double)number).ToString();
                    //    //    }
                    //    //    else
                    //    //        return 0;
                    //    //case "x^2":

                    //    //    if (decimal.TryParse(tuple.Item2, out number))
                    //    //    {

                    //    //        return Pow(number).ToString();
                    //    //    }
                    //    //    else
                    //    //        return 0;

                    //    //case "LN":

                    //    //    if (decimal.TryParse(tuple.Item2, out number))
                    //    //    {

                    //    //        return NaturalLog((double)number).ToString();
                    //    //    }
                    //    //    else
                    //    //        return 0;
                    //    //case "LOG":

                    //    //    if (decimal.TryParse(tuple.Item2, out number))
                    //    //    {

                    //    //        return DecimalLog((double)number).ToString();
                    //    //    }
                    //    //    else
                    //    //        return 0;
                    //    //case "N!":

                    //    //    if (decimal.TryParse(tuple.Item2, out number))
                    //    //    {

                    //    //        return Factorial(number).ToString();
                    //    //    }
                    //    //    else
                    //    //        return 0;
                    #endregion
                    #region Старые бинарные операции
                    //    case "NSQRT":

                    //        if (decimal.TryParse(tuple.Item2, out number))
                    //        {
                    //            MemoryState.CurrentState = number;
                    //            MemoryState.SetOperation(tuple.Item1);
                    //            return String.Empty;
                    //        }
                    //        else
                    //            return 0;
                    //    case "x^n":

                    //        if (decimal.TryParse(tuple.Item2, out number))
                    //        {
                    //            MemoryState.CurrentState = number;
                    //            MemoryState.SetOperation(tuple.Item1);
                    //            return String.Empty;
                    //        }
                    //        else
                    //            return 0;
                    //    case "+":
                    //        if (decimal.TryParse(tuple.Item2, out number))
                    //        {

                    //            MemoryState.CurrentState = number;
                    //            MemoryState.SetOperation(tuple.Item1);
                    //            return String.Empty;
                    //        }
                    //        else
                    //            return String.Empty;
                    //    case "+/-":
                    //        if (decimal.TryParse(tuple.Item2, out number))
                    //        {

                    //            return Calculator.Negate(number);
                    //        }
                    //        else
                    //            return String.Empty;
                    //    case "-":
                    //        if (decimal.TryParse(tuple.Item2, out number))
                    //        {

                    //            MemoryState.CurrentState = number;
                    //            MemoryState.SetOperation(tuple.Item1);
                    //            return String.Empty;
                    //        }
                    //        else
                    //            return String.Empty;
                    //    case "*":
                    //        if (decimal.TryParse(tuple.Item2, out number))
                    //        {

                    //            MemoryState.CurrentState = number;
                    //            MemoryState.SetOperation(tuple.Item1);
                    //            return String.Empty;
                    //        }
                    //        else
                    //            return String.Empty;
                    //    case "/":
                    //        if (decimal.TryParse(tuple.Item2, out number))
                    //        {

                    //            MemoryState.CurrentState = number;
                    //            MemoryState.SetOperation(tuple.Item1);
                    //            return String.Empty;
                    //        }
                    //        else
                    //            return String.Empty;
                    //    case "=":
                    //        if (decimal.TryParse(tuple.Item2, out number))
                    //        {
                    //            return ComputeBinary(number);
                    //        }
                    //        else
                    //            return 0;
                    //    default:
                    //        return String.Empty;
                    //}
                    //Изначально вот этой строки: else return computeBinaryDictionary[MemoryState.Operation].Invoke(MemoryState.CurrentState, number);  --- не было
                    #endregion
                }
                else return constantDictionary[operation].Invoke();
            }
            else return String.Empty;           
        }
        #region Старое вычисление бинарных операций через знак "="
        //private object ComputeBinary(decimal number)
        //{
        //    switch(MemoryState.Operation)
        //    {
        //        case "+":
        //        {
        //            return Add(MemoryState.CurrentState, number);
        //        }
        //        case "-":
        //        {
        //            return Sub(MemoryState.CurrentState, number);
        //        }
        //        case "*":
        //        {
        //            return Mult(MemoryState.CurrentState, number);
        //        }
        //        case "/":
        //        {
        //            return Div(MemoryState.CurrentState, number);
        //        }
        //        case "x^n":
        //        {
        //            return NPow((double)MemoryState.CurrentState, (double)number);
        //        }
        //        case "NSQRT":
        //        {
        //            return Root((double)MemoryState.CurrentState, (double)number);
        //        }

        //        default :
        //        {
        //            return String.Empty;
        //        }
        //    }

        //}
        #endregion
    }
}
