using LambdaExpressions;

double Multiply(double a, double b)
{
    return a * b;
}

double Add(double a, double b)
{
    return a + b;
}

CalculateAction MultiplyDelegate = delegate (double a, double b)
{
    return a * b;
};


var resultMultiply = DelegateCalculator.Calculate(
    Multiply, 5, 5);

var resultAdd = DelegateCalculator.Calculate(
    Add, 15, 45);


Console.WriteLine($"Calculation result: {resultMultiply.ToString()}");
Console.WriteLine($"Calculation result: {resultAdd.ToString()}");


// Exercise Example

var testList = new List<string> { "", "one", "two", null };

var numberList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

bool NumberIsEven(int input)
{
    return (input % 2 == 0);
}

bool StringNotNullOrEmptyCondition(string input)
{
    return !string.IsNullOrEmpty(input);
}


bool StringContainsLetter(string input)
{
    return !string.IsNullOrEmpty(input);
}



var filteredStringList = ListFilter.Filter(StringNotNullOrEmptyCondition, testList);
var filteredNumberList = ListFilter.FilterNumbers(NumberIsEven, numberList);


foreach(var item in filteredStringList)
{
    Console.WriteLine($"item: {item}");
}

foreach (var item in filteredNumberList)
{
    Console.WriteLine($"even number: {item}");
}

// pass the function directly to the ListFilter methods without previously declaring it using a delegate
// (anonymous function)
var filteredStringList1 = ListFilter.Filter( 
    delegate (string input) {
      return !string.IsNullOrEmpty(input);    
    }, 
    testList);


var result1 = DelegateCalculator.Calculate(
    delegate (double a, double b) { 
        return a + b; 
    }, 
    4, 5);

//// change to lambda expression
///
var result2 = DelegateCalculator.Calculate(
    (double a, double b) =>
    {
        if (a == 0 || b == 0) return 0;
        return a * b;
    },
    4, 5);

// transform back previous Lambda Expression to a delegate
List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

var filteredNumbers = numbers.Where(delegate (int n) { return n > 5; }).ToList();




//Console.WriteLine($"Calculation result: {result1.ToString()}");
//Console.WriteLine($"Calculation result: {result2.ToString()}");
//Console.WriteLine($"Calculation result: {result4.ToString()}");