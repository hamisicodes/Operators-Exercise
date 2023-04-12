namespace OperatorExercise
{
    public class Program
    {
        public static void CalculateAreaOfCircle(){
            Console.WriteLine("what is the radius of your circle?");
            var radius = double.Parse(Console.ReadLine());
            var area = Math.PI * Math.Pow(radius, 2);

            Console.WriteLine($"The area of a circle with radius {radius} is {area}");
            Console.WriteLine("Press any key to continue...");
        }
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

            CalculateAreaOfCircle();



        }
    }
}
