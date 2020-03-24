using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bmi_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // excersise: compute bmi = weight/height^2 *703

            
            // 1input: read data weight and height
            Console.WriteLine( "Enter your weight:" );
            double weight = double.Parse(Console.ReadLine());
        
            Console.WriteLine("Enter your height:");
            double Height = double.Parse(Console.ReadLine());

            // process: compute bmi
            double bmi = weight * 703 / Math.Pow(Height, 2);

            // output display bmi value to one decimal point
            Console.WriteLine($"\n bmi = {bmi:f1}");
            

            //pause the console
            Console.WriteLine(" \n\nHit the 'enter' key to exit...");
            Console.ReadLine(); //dummy read
            


        }
    }
}
