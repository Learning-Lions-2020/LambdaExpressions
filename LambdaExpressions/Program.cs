// See https://aka.ms/new-console-template for more information
using LambdaExpressions;

double Multiply(double a, double b)
{
    return a * b;
}

CalculateAction MultiplyDelegate = delegate (double a, double b)
{
    return a * b;
};


var result1 = DelegateCalculator.Calculate(
    delegate (double a, double b) { return a + b; }, 
    4, 5);

// change to lambda expression
var result2 = DelegateCalculator.Calculate(
    (double a, double b) => a + b,
    4, 5);


var result3 = DelegateCalculator.Calculate(
    MultiplyDelegate,4,5);

Console.WriteLine($"Calculation result: {result1.ToString()}");
Console.WriteLine($"Calculation result: {result2.ToString()}");