using ConsoleCalculator;

namespace ConsoleCalculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            new Program().Run();
        }

        void Run()
        {
            Console.CancelKeyPress += new ConsoleCancelEventHandler(Console_CancelKeyPress);
            while (true)
            {
                DoCalc();
            }
        }

        void DoCalc()
        {
            Console.WriteLine("簡単な四則演算を行います。");
            Console.WriteLine();

            //Console.Write("1つ目の数字は？（入力後Enter）　：");
            //var input1 = Console.ReadLine();
            //Console.WriteLine();

            var input1 = string.Empty;
            do
            {
                Console.Write("1つ目の数字は？（入力後Enter）　：");
                input1 = Console.ReadLine();
                Console.WriteLine();
            } while (!IsNumeric(input1));

            Console.Write("2つ目の数字は？（入力後Enter）　：");
            var input2 = Console.ReadLine();
            Console.WriteLine();

            Console.Write("どの演算[+|-|*|/]を行いますか？（入力後Enter）　：");
            var ope = Console.ReadLine();
            Console.WriteLine();

            var result = new Step2().Run(input1, input2, ope);
            Console.WriteLine($"計算結果　：{result}");
            Console.ReadKey();
        }


        protected void Console_CancelKeyPress(object sender, ConsoleCancelEventArgs args)
        {
            Console.WriteLine("\n処理中断操作が行われました。");
            Console.WriteLine($"  Key pressed: {args.SpecialKey}");
        }

        static bool IsNumeric(string? target)
        {
            int result;
            if (!string.IsNullOrEmpty(target) && int.TryParse(target, out result))
            {
                return true;
            }

            Console.Write("エラー：数字を入力してください\r\n");
            return false;
        }

    }
}
