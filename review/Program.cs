using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace birth
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("please enter your name: ");
             string name = Console.ReadLine();
            Console.WriteLine("enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            DateTime today = DateTime.Today;
            int birthyear = today.Year - age;
            
            Console.WriteLine("your name is " + name + " and your birthyear is " + birthyear + ".");
            Console.ReadLine();
        }
    }
}
