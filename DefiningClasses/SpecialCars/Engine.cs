﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialCars
{
    public class Engine
    {
        private int horsePower;
        private double cubicCapacity;

        public Engine(int horsePower, double cubicCapacity)
        {
            this.HorsePower = horsePower;
            this.CubicCapacity = cubicCapacity;
        }

        public int HorsePower 
        {  
            get { return horsePower; } 
            set { this.horsePower = value; } 
        }
        public double CubicCapacity 
        {  
            get { return cubicCapacity; } 
            set { this.cubicCapacity = value; } 
        }
    }
}
