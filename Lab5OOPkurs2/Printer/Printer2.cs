using System;
using System.Collections.Generic;
using System.Text;

namespace Printer
{
    internal class Printer2 : MainPrinter
    {
        public override void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(value);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
