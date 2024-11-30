// See https://aka.ms/new-console-template for more information
using LambdaExpressions;

var cityList = new List<string> { "Berlin", "Nairobi", "Mexico", "Accra" };

var filteredList = cityList.FilterByLetter( (item) => item.StartsWith("N"));


foreach (var item in filteredList)
{
    Console.WriteLine(item);
}