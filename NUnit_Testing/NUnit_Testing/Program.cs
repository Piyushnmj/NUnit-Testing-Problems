namespace SwapNibbles
{
    class Program
    {
        // Function for swapping   
        static int swapNibbles(int x)
        {
            return ((x & 0x0F) << 4 | (x & 0xF0) >> 4);
        }

        public static void Main()
        {
            Console.WriteLine("Enter a Number to Swap: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nSwapped Number is: {0}",swapNibbles(x));
        }
    }
}

