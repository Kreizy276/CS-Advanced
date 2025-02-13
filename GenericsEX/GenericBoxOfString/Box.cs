using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxOfStrings
{
    public class Box<T>
    {
        private T _element;

        public Box(T element)
        {
            this._element = element;
        }

        public override string ToString()
        {
            return $"{typeof(T)}: {_element}";
        }
    }
}
