using System;

namespace APP_1
{
    internal class Program
    {

        static void Main(string[] args)
        {
             while (true)
             {
                string strExpression = Console.ReadLine();
                MathCalculator calculator = new MathCalculator();
                calculator.calculate(strExpression);    
                calculator.ToString();
                Console.WriteLine("If you want clear console press <Space>\nIf you want exit press <Escape>\nIf you want to calculate again press <Enter>");
                ConsoleKeyInfo KeyInfo = Console.ReadKey();
                if (KeyInfo.Key == ConsoleKey.Spacebar) { Console.Clear(); }
                else if (KeyInfo.Key == ConsoleKey.Escape) { return; }
                else if (KeyInfo.Key == ConsoleKey.Enter) { continue; }
             }
            
        }
    }
}
