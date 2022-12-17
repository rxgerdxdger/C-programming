using System;
using static System.Console;
class TippingTable
{
    static void Main()
    {
        double dinnerPrice = 10.00;
        double tipRate = 0.10;
        double tip;
        const double LOWRATE = 0.10;
        const double MAXRATE = 0.25;
        const double TIPSTEP = 0.05;
        const double MAXDINNER = 100.00;
        const double DINNERSTEP = 10.00;
        const int NUM_DASHES = 40;
        WriteLine("  Price     0.10    0.15    0.20    0.25    ");
        for (int x = 0; x < NUM_DASHES; ++x)
            Write("-");
        WriteLine();
        while (dinnerPrice <= MAXDINNER)
        {
            Write("{0, 8}", dinnerPrice.ToString("C"));
            while (tipRate <= MAXRATE)
            {
                tip = dinnerPrice * tipRate;
                Write("{0, 8}", tip.ToString("F"));
                tipRate += TIPSTEP;
            }
            dinnerPrice += DINNERSTEP;
            tipRate = LOWRATE;
            WriteLine();
        }

    }
}

