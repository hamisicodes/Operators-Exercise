namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 5;

            int a = 17;
            int b = 4;
            int quotient = a/b;
            int remainder = a % b;


            Console.WriteLine($"{x} + {y} is: {x + y}");
            Console.WriteLine($"{x} - {y} is: {x - y}");
            Console.WriteLine($"{x} * {y} is: {x * y}");

            Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}");



        }
    }
}
