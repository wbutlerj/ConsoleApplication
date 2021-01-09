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
        {
            var name = "Weston Jones";
            var location = "Rexburg, ID";

            Console.WriteLine($"My name is {name}");
            Console.WriteLine($"I am from {location}");

            var currentDate = DateTime.Now;
            Console.WriteLine("The current date is " + currentDate.ToString("d"));

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();



            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
