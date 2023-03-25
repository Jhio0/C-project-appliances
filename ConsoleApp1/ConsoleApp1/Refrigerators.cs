﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Refrigerators : Appliances
    {
        public int NumberOfDoors { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }

        public Refrigerators(int itemnumber, string brand, int quantity, double wattage, string color, double price, int numberofdooors, double height, double width) : base(itemnumber, brand, quantity, wattage, color, price)
        {
            this.NumberOfDoors = itemnumber;
            this.Height = height;
            this.Width = width;
        }
       
    }
}
