
            //System.FormatException: 'Input string was not in a correct format.'
            //string name = "Bob";
            //Console.WriteLine(int.Parse(name));

            //TryParse() a string into an int
            /*string value = "102";
            int result = 0;
            if (int.TryParse(value, out result))
            {
                Console.WriteLine($"Measurement: {result}");
            }
            else
            {
                Console.WriteLine("Unable to report the measurement.");
            }*/

            //Use the parsed int later in code
            //Console.Clear();
            string value2 = "102";
            int result2 = 0;
            if (int.TryParse(value2, out result2))
            {
                Console.WriteLine($"Measurement: {result2}");
            }
            else
            {
                Console.WriteLine("Unable to report the measurement.");
            }
            Console.WriteLine($"Measurement (w/ offset): {50 + result2}");

            //Modify the string variable to a value that can't be parsed
            Console.Clear();
            string value3 = "bad";
            int result3 = 0;
            if (int.TryParse(value3, out result3))
            {
                Console.WriteLine($"Measurement: {result3}");
            }
            else
            {
                Console.WriteLine("Unable to report the measurement.");
            }
            if (result3 > 0)
            Console.WriteLine($"Measurement (w/ offset): {50 + result3}");
