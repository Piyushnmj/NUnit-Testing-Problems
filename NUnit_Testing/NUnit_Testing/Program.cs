namespace VendingMachine
{
    class Program
    {
        public static void countCurrency(int amount)
        {
            int[] notes = new int[] { 1000, 500, 100, 50, 20, 10, 5, 2, 1 };
            int[] noteCounter = new int[9];

            for (int i = 0; i < 9; i++)
            {
                if (amount >= notes[i])
                {
                    noteCounter[i] = amount / notes[i];
                    amount = amount % notes[i];
                }
            }

            Console.WriteLine("Currency Count: ");
            for (int i = 0; i < 9; i++)
            {
                if (noteCounter[i] != 0)
                {
                    Console.WriteLine(notes[i] + " : " + noteCounter[i]);
                }
            }
        }

        public static void Main()
        {
            Console.WriteLine("Enter amount: ");
            int amount = Convert.ToInt32(Console.ReadLine());
            countCurrency(amount);
        }
    }
}

