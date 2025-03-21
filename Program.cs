namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello and welcome to this testng banking application. Are you a new user (y/n)");
            string response = Console.ReadLine();
            string userName;

            if (response == "y")
            {
                Console.WriteLine("Welcome! please create a username.");
                userName = Console.ReadLine(); 
            }
            else
            {
                Console.WriteLine("What is your username?");
                userName = Console.ReadLine();
            }
            Console.WriteLine("Welcome " + userName + "!");
            Console.ReadKey();
        }
    }
}

//Console.WriteLine("I think this is more effecient and effective at teaching how to code in VS!");

//Console.WriteLine("What is side A of the triangle?");
//double sideA = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine("What is side B of the triange?");
//double sideB = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine("The hypotenuse of the triangle should be " + Math.Sqrt((Math.Pow(sideA, 2) + Math.Pow(sideB, 2))));