using PolyInter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
    public static void Main(string[] args)
    {
        IPrinterWindows printer;

        Console.WriteLine("Pilih Printer:");
        Console.WriteLine("1. Epson");
        Console.WriteLine("2. Canon");
        Console.WriteLine("3. LaserJet\n");

        Console.WriteLine("Nomor Printer [1..3]: ");
        int nomorPrinter = Convert.ToInt32(Console.ReadLine());

        if (nomorPrinter == 1)
            printer = new Epson();
        else if (nomorPrinter == 2)
            printer = new Canon();
        else
            printer = new LaserJet();

        printer.ShowPrintDialog();
        printer.ShowPrintStatus();

        Console.ReadLine();
    }
}

