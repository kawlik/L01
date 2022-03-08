namespace L01
{
    public class Program
    {
        static public void Main()
        {
            int valSeed;
            int numItems;

            Console.WriteLine("Value of seed:");
            valSeed = int.Parse(Console.ReadLine());

            Console.WriteLine("Number of items:");
            numItems = int.Parse(Console.ReadLine());

            Problem problem = new Problem(valSeed, numItems);

            Console.WriteLine(problem.ToString());
            Console.WriteLine(problem.solveFor( 50 ));
        }
    }
}