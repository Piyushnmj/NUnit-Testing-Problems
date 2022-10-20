class TempConv
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please select the unit conversion from below: \n1.Celsius-Fahrenheit 2.Fahrenheit-Celsius");
        int userInput = Convert.ToInt32(Console.ReadLine());

        if (userInput == 1)
        {
            Console.WriteLine("\nEnter a value: ");
            int val1 = Convert.ToInt32(Console.ReadLine());

            int result1 = (val1 * 9 / 5) + 32;

            Console.WriteLine("\n{0} °C is {1} °F", val1, result1);
            Console.ReadLine();
        }
        else if (userInput == 2)
        {
            Console.WriteLine("\nEnter a value: ");
            int val2 = Convert.ToInt32(Console.ReadLine());

            int result2 = (val2 -32) * 5/9;

            Console.WriteLine("\n{0} °F is {1} °C", val2, result2);
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("\nInvalid Input, Try again...");
            Console.ReadLine();
        }
    }
}
