using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CipherDecoder
{
    class Program
    {
        static void Main(string[] args)
        {
            DecodeFile decode = new DecodeFile();

            Console.WriteLine("Decode file name:");
            string fileName = Console.ReadLine();

            decode.TranslateFile(fileName);

        }
    }
}
