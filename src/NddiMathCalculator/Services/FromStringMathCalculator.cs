namespace NddiMathCalculator.Services;

public class FromStringMathCalculator : IMathCalculator
{
    public static char[] SupportedOperations = new [] { '+', '-', '*', '/' };
    public int Result { get; private set; }
    
    
    public int Calculate(string expression)
    {
        int indexOfOperation = expression.IndexOfAny(SupportedOperations);
        int.TryParse(expression.Substring(0, indexOfOperation), out int a);
        int.TryParse(expression.Substring(indexOfOperation + 1), out int b);
        char.TryParse(expression.Substring(indexOfOperation, 1), out char operation);
        int result = 0;
        switch (operation)
        {
            case '+': result = a + b; break;
            case '-': result = a - b; break;
            case '*': result = a * b; break;
            case '/': result = a / b; break;
        }

        Result = result;
        return Result;
    }

    public override string ToString()
    {
        // humanazied string representation
        return base.ToString();
    }
}