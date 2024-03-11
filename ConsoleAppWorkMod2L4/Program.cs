
using System.Diagnostics.Metrics;

namespace ConsoleAppWorkMod2L4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tasks module 2 lesson 4");
            //Exercise 1
            string workerFirstName, workerLastName = "";
            uint workerAge = 0;
            char workerGender = ' '; 
            string workerIdNo = "";
            double workerNo = 0;  
            //Exercise 2
            char a = 'A';
            char b = 'B';
            char c = 'C';
            Console.WriteLine($"variable: {c}, {b}, {a}");
            //Exercise 3
            Console.WriteLine("Enter the width of rectangle:");
            int.TryParse(Console.ReadLine(), out int widthOfRect);
            Console.WriteLine("Enter the length of rectangle:");
            int.TryParse(Console.ReadLine(), out int lenghtOfRect);
            double diagonalOfRect = Math.Sqrt((Math.Pow(widthOfRect, 2) + Math.Pow(lenghtOfRect, 2)));
            Console.WriteLine($"Diagonal of the rectangle: {diagonalOfRect}");
            //Exercise 4
            int valA = 10;
            string b1 = "Dotnet's school";
            float valB = 12.5f;
            //Exercise 5
            Console.WriteLine("Please enter your personal detail");
            Console.WriteLine("Please enter your first name:");
            string userFirstName = Console.ReadLine();
            Console.WriteLine("Please enter your last name:");
            string userLastName = Console.ReadLine();
            Console.WriteLine("Please enter your phone number:");
            double userPhoneNo = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your email:");
            string userEmailAddress = Console.ReadLine();
            Console.WriteLine("Please enter your height:");
            int userHeight = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your weight:");
            int userWeight = int.Parse(Console.ReadLine());
        }
    }
}
