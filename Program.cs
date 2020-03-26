using System;

namespace rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetCursorPosition(35, 4);
            Console.Write("------------------");
            string topLine= Console.ReadLine();

            Console.SetCursorPosition(35, 6);
            Console.Write("------------------");
            string BottomLine = Console.ReadLine();

            Console.SetCursorPosition(35, 5);
            Console.Write("|");
            string Lside = Console.ReadLine();

            Console.SetCursorPosition(53, 5);
            Console.Write("|");
            string Rside = Console.ReadLine();

            Console.SetCursorPosition(40, 5);
            Console.Write("Molly");
            string MyName = Console.ReadLine();
        }
    }
}
