using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawData
{
    public class Engine
    {
        public Engine(int speed, int horsePower)
        {
            Speed = speed;
            HorsePower = horsePower;
        }

        public int Speed { get; set; }
        public int HorsePower { get; set; }
    }
}
