using System;


namespace APP_1
{
    internal class MathCalculator : IMathCalculator
    {
        private string strResult;

       /* public MathCalculator()
        {
            string strExpression = Console.ReadLine();
            calculate(strExpression);
        }*/

        public void calculate(string strExpression)
        {
            int firstNumber;
            int secondNumber;
            int result = 0;
            char[] symbol = { '+', '-', '*', '/' };
            char operation;

            int indexOfOperation;
            indexOfOperation = strExpression.IndexOfAny(symbol);
            int.TryParse(strExpression.Substring(0, indexOfOperation), out firstNumber);
            int.TryParse(strExpression.Substring(indexOfOperation + 1), out secondNumber);
            char.TryParse(strExpression.Substring(indexOfOperation, 1), out operation);

            switch (operation)
            {
                case '+': result = firstNumber + secondNumber; break;
                case '-': result = firstNumber - secondNumber; break;
                case '*': result = firstNumber * secondNumber; break;
                case '/': result = firstNumber / secondNumber; break;
            }
            this.strResult = " " + firstNumber + operation + secondNumber + "=" + result;
        }

        public void ToString()
        {
            Console.WriteLine(strResult);
        }
    }
}
