﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawData
{
    public class Tires
    {
        public Tires(double pressure, int age)
        {
            Pressure = pressure;
            Age = age;
        }

        public double Pressure { get; set; }
        public int Age {  get; set; }
    }
}
