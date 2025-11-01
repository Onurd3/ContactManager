using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager
{
    internal class DeleteNumber
    {
        public static void deletenumber()
        {
            int num = 0;
            Console.Clear();
            foreach (var item in Internal_Face.person)
            {
                num++;
                Console.WriteLine("-----{3}----- \n Name: {0} \n LastName: {1} \n Number: {2}", item.Name, item.LastName, item.Number, num);
                Console.WriteLine();
            }

            Console.WriteLine("---------------------");
            Console.Write("input the name of person you want to delete: ");
            string input = Console.ReadLine();

            var PersonToDelete = Internal_Face.person.FirstOrDefault(p => p.Name == input);
            if (PersonToDelete != null)
            {
                Internal_Face.person.Remove(PersonToDelete);
                Console.WriteLine($"{input} delete in list.");
            }
            else
            {
                Console.WriteLine($"{input} not found.");
            }
        }
    }
}
