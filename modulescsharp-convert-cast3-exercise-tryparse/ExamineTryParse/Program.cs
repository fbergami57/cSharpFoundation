namespace ExamineTryParse
{
    public class Program
    {
        public Program()
        {
                    //Program.cs(3,14): error CS0029: Cannot implicitly convert type 'string' to 'int'
            /*int first1 = 2;
            string second = "4";
            int result = first1 + second;
            Console.WriteLine(result);*/

            //The variable "result" is of type int, 
            // but the variable "second" is of type string. 
            // The operator "+" is not defined for the types int and string. 
            // To fix this error, you can convert the string to an int before performing the addition. 
            // You can use the int.Parse method to convert the string to an int.
            int first = 2;
            string second = "4";
            string result = first + second;
            Console.WriteLine(result);

            //Question: Is it possible that attempting to change the value's data type would result in a loss of information?
            int myInt = 3;
            Console.WriteLine($"int: {myInt}");

            decimal myDecimal = myInt;
            Console.WriteLine($"decimal: {myDecimal}");

            //Perform a cast to convert the decimal back to an int.
            decimal myDecimal1 = 3.14m;
            Console.WriteLine($"decimal: {myDecimal}");

            int myInt2 = (int)myDecimal;
            Console.WriteLine($"int: {myInt}");

            //Determine if your conversion is a "widening conversion" or a "narrowing conversion"
            //"conversão ampliada" ou uma "conversão restritiva"
            decimal myDecimal3 = 1.23456789m;
            float myFloat3 = (float)myDecimal3;

            Console.WriteLine($"Decimal: {myDecimal3}");
            Console.WriteLine($"Float  : {myFloat3}");

            //Performing Data Conversions
            //Use a helper method on the variable
            //Use a helper method on the data type
            //Use the Convert class' methods

            //Use ToString() to convert a number to a string
            Console.Clear();
            int first4 = 5;
            int second4 = 7;
            string message = first4.ToString() + second4.ToString();
            Console.WriteLine(message);

            //Convert a string to an int using the Parse() helper method
            string first5 = "5";
            string second5 = "7";
            int sum = int.Parse(first5) + int.Parse(second5);
            Console.WriteLine(sum);

            //Convert a string to a int using the Convert class
            string value6 = "5";
            string value7 = "7";
            int result7 = Convert.ToInt32(value6) * Convert.ToInt32(value7);
            Console.WriteLine(result7);

            //Compare casting and converting a decimal into an int
            Console.Clear();
            int value8 = (int)1.5m; // casting truncates
            Console.WriteLine(value8);

            int value9 = Convert.ToInt32(1.5m); // converting rounds up
            Console.WriteLine(value9);

            /*1. Which is the best technique to convert by rounding a decimal type to an int type in C#? 
            Convert
            Correct. decimal to int is a narrowing conversion so to round, Convert is the best answer.

            2. Which of the following conversion rounds the value (versus truncate)? 
            int cost = Convert.ToInt32(3.75m);
            Correct. Convert.ToInt32() rounds values with fractional precision.
            */
        }
        
    }

}