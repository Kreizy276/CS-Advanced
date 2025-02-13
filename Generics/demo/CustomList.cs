using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    public class CustomList<T>
    {
        private List<T> list = new List<T>();

        public List<T> List { get { return list; } }

        public void Add(T item)
        {
            list.Add(item);
        }

        public void Remove(T item)
        {
            list.Remove(item);
        }

        public string GetAll()
        {
            return string.Join(", ", list);
        }
    }
}
