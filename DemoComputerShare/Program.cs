using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DemoComputerShare
{
    class Program
    {
        static void Main(string[] args)
        {
            int selectedOption;
            OptionInvoker invoker = new OptionInvoker();
            do
            {
                invoker.DisplayOption();
                Console.WriteLine("Enter 9 to exit");
                var option = Console.ReadLine();
                var selected = int.TryParse(option,out selectedOption);
                if (selected)
                {
                    var optionseleted = invoker.GetSelectionOption((SelectionEnum) selectedOption);
                    optionseleted.ExecuteOption();
                }
                else
                {
                    Console.WriteLine("Please enter a valid Option");
                }
            } while (selectedOption != 9);
            
            Console.ReadLine();
        }
    }
}
