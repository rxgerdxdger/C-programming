using System;
using static System.Console;
class Tables
{
    static int method1()
    {
        int n = 1;
        while (n > 0)
        {
            WriteLine("Enter number of chairs >> ");
            n = Convert.ToInt32(ReadLine());
            if (n < 2)
            {
                WriteLine("You must order atleast two chairs.");
            }
            else
            {
                break;
            }
        }
        return n;
    }
    static string method2()
    {
        string s = " ";
        while (s.Length > 0)
        {
            WriteLine("Enter type of wood - p,m or o >> ");
            s = ReadLine();
            if (s == "p" || s == "m" || s == "o")
            {
                break;
            }
            else
            {
                WriteLine("You have entered an invalid wood type");
            }
        }
        return s;
    }
    static double method3(int n, string t)
    {
        if (t == "p")
        {
            return 250 + (n * 50);
        }
        else if (t == "m") return 300 + (n * 50);
        else return 350 + (n * 50);
    }
    static void method4(double total, int n, string t)
    {
        if (t == "p")
        {
            WriteLine("You have ordered a pine table with " + n + " chairs");
            WriteLine("Total price is $" + total);
        }
        else if (t == "m")
        {
            WriteLine("You have ordered a maple table with " + n + " chairs");
            WriteLine("Total price is $" + total);
        }
        else
        {
            WriteLine("You have ordered other table with " + n + " chairs");
            WriteLine("Total price is $" + total);
        }
    }
    static void Main()
    {
        int n;
        string t;
        double total;
        n = method1();
        t = method2();
        total = method3(n, t);
        method4(total, n, t);
    }
}