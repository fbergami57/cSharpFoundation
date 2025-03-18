// See https://aka.ms/new-console-template for more information
//string name = "Bob";
//Console.WriteLine(int.Parse(name));

//TryParse() a string into an int
/*
string value = "102";
int result = 0;
if (int.TryParse(value, out result))
{
   Console.WriteLine($"Measurement: {result}");
}
else
{
   Console.WriteLine("Unable to report the measurement.");
}
"Measurement: 102;"
*/

//Modify the string variable to a value that can't be parsed
string value = "bad";
int result = 0;
if (int.TryParse(value, out result))
{
    Console.WriteLine($"Measurement: {result}");
}
else
{
    Console.WriteLine("Unable to report the measurement.");
}
if (result > 0)
Console.WriteLine($"Measurement (w/ offset): {50 + result}");
/* 
1.Which technique should be used to change myInput, a string value "2.71828", into a decimal variable myInputDecimal? 

decimal.TryParse(myInput, out myInputDecimal);
Correct. Using TryParse (or Parse()) is a valid technique.

2. Consider the C# code bool success = decimal.TryParse(input, out decimal number);. Which best describes the return type of decimal.TryParse()? 

bool
Correct. TryParse() returns a bool.*/