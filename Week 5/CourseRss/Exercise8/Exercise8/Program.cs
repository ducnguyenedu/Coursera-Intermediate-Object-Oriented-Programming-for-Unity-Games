using System;

namespace Exercise8
{
    /// <summary>
    /// Exercise 8
    /// </summary>
    class Program
    {
        /// <summary>
        /// Exercise 8
        /// </summary>
        /// <param name="args">command-line args</param>
        static void Main(string[] args)
        {
            // get birth month and day
            Console.Write("In what month were you born? ");
            string birthMonth = Console.ReadLine();
            Console.Write("On what day were you born? ");
            int birthDay = int.Parse(Console.ReadLine());

            // print birthday
            Console.WriteLine();
            Console.WriteLine("Your birthday is " + birthMonth + " " + birthDay);

            // print reminder message
            Console.WriteLine("You'll receive a reminder on " + birthMonth + " " + (birthDay - 1));

            Console.WriteLine();
        }
    }
}
