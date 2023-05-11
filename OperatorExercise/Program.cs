namespace OperatorExercise
{
    public class Program
    {

        public static double AreaOfCircle(double radius)
        {
            var area = Math.PI * Math.Pow(radius, 2);

            return area;
        }

        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;

            int quotient = a / b;
            int remainder = a % b;

            if (a == 17 && b == 4)

            Console.WriteLine($"17/4 is {a / b} remainder {a % b}");


            Console.WriteLine("What is the radius of your circle?");

            var userInput = Console.ReadLine();

            var radius = double.Parse(userInput);

            Console.WriteLine($"The area of a circle with the radius of {userInput} is {AreaOfCircle(radius)}");


        }

    }

}