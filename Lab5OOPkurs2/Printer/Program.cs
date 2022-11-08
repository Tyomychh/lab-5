using System;

namespace Printer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MainPrinter printer = new MainPrinter();
            printer.Print("прiнтер");
            Printer2 inherancePrinter = new Printer2();
            inherancePrinter.Print("ПРIНТЕР");
        }
    }
}
