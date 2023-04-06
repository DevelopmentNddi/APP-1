// See https://aka.ms/new-console-template for more information

using NddiMathCalculator;
using NddiMathCalculator.Services;

while (true)
{
    Console.WriteLine( "Введите ваш пример");
    string str = Console.ReadLine();

    IMathCalculator calculator = new FromStringMathCalculator();

    var result = calculator.Calculate(str);

    Console.WriteLine("Если вы хотите очистить консоль нажмите <Пробел> \nЕсли хотите закрыть приложение нажмите <Escape> \nЕсли хотите провести новое вычисление нажмите <Enter> ");
    ConsoleKeyInfo KeyInfo = Console.ReadKey();
    if (KeyInfo.Key == ConsoleKey.Spacebar)
    {
        Console.Clear();
    }
    else if (KeyInfo.Key == ConsoleKey.Escape) { return; }
    else if(KeyInfo.Key == ConsoleKey.Enter){ continue; }

}