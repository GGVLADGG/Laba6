using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6Work2
{
    class PlayerItem : IMedia
    {
        public PlayerItem()
        {
            DisplayInfo();
        }
        public static void DisplayInfo()
        {
            Console.WriteLine("Директория файла: " + IMedia.path);
        }
    }
}
