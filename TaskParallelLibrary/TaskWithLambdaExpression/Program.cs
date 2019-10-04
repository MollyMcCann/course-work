using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace TaskWithLambdaExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            //this is The skellington:
            //Action action1 = () =>
            //{

            //};
            Task.Factory.StartNew(() =>
            {

                Random rand = new Random();
                for (int counter = 1; counter <= 100; counter++)
                {
                    int x = rand.Next(1000000, 2000000);
                    //display if divisble by three
                    if (x % 3 == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine($"Thread ID: {Thread.CurrentThread.ManagedThreadId} " + $"TaskID: {Task.CurrentId} counter: {counter} x: {x} ");
                    }
                    //slow down forloop 
                    Thread.SpinWait(10000000);// to simulate a long process
                }
            });
            //==========================================
            Task.Factory.StartNew(() =>
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
            });
            //=============================================================
            Task.Factory.StartNew(() =>
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
            });
            //start a forth task that calculate and display the cubic root of all the 
            //numbers between 1000000 an 1300000
            Task.Factory.StartNew(() =>
            {
                //Random rand = new Random();
                //for (int x=1000000; x <= 1000100; x++)
                for (int x=1000000; x <= 1000100; x++)

                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    double result = Math.Pow(x, 1D / 3D);
                    Console.WriteLine($" Thread ID: {Thread.CurrentThread.ManagedThreadId}" + $"TaskID: {Task.CurrentId} x: {result}");
                }
                
            });

            Console.ReadLine();
        }
        //static void Display1() this is the method
        //{
          
        //    Random rand = new Random();
        //    for (int counter = 1; counter <= 100; counter++)
        //    {
        //        int x = rand.Next(1000000, 2000000);
        //        //display if divisble by three
        //        if (x % 3 == 0)
        //        {
        //            Console.ForegroundColor = ConsoleColor.White;
        //            Console.WriteLine($"Thread ID: {Thread.CurrentThread.ManagedThreadId} " + $"TaskID: {Task.CurrentId} counter: {counter} x: {x} ");
        //        }
        //        //slow down forloop 
        //        Thread.SpinWait(10000000);// to simulate a long process
        //    }


        //}
    }
}
