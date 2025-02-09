using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._FilterByAge;

internal class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        List<Person> people = new List<Person>();

        for(int i = 1; i <= n; i++)
        {
            string[] namesAndAge = Console.ReadLine().Split(", ");
            string name = namesAndAge[0];
            int personAge = int.Parse(namesAndAge[1]);

            Person person = new Person(name, personAge);

            people.Add(person);
        }

        string condition = Console.ReadLine();
        int age = int.Parse(Console.ReadLine());

        Func<Person, bool> filter = GetFilter(condition, age);
        people = people.Where(filter).ToList();

        string format = Console.ReadLine();
        Action<Person> printer = CreatePrinter(format);

        foreach(var person in people)
        {
            printer(person);
        }
    }

    static Func<Person, bool> GetFilter(string condition, int age)
    {
        if (condition == "older") return x => x.Age >= age;
        else return x => x.Age < age;
    }

    static Action<Person> CreatePrinter(string format)
    {
        if (format == "name age") return person => Console.WriteLine($"{person.Name} - {person.Age}");
        if (format == "name") return person => Console.WriteLine($"{person.Name}");
        else return person => Console.WriteLine($"{person.Age}");
    }
}

class Person
{
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
    public string Name { get; set; }
    public int Age { get; set; }
}
