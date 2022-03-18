using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator
{
    public class Step2
    {
        public int Run(string input1, string input2, string ope)
        {
            var number1 = int.Parse(input1);
            var number2 = int.Parse(input2);

            var result = Calc(number1, number2, ope);

            return result;
        }

        private int Calc(int number1, int number2, string ope) => ope switch
        {
            "+" => number1 + number2,
            "-" => number1 - number2,
            "*" => number1 * number2,
            "/" => number1 / number2,
            "^" => (int)Math.Pow((double)number1, (double)number2),
            "%" => number1 % number2,
            _ => throw new ArgumentException("演算可能な演算子を指定してください。"),
        };
    }
}
