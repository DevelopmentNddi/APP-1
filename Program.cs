using System;
using System.Windows.Forms;

namespace APP_1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int a;
            int b;
            int result = 0;
            char[] symbol = {'+','-','*','/'};
            char operation;
            while (true)
            {
                string str = Console.ReadLine();

                int indexOfOperation;
                indexOfOperation = str.IndexOfAny(symbol);
                int.TryParse(str.Substring(0, indexOfOperation), out a);
                int.TryParse(str.Substring(indexOfOperation + 1), out b);
                char.TryParse(str.Substring(indexOfOperation, 1), out operation);

                switch (operation)
                {
                    case '+': result = a + b; break;
                    case '-': result = a - b; break;
                    case '*': result = a * b; break;
                    case '/': result = a / b; break;
                }
                string res = " " + a + operation + b + "=" + result;
                Console.WriteLine(res);

                    Console.WriteLine("Если вы хотите очистить консоль нажмите <Пробел> \n");// Если хотите закрыть приложение нажмите <CapsLock> \n Если хотите провести новое вычисление нажмите любую другую клавишу ");
                    ConsoleKeyInfo KeyInfo = Console.ReadKey();
                    if (KeyInfo.Key == ConsoleKey.Spacebar)
                    {
                        Console.Clear();
                    }

            }
        }
    }
}
