using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv
{
    public class Vehicles
    {
        public Vehicles( string make, string color, int price)
        {
            Console.WriteLine($"{make}, {color}, {price}");
        }

        public int HalfPrice(int Price)
        {
            Price = Price / 2;
            return Price;
        }

        public void MakeSound()
        {
            Console.WriteLine("Vrooooom");
        }

        private string _make;
        public string Make
        {
            get
            {
                return _make;
            }
            set
            {
                _make = value;
            }
        }

        private string _color;
        public string Color
        {
            get
            {
                return _color;
            }
            set
            {
                _color = value;
            }
        }

        private int _price;
        public int Price
        {
            get
            {
                return _price;
            }
            set
            {
                _price = value;
            }
        }
    }
}
