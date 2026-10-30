using System;

namespace PackageExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Mandatory opening greeting line
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // 2. Prompt for package weight
            Console.WriteLine("Please enter the package weight:");
            int weight = Convert.ToInt32(Console.ReadLine());

            // 3. Reject if weight is over 50
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                return; 
            }

            // 4. Prompt for width
            Console.WriteLine("Please enter the package width:");
            int width = Convert.ToInt32(Console.ReadLine());

            // 5. Prompt for height
            Console.WriteLine("Please enter the package height:");
            int height = Convert.ToInt32(Console.ReadLine());

            // 6. Prompt for length
            Console.WriteLine("Please enter the package length:");
            int length = Convert.ToInt32(Console.ReadLine());

            // 7. Reject if combined dimensions are over 50
            int totalDimensions = width + height + length;
            if (totalDimensions > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                return; 
            }

            // 8 & 9. Calculate product formula: (height * width * length * weight) / 100
            int volume = height * width * length;
            double quote = (volume * weight) / 100.0;

            // 10. Display quote formatted as currency
            Console.WriteLine($"Your estimated total for shipping this package is: ${quote:F2}");
            Console.WriteLine("Thank you!");
        }
    }
}