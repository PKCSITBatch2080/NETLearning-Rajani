using System;

namespace Greeter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask user for their name and store it in fullName
            Console.WriteLine("Enter your full name:");
            string fullName = Console.ReadLine();

            // Ask user for their date of birth and store it in dobString
            Console.WriteLine("Enter your date of birth (YYYY/MM/DD):");
            string dobString = Console.ReadLine();

            // Parse dobString into a DateTime object
            DateTime dob = DateTime.Parse(dobString);


            // Print greeting with the user's name
            Console.WriteLine("Hello, " + fullName + "!");

            // Define another variable cFullName and initialize it with fullName in uppercase letters
            string cFullName = fullName.ToUpper();

            // Print value of cFullName to console
            Console.WriteLine("Uppercase name: " + cFullName);

            // Print user-friendly date of birth
            Console.WriteLine("Your date of birth is: " + dob.ToString("dddd, dd MMMM yyyy"));

            // Calculate age
            TimeSpan age = DateTime.Now - dob;
            int years = (int)(age.TotalDays / 365.25);
            int months = (int)((age.TotalDays % 365.25) / 30.44);
            int weeks = (int)(((age.TotalDays % 365.25) % 30.44) / 7);
            int days = (int)(((age.TotalDays % 365.25) % 30.44) % 7);

            // Print age to console
            Console.WriteLine($"Age as of now: {years} Years {months} Months {weeks} Weeks {days} Days");
        }
    }
}
