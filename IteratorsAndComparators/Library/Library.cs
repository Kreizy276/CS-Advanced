using IteratorsAndComparators;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Library : IEnumerable<Book>
    {
        private List<Book> _books;

        public List<Book> Books
        {
            get => this._books;
        }

        public Library(List<Book> books)
        {
            this._books = new List<Book>(books);
        }

        public IEnumerator<Book> GetEnumerator()
        {
            
        }

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
    }
}
