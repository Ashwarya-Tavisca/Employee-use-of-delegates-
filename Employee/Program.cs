using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class Program
    {
       
        static void Main(string[] args)
        {
            int counter = 1;
            Employ[] Employees = new Employ[30];
            
            int ch;
            while (true)
            {
                Console.WriteLine("Enter '1' to add employee and 2 to exit.");
                int.TryParse(Console.ReadLine(), out ch);                                 //Used out
                switch (ch)
                {
                    case 1:
                        Employees[counter - 1] = new Employ(counter);
                        if (Employees[counter - 1].check == 1)
                        {
                            counter++;
                        }
                        break;
                    case 2:
                        Environment.Exit(0);
                        break;

                    default:
                        break;
                }
            }

            Console.ReadKey();
        }

    }
}
