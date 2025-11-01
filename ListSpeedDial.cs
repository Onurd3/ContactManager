using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager
{
    internal class ListSpeedDial
    {
        public static void listspeeddial()
        {
            int num = 0;
            Console.Clear();
            foreach (var item in AddSpeedDial.SpeedDial)
            {
                num++;
                Console.WriteLine("-----{3}----- \n Name: {0} \n LastName: {1} \n Number: {2}", item.Name, item.LastName, item.Number, num);
                Console.WriteLine();
            }
        }
    }
}
