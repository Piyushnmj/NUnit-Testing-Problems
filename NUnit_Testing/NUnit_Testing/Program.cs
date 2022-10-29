namespace DecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Decimal Number : ");
            int num = Convert.ToInt32(Console.ReadLine());
            int i;
            int[] numberArray = new int[10]; //The Decimal numbers are the numbers whose base is 10. That means the decimal numbers range from 0 to 9.
            for (i = 0; num > 0; i++)
            {
                numberArray[i] = num % 2;
                num = num / 2;
            }
            Console.WriteLine("\nBinary Represenation of the given Number : ");
            for (i = i - 1; i >= 0; i--)
            {
                Console.Write(numberArray[i]);
            }
            Console.ReadLine();
        }
    }
}

