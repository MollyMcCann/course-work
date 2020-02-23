using System;

namespace Practice_if_else
{
    class Program
    {
        static void Main(string[] args)
        {
            // age warning for a game or site
            Console.Write("Please enter your age: ");
            Byte age = Byte.Parse(Console.ReadLine());
            //we have just requested Users age now we will set some rules for the age of User allowed to view content
            if (age < 14)
            {
                Console.WriteLine("Users under 14 must have a parents permission");
            }
            else
            {
                Console.WriteLine("Enjoy your Game!");
            }
            Console.Write("please enter your first number : ");
            int firstNumbr = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your second number : ");
            int secoundNumber = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the sum of {0} and  {1} : ",
                firstNumbr,secoundNumber);
            int userTotal = Int32.Parse(Console.ReadLine());

            int actualTotal = firstNumbr + secoundNumber;
            if (actualTotal == userTotal)
            {
                Console.WriteLine("You are correct!");
            }
            else
            {
                Console.WriteLine("that is incorrect, the correct total is  {0}",actualTotal);
            }

           // Console.WriteLine("10>15: {0}", 10 > 15) ; 
            Console.ReadKey();

        }
    }
}
