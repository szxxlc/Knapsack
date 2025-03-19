namespace ProblemPlecakowy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int capacity=0;
            int n=0;
            int seed=0;

            Console.WriteLine("Enter the capacity of the backpack:");
            capacity = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the number of elements to generate:");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the seed for generating elements:");
            seed = int.Parse(Console.ReadLine());

            Problem problem = new Problem(n, seed);
            Result result = problem.Solve(capacity);
            Console.WriteLine();
            Console.WriteLine(result.ToString());

        }
    }
}
