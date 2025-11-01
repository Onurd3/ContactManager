using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager
{
    public class Program
    {

        public static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("-------------------------");
                Console.WriteLine("1- Input the number");
                Console.WriteLine("2- The numbers");
                Console.WriteLine("3- Delete a number");
                Console.WriteLine("4- Add the speed dial");
                Console.WriteLine("5- Speed dial");
                Console.WriteLine("6- Block");
                Console.WriteLine("7- Blocked");
                Console.WriteLine("8- Exit");
                Console.WriteLine("-------------------------");

                int input;
                if (!int.TryParse(Console.ReadLine(), out input))
                {
                    Console.WriteLine("Invalid input, please enter a number.");
                    continue;
                }

                switch (input)
                {
                    case 1:
                        Record.record();
                        break;
                    case 2:
                        NumberList.numberlist();
                        break;
                    case 3:
                        DeleteNumber.deletenumber();
                        break;
                    case 4:
                        AddSpeedDial.speeddial();
                        break;
                    case 5:
                        ListSpeedDial.listspeeddial();
                        break;
                    case 6:
                        Block.block();
                        break;
                    case 7:
                        BlockList.blocklist();
                        break;
                    case 8:
                        Console.WriteLine("Pls press the enter");
                        return;
                }
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }
    }
}
