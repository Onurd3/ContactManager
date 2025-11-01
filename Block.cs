using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager
{
    internal class Block
    {
        public static List<Person> Blocks = new List<Person>();
        public static void block()
        {
            Console.Clear();
            int num = 0;
            Console.Clear();
            foreach (var item in Internal_Face.person)
            {
                num++;
                Console.WriteLine("-----{3}----- \n Name: {0} \n LastName: {1} \n Number: {2}", item.Name, item.LastName, item.Number, num);
                Console.WriteLine();
            }


            Console.WriteLine("-------------------------");
            Console.Write("Enter the name of the person you want to block: ");
            string input = Console.ReadLine();

            Person block = Internal_Face.person.FirstOrDefault(x => x.Name.Trim().ToUpper() == input.Trim().ToUpper());
            if (block != null)
            {
                Blocks.Add(block);
                Internal_Face.person.Remove(block);
                Console.WriteLine("Successfully Blocked");
            }
            else
            {
                Console.WriteLine("Not Found");
            }
        }
    }
}
