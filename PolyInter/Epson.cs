using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyInter
{
    public class Epson : IPrinterWindows
    {
        public void ShowPrintDialog()
        {
            Console.WriteLine("Canon display dimension: 10x11");
        }

        public void ShowPrintStatus()
        {
            Console.WriteLine("Canon printer printing...");
        }    
    }
}
