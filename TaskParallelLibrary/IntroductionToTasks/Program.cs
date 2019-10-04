using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace IntroductionToTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            ////synchronous
            //Display1();
            //Display2();

            //asynchronous
            //create a task to run display 1
            Action action1 = Display1;
            Task task1 = new Task (action1);


            //create a task to run Display2
            Action action2 = Display2;
            Task task2 = new Task (action2);

            //use the factory property to creat a new task and start it using 
            //the factory.startNew method
            Action action3 = Display3;
            Task.Factory.StartNew(action3);//perferred way

            //start the task
            task1.Start();
            task2.Start();
            //============================different way================
           


            Console.ReadLine();
        }

        static void Display1()
        {
            //in a loop generate random numbers and display only 
            // the ones that are divisble by 3(any number evenly divided by 3 ex 9, 21)
            Random rand = new Random();
            for(int counter = 1; counter <=100; counter++)
            {
                int x = rand.Next(1000000, 2000000);
                //display if divisble by three
                if(x% 3 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine($"Thread ID: {Thread.CurrentThread.ManagedThreadId} "+ $"TaskID: {Task.CurrentId} counter: {counter} x: {x} ");
                }
                //slow down forloop 
                Thread.SpinWait(10000000);// to simulate a long process
            }


        }
        static void Display2()
        {
            Random rand = new Random();
            for (int counter = 1; counter <= 100; counter++)
            {
                int x = rand.Next(1000000, 2000000);
                //display if divisble by 7
                if (x % 7 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Thread ID: {Thread.CurrentThread.ManagedThreadId}" + $"TaskID: {Task.CurrentId} counter: {counter} x: {x} ");
                }
                //slow down forloop 
                Thread.SpinWait(10000000);// to simulate a long process
            }

        }
        static void Display3()
        {
            Random rand = new Random();
            for (int counter = 1; counter <= 100; counter++)
            {
                int x = rand.Next(1000000, 2000000);
                //display if divisble by 11
                if (x % 11 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine($"Thread ID: {Thread.CurrentThread.ManagedThreadId}" + $"TaskID: {Task.CurrentId} counter: {counter} x: {x} ");
                }
                //slow down forloop 
                Thread.SpinWait(10000000);// to simulate a long process
            }

        }
    }
    
}
