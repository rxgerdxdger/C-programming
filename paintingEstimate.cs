using System;
using static System.Console;
using System.Globalization;
class PaintingEstimate
{
    static void Main()
    {
        int length, width;
        double paintCost;
        Write("Enter the length of the room: ");
        length = Convert.ToInt32(ReadLine());
        Write("Enter the width of the room: ");
        width = Convert.ToInt32(ReadLine());
        paintCost = ComputeCost(length, width);
        WriteLine(String.Format("The cost for painting the room"+" is: ${0:0,0.00}", paintCost));
      
    }

    public static double ComputeCost(int length, int width)     
    {
        int height = 9;
        double area_to_paint =
        (length * height * 2) + ( 2 * width * height);
        double cost_to_paint = 6.0 * area_to_paint;
        return cost_to_paint;
    }
}
