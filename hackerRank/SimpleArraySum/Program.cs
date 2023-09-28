namespace SimpleArraySum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //creting a list of integers
            List<int> num = new List<int>() { 2,3,4,5};

            // Call the simpleArraySum method from the Result class
                     // className.methodName
            int sum = Result.simpleArraySum(num);

            // Display the result
            Console.WriteLine("The sum of the numbers is: " + sum);
        }
    }
}