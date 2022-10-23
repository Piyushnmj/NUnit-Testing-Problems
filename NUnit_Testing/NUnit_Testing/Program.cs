namespace DayOfWeek
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter Day in numerical value: ");
            int d = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nEnter Month in numerical value: ");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nEnter Year in numerical value: ");
            int y = Convert.ToInt32(Console.ReadLine());

            int y0 = y - (14 - m) / 12;
            int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
            int m0 = m + 12 * ((14 - m) / 12) - 2;
            int d0 = (d + x + (31*m0) / 12) % 7;

            switch (d0)
            {
                case 0:
                    Console.WriteLine("\nDay of the week is SUNDAY");
                    break;
                case 1:
                    Console.WriteLine("\nDay of the week is MONDAY");
                    break;
                case 2:
                    Console.WriteLine("\nDay of the week is TUESDAY");
                    break;
                case 3:
                    Console.WriteLine("\nDay of the week is WEDNESDAY");
                    break;
                case 4:
                    Console.WriteLine("\nDay of the week is THURSDAY");
                    break;
                case 5:
                    Console.WriteLine("\nDay of the week is FRIDAY");
                    break;
                case 6:
                    Console.WriteLine("\nDay of the week is SATURDAY");
                    break;
                default:
                    Console.WriteLine("Could not compute, try again");
                    break;
            }
        Console.ReadLine();
        }
    }
}

