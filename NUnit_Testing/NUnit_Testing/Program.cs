class SquareRoot
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a value: ");
        double X = Convert.ToInt32(Console.ReadLine());

        double SquareRoot = Math.Sqrt(X);
        Console.WriteLine("\nThe Square Root of {0} = {1}", X, SquareRoot);
    }
}
