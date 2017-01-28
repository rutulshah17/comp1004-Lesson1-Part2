using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comp1004_Lesson1_Part2
{
    /// <summary>
    /// Driver class for our console aplication
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Person rutul = new Person("Rutul", 23);
            rutul.SaysHello();

            Console.WriteLine();

            Person jane = new Person("Jane", 26);
            jane.SaysHello();
        }
    }
}
