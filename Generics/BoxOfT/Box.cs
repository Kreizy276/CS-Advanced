using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxOfT
{
    public class Box<T>
    {
        private List<T> data = new List<T>();

        public int Count { get => data.Count; }

        public void Add(T element)
        {
            data.Add(element);
        }

        public T Remove()
        {
            T lastElementToRemove = data.Last();
            data.RemoveAt(data.Count - 1);
            return lastElementToRemove;
        }
    }
}
