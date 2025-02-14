using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorsAndComparators
{
    public class Book
    {
        private string _title;
        private int _year;
        private List<string> _authors;

        public string Title
        {
            get => this._title;
            set => this._title = value;
        }
        public int Year
        {
            get => this._year;
            set => this._year = value;
        }

        public List<string> Author
        {
            get => this._authors;
            set => this._authors = value;
        }

        public Book(string title, int year, List<string> author)
        {
            this._title = title;
            this._year = year;
            this._authors = author.ToList();
        }
    }
}
