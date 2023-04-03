using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            string str = Console.ReadLine();

            int numb;
            numb = str.IndexOfAny(symbol);
            int.TryParse(str.Substring(0, numb), out a);
            int.TryParse(str.Substring(numb+1), out b);
            char.TryParse(str.Substring(numb, 1), out operation);

            switch (operation)
            {
                case '+': result = a + b; break;
                case '-': result = a - b; break;
                case '*': result = a * b; break;
                case '/': result = a / b; break;
            }

            string res = " " + a + operation + b + "=" + result;
            Console.WriteLine(res);
            Console.ReadKey( );
        }
    }
}
