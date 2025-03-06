int first = 2;
string second = "4";
string result = first + second;
Console.Clear();
Console.WriteLine(result);
Console.WriteLine("============");

int myInt = 3;
Console.WriteLine($"int: {myInt}");

decimal myDecimal = myInt;
Console.WriteLine($"decimal: {myDecimal}");
Console.WriteLine("============");

decimal myDecimal1 = 3.14m;
Console.WriteLine($"decimal: {myDecimal1}");

int myInt1 = (int)myDecimal1;
Console.WriteLine($"int: {myInt1}");
Console.WriteLine("===========");

decimal myDecimal2 = 1.23456789m;
float myFloat = (float)myDecimal2;

Console.WriteLine($"Decimal: {myDecimal2}");
Console.WriteLine($"Float: {myFloat}");
Console.WriteLine("===========");

int first1 = 5;
int second1 = 7;
string message = first1.ToString() + second1.ToString();
Console.WriteLine(message);
Console.WriteLine("===========");

string first2 = "5";
string second2 = "7";
int sum = int.Parse(first2) + int.Parse(second2);
Console.WriteLine(sum);
Console.WriteLine("===========");

string value6 = "5";
string value7 = "7";
int result1 = Convert.ToInt32(value6) * Convert.ToInt32(value7);
Console.WriteLine(result1);
Console.WriteLine("===========");

int value9 = (int)1.5m; //casting truncates
Console.WriteLine(value9);

int value10 = Convert.ToInt32(1.5m); //converting rounds up
Console.WriteLine(value10);

/*
1. Which is the best technique to convert by rounding a decimal type to an int type in C#? 

Convert
Correct. decimal to int is a narrowing conversion so to round, Convert is the best answer.

2. Which of the following conversion rounds the value (versus truncate)? 

int cost = Convert.ToInt32(3.75m);
Correct. Convert.ToInt32() rounds values with fractional precision.
*/