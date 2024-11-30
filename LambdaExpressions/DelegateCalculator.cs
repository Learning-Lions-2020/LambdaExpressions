using System.Transactions;

namespace LambdaExpressions;

// defines a delegate type that can point to a function that receives 2 double values
// and returns a double value
public delegate double CalculateAction(double firstValue, double secondValue);

internal static class DelegateCalculator
{
    public static double Calculate(CalculateAction action, double firstValue, double secondValue)
    {
        return action.Invoke(firstValue, secondValue);
    }
}

internal static class CalculatorFunc
{
    public static double Calculate(Func<double, double, double> action, double firstValue, double secondValue)
    {
        return action.Invoke(firstValue, secondValue);
    }
}
