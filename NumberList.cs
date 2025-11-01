using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager
{
    internal class NumberList
    {
        public static void numberlist()
        {
            int num = 0;
            Console.Clear();
            foreach (var item in Internal_Face.person)
            {
                num++;
                Console.WriteLine("-----{3}----- \n Name: {0} \n LastName: {1} \n Number: {2}", item.Name, item.LastName, item.Number, num);
                Console.WriteLine();
            }
        }
    }
}
