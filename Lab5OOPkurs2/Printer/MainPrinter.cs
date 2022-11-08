using System;
using System.Collections.Generic;
using System.Text;

namespace Printer
{
    internal class MainPrinter
    {
        public virtual void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(value);
        }
    }
}
