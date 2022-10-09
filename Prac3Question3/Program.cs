using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prac3Question3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare Variables
            int plotLength;
            int plotWidth, houseLength, houseWidth, plotArea, houseArea, grassArea;

            // Accept user input
            Console.Write("Please type in length of plot: ");
            plotLength = int.Parse(Console.ReadLine());
            Console.Write("Please type in width of plot: ");
            plotWidth = int.Parse(Console.ReadLine());
            Console.Write("Please type in length of house: ");
            houseLength = int.Parse(Console.ReadLine());
            Console.Write("Please type in width of house: ");
            houseWidth = int.Parse(Console.ReadLine());

            // Calculation
            plotArea = plotLength * plotWidth;
            houseArea = houseLength * houseWidth;
            grassArea = plotArea - houseArea;

            //Output
            Console.WriteLine(); //Blank line
            Console.WriteLine("Area to be mowed:{0}",grassArea);

            Console.ReadLine();
        }
    }
}
