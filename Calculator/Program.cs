int number1 = 0;
int number2 = 0;

//writes (...) in console
Console.WriteLine("Give the first number");

//declare string and assign value written in console
string userinput = Console.ReadLine();
//convert string to int
number1 = int.Parse(userinput);

Console.WriteLine("Give the second number");
userinput = Console.ReadLine();
number2 =  int.Parse(userinput);

int result =  number1 + number2;

//string concatenation (... + ... + ...)
Console.WriteLine("The sum of " + number1 + " and " + number2 + " is " + result);

//string interpolation
Console.WriteLine($"The sum of {number1} and {number2} is {result}");

//can use double instead of int tu use decimals 
//int can convert to double 
//double can't convert to int