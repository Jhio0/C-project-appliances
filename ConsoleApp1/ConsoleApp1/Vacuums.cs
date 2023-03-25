using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Vacuums : 
    {
        public int Grade { get; set; }
        public int Battery { get; set; }
        public int Voltage { get; set; }

        public Vacuums(int itemnumber, string brand, int quantity, double wattage, string color, double price, int numberofdooors, double height, double width) : base(itemnumber, brand, quantity, wattage, color, price)
        {
            this.NumberOfDoors = itemnumber;
            this.Height = height;
            this.Width = width;
        }

    }
}
