using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLogic
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Calculations
    {
        public double Adding(double firstNumber, double secondNumber) { return firstNumber + secondNumber; }
        public long Adding(long firstNumber, long secondNumber) { return firstNumber + secondNumber; }
        public double Substraction(double firstNumber, double secondNumber) { return firstNumber - secondNumber; }
        public long Substraction(long firstNumber, long secondNumber) { return firstNumber - secondNumber; }

        public long Multiplication(long fisrtNumber, long secondNumber) { return fisrtNumber * secondNumber; }
        public double Multiplicaton(double firstNumber, double secondNumber) { return firstNumber * secondNumber; }
        public string Division(long firstNumber, long secondNumber)
        {
            if (secondNumber != 0)
            {
                return (firstNumber / secondNumber).ToString();
            }
            return "Error:Can't divide a number by 0";
        }
        public string Division(double firstNumber, double secondNumber)
        {
            if (secondNumber != 0)
            {
                return (firstNumber / secondNumber).ToString();
            }
            return "Can't divide a number by 0";
        }
        public double SquareRoot(double number)
        {
            return Math.Round(Math.Sqrt(number), 15);
        }
        public double ByThePowerOf2(double number)
        {
            Math.Pow(number, 15);
            return number;
        }
        public double XBelow1(double number)
        {
            number = Math.Round((1 / number), 15);
            return number;
        }
        public double Operators(double firstNumber, double secondNumber, string operation)
        {
            double nothing = 0;
            switch(operation)
            {
                case "+":
                    return firstNumber+((firstNumber*secondNumber)/100);
                    break;
                case "-":
                    return firstNumber - ((firstNumber * secondNumber) / 100);
                    break;
                case "*":
                    return firstNumber * ((firstNumber * secondNumber) / 100);
                    break;
                case "/":
                    return firstNumber / ((firstNumber * secondNumber) / 100);
                    break;
            }
            return nothing;
        }
        public string MainOperation(string firstNumber, string secondNumber, string resulttxt, string operation)
        {
            if (operation != null)
            {
                secondNumber = resulttxt;
                double fn;
                double sn;
                string result = "";
                switch (operation)
                {
                    case "+":

                        double.TryParse(firstNumber, out fn);
                        double.TryParse(secondNumber, out sn);
                        double finalResult = Adding(fn, sn);
                        result = $"{finalResult}";
                        break;
                    case "-":
                        double.TryParse(firstNumber, out fn);
                        double.TryParse(secondNumber, out sn);
                        double finalResult1 = Substraction(fn, sn);
                        result = $"{finalResult1}";
                        break;
                    case "×":
                        double.TryParse(firstNumber, out fn);
                        double.TryParse(secondNumber, out sn);
                        double finalResult2 = Multiplicaton(fn, sn);
                        result = $"{finalResult2}";
                        break;
                    case "÷":
                        double.TryParse(firstNumber, out fn);
                        double.TryParse(secondNumber, out sn);
                        string finalResult3 = Division(fn, sn);
                        result = finalResult3;
                        break;
                }
                return result;

            }
            return "Error";

        }
    }
}
