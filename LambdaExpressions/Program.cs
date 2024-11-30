// See https://aka.ms/new-console-template for more information
using LambdaExpressions;

double Add(double a, double b)
{
    return a + b;
}

double Multiply(double a, double b)
{
    return a * b;
}


var result = DelegateCalculator.Calculate(Multiply, 4, 5);

Console.WriteLine($"Calculation result: {result.ToString()}");