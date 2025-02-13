using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericSwapMethodStrings
{
    public class Box<T>
    {
        private T _value;
        private List<T> _list = new List<T>();

        public List<T> List
        {
            get => this._list;
            set => this._list = value;
        }

        public T Value { get; set; }

        public Box()
        {
            _list = new List<T>();
        }

        public Box(T value) : this() 
        {
            _list.Add(value);
        }

        public void Swap(int index1, int index2)
        {
            T temp = _list[index1];
            _list[index1] = _list[index2];
            _list[index2] = temp;
        }

        public override string ToString()
        {
            return $"{typeof(T)}: ";
        }
    }
}
