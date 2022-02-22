using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sankeladder
{
    public class ChePoOfP
    {

        public static void StartPositon()
        {
            int position = 0;
            Console.WriteLine("Current Position of a player :" + position);

            while (position <= 100)
            {
                Console.WriteLine("Reaching Position of a player = " + position);
                position++;
            }
        }
    }
}
