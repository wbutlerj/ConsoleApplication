using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApplication
{
    class Program
    {

        static void Main(string[] args)
        {   //2
            var name = "Weston Jones";
            var location = "Rexburg, ID";
            //3
            Console.WriteLine($"My name is {name}");
            Console.WriteLine($"I am from {location}");
            //4
            var currentDate = DateTime.Now;
            Console.WriteLine("The current date is " + currentDate.ToString("d"));
            //5 number of days until christmas
            var day =  (359 - currentDate.DayOfYear );
            Console.WriteLine("There are " + day.ToString("d") + " days until Christmas! (If you see a negative number then Christmas has already passed this year.)");
            
            //6
            double width, height, woodLength, glassArea;
            string widthString, heightString;

            Console.WriteLine("Please input a valid width number");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            Console.WriteLine("Please input a valid height number");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);

            woodLength = 2 * (width + height) * 3.25;

            glassArea = 2 * (width * height);

            Console.WriteLine("The length of the wood is " +
            woodLength + " feet");
            Console.WriteLine("The area of the glass is " +
            glassArea + " square metres");

            //pause the console
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();

        }
    }
}
