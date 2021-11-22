using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6Work3
{
    interface IWhatDo 
    {
        static void Work()
        {
            Console.Write(" Работает");
        }
        static void Study()
        {
            Console.Write(" Учиться");
        }
    }
}
