using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyInter
{
    public class Canon : IPrinterWindows
    {
        public void ShowPrintDialog()
        {
            Console.WriteLine("Canon display dimension: 9.5x12");
        }

        public void ShowPrintStatus()
        {
            Console.WriteLine("Canon printer printing...");
        }
    }
}
