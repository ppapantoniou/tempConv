using tempConvLib;

namespace tempConv
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialise the miscellaneous variables
            const string welcome1 = "Welcome to TempConv!";
            const string afterConv = "The temperature in ";
            const string separator = "------------";
            const string goodbye = "Press any key to exit.";
            // Initialise the Input Variables
            string inputTemp;
            string inputUnit;
            double inputTempParsed;
            // Initialise the conversion variables
            string requestedUnit;
            string[] validUnits = { "celsius", "fahrenheit", "kelvin", "c", "f", "k" };
            // Initialise the output variables
            double outputRounded;
            // Write the Welcome text
            Console.WriteLine(welcome1);
            Console.WriteLine(separator);
            Console.WriteLine();
            // Main function
            Console.WriteLine("What unit do you want to convert?");
            inputUnit = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("What unit should it be converted to?");
            requestedUnit = Console.ReadLine();
            Console.WriteLine();
            try
            {
                if (validUnits.Contains(inputUnit.ToLower()))
                {
                    string inputUnitLower = inputUnit.ToLower();
                    Console.WriteLine("How many units do you have?");
                    inputTemp = Console.ReadLine();
                    Console.WriteLine();
                    if (double.TryParse(inputTemp, out inputTempParsed))
                    {
                        if ((inputUnitLower == validUnits[0] || inputUnitLower == validUnits[3]) && (requestedUnit == validUnits[1] || requestedUnit == validUnits[4]))
                        {
                            // Celsius to Fahrenheit
                            outputRounded = tempConverter.CtoF(inputTempParsed);
                            Console.WriteLine(afterConv + "degrees Fahrenheit is: " + outputRounded);

                        }
                        else if ((inputUnitLower == validUnits[1] || inputUnitLower == validUnits[4]) && (requestedUnit == validUnits[0] || requestedUnit == validUnits[3]))
                        {
                            // Fahrenheit to Celsius
                            outputRounded = tempConverter.FtoC(inputTempParsed);
                            Console.WriteLine(afterConv + "degrees Celsius is: " + outputRounded);
                        }
                        else if ((inputUnitLower == validUnits[2] || inputUnitLower == validUnits[5]) && (requestedUnit == validUnits[1] || requestedUnit == validUnits[4]))
                        {
                            // Kelvin to Fahrenheit
                            outputRounded = tempConverter.KtoF(inputTempParsed);
                            Console.WriteLine(afterConv + "degrees Fahrenheit is: " + outputRounded);
                        }
                        else if ((inputUnitLower == validUnits[1] || inputUnitLower == validUnits[4]) && (requestedUnit == validUnits[2] || requestedUnit == validUnits[5]))
                        {
                            // Fahrenheit to Kelvin
                            outputRounded = tempConverter.FtoK(inputTempParsed);
                            Console.WriteLine(afterConv + "Kelvin is: " + outputRounded);
                        }
                        else if ((inputUnitLower == validUnits[2] || inputUnitLower == validUnits[5]) && (requestedUnit == validUnits[0] || requestedUnit == validUnits[3]))
                        {
                            // Kelvin to Celsius
                            outputRounded = tempConverter.KtoC(inputTempParsed);
                            Console.WriteLine(afterConv + "degrees Celsius is: " + outputRounded);
                        }
                        else if ((inputUnitLower == validUnits[0] || inputUnitLower == validUnits[3]) && (requestedUnit == validUnits[2] || requestedUnit == validUnits[5]))
                        {
                            // Celsius to Kelvin
                            outputRounded = tempConverter.CtoK(inputTempParsed);
                            Console.WriteLine(afterConv + "Kelvin is: " + outputRounded);
                        }
                        else
                        {
                            throw new FormatException("A unit you entered is not supported or you made a typo.");
                        }
                    }
                    else
                    {
                        throw new ArgumentException("The number of units entered is not in a correct format.");
                    }
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("A unit you entered is not supported or you made a typo.");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("The number of units entered is not in a correct format.");
            }
            finally
            {
                Console.WriteLine(goodbye);
                Console.ReadKey();
            }
        }
    }
}