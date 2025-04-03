Console.WriteLine("a" == "a"); //true
Console.WriteLine("a" == "A"); //false
Console.WriteLine(1 == 2); //false

string myValue = "a";
Console.WriteLine(myValue == "a"); //true


string value1 = " a";
string value2 = "A ";
Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower()); //false

Console.WriteLine();

Console.WriteLine("a" != "a"); //false
Console.WriteLine("a" != "A"); //true
Console.WriteLine(1 != 2); //true

String myValue1 = "a";
Console.WriteLine(myValue1 != "a"); //false

Console.WriteLine(1 > 2); //false
Console.WriteLine(1 < 2); //true
Console.WriteLine(1 >= 1); //true
Console.WriteLine(1 <= 1); //true


string pangram = "The quick brown fox jumps over the lazy dog.";
Console.WriteLine(pangram.Contains("fox")); //true
Console.WriteLine(pangram.Contains("cow")); //false

Console.Clear();
//These two lines of code will create the same output
Console.WriteLine(pangram.Contains("fox") == false); //false
Console.WriteLine(!pangram.Contains("fox")); //false

//Inequality operator versus logical negation
Console.Clear();
int a = 7;
int b = 6;
Console.WriteLine(a != b); //true
string s1 = "Hello";
string s2 = "Hello";
Console.WriteLine(s1 != s2); //false
