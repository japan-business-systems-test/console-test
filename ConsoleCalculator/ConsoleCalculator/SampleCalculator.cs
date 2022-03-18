using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator
{
    public class SampleCalculator
    {
        public int Calc(int input1, int input2, string ope)
        {
            if (string.IsNullOrEmpty(ope))
            {
                throw new InvalidOperationException($"パラメータ `ope` がnullまたは空です. (ope={ope})");
            }

            int result = 0;

            switch (ope)
            {
                case "+":
                    result = input1 + input2;
                    break;
                case "-":
                    result = input1 - input2;
                    break;
                case "/":
                    result = input1 / input2;
                    break;
                case "*":
                    result = input1 * input2;
                    break;
                default:
                    throw new NotImplementedException("四則演算以外はサポートしていません。");
            }

            return result;
        }
    }
}
