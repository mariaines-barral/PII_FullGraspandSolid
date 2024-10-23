using System;

namespace Full_GRASP_And_SOLID
{
    public class ConsolePrinter : IPrinter
    {
        public void Print(Printable printable)
        {
            Console.WriteLine(printable.GetTextToPrint());
        }
    }
}