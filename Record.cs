using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager
{
    public class Record
    {
        public static void record()
        {
            Console.Clear();
            Person P = new Person();
            Console.WriteLine("------------------");
            Console.Write("Input the Name of person: ");
            string EventInput1 = Console.ReadLine();
            Console.Write("Input the LastName of person: ");
            string EventInput2 = Console.ReadLine();
            Console.Write("Input the Number of person: ");
            string EventInput3 = Console.ReadLine();

            P.Name = EventInput1;
            P.LastName = EventInput2;
            P.Number = EventInput3;
            Internal_Face.person.Add(P);
            Console.WriteLine();
            Console.WriteLine("Task Added Successfully");
            Console.WriteLine("------------------");
        }
    }
}
