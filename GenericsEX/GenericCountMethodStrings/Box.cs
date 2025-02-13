using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCountMethodStrings
{
    public class Box<T> where T : IComparable<T>
    {
        private T _value;

        public Box(T value)
        {
            this._value = value;
        }

        public int Count(List<T> list)
        {
            int count = 0;
            foreach (T item in list)
            {
                if(item.CompareTo(_value) > 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
