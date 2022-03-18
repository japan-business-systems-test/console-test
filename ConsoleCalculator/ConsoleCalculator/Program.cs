using ConsoleCalculator;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var calculator = new Step2();

Console.WriteLine("簡単な四則演算を行います。");
Console.WriteLine();

Console.Write("1つ目の数字は？（入力後Enter）　：");
var input1 = Console.ReadLine();
Console.WriteLine();

Console.Write("2つ目の数字は？（入力後Enter）　：");
var input2 = Console.ReadLine();
Console.WriteLine();

Console.Write("どの演算[+|-|*|/]を行いますか？（入力後Enter）　：");
var ope = Console.ReadLine();
Console.WriteLine();

var result = calculator.Run(input1, input2, ope);

Console.WriteLine($"計算結果　：{result}");


Console.ReadKey();