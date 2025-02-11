using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Family
    {
        private readonly List<Person> _members = new();

        public void AddMember(Person person)
        {
            this._members.Add(person);
        }

        public Person GetOldestMember()
        {
            return this._members.MaxBy(x => x.Age);
        }
    }
}
