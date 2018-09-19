using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace peer_activity
{
    class Program
    {
        static void Main(string[] args)
        {
            //Comments
            int Age;
            //Hello world
            Console.WriteLine("Hello enter your age");
            Age = Convert.ToInt16(Console.ReadLine());


            //if statement
            if (Age <=20)
            {
                Console.Write("You are under 20");
                Console.ReadLine();
            }

            else
            {
                Console.Write("You are over 20");
                Console.ReadLine();
            }

            //put for loop here....
            
        }
    }
}
