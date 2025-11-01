using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager
{
    internal class AddSpeedDial
    {
        public static List<Person> SpeedDial = new List<Person>();

        public static void speeddial()
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
            Console.Write("Enter the name of the person you want to add to 'Speed Dial': ");
            string input = Console.ReadLine() ?? string.Empty;

            Person? foundPerson = Internal_Face.person.FirstOrDefault(p => p.Name.Trim().ToLower() == input.Trim().ToLower());
            if (foundPerson != null)
            {
                SpeedDial.Add(foundPerson);
                Console.WriteLine("Successfully added:");
            }
            else
            {
                Console.WriteLine("Not found");
            }
        }
    }
}
