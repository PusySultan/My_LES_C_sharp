using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_1
{
    internal static class Input
    {
        private static string inputLine = string.Empty;
        public static void getResulte()
        {
            Console.Write("Input: ");
            inputLine = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Hi, dear friend");
            Console.WriteLine("Tup 'esc' by exit\nTup any key by continue");
            Console.Write("Input: {0}  = {1}", inputLine, Finder.Resulte(inputLine));
        }
    }
}
