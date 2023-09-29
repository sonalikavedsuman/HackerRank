namespace MultiplicationTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.Write("Enter the value of n: ");
            n = Convert.ToInt32(Console.ReadLine().Trim());


            int result;
            for (int i = 1; i <= 10; i++)
            {
                result = n * i;
                Console.WriteLine($"{n} x {i} = {result}");
            }


            Console.ReadKey();

        }
    }
}