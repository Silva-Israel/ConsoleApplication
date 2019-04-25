using System;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // Full name and location
            string fullName;
            string location;

            Console.WriteLine("Enter your full name: ");
            fullName = Console.ReadLine();

            Console.WriteLine("Enter your location: ");
            location = Console.ReadLine();

            Console.WriteLine("My name is " + fullName + ".");
            Console.WriteLine("I am from " + location + ".");

            // How many days till Christmas
            var today = DateTime.Now;
            var christmas = new DateTime(today.Year, 12, 25);

            var daysTillChristmas = christmas - today;

            Console.WriteLine("Days until Christmas: " + daysTillChristmas.Days);

            // Code example from section 2.1 on the book
            double width, height, woodLength, glassArea;
            string widthString, heightString;

            Console.WriteLine("Enter width: ");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            Console.WriteLine("Enter height: ");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);

            woodLength = 2 * (width + height) * 3.25;

            glassArea = 2 * (width * height);

            Console.WriteLine("The length of the wood is " + woodLength + " feet.");

            Console.WriteLine("The area of the glass is " + glassArea + " square metres.");

            Console.WriteLine("Press any key to exit.");

            // Wait for key press so screen won't disappear
            Console.ReadKey();
        }
    }
}
