using System;
using System.Collections.Generic;
using System.Collections;
using RandomListNameSpace;

namespace Third_Training_Tasks
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            /*
             * Перша частина завдання
            Person person = new Person();

            person.AddPerson(new Person() { Name = " Tom ", Age = 20, PhoneNumber = new List<string>() { "098 064", "094 456" } });
            person.AddPerson(new Person() { Name = " Bill ", Age = 21, PhoneNumber = new List<string>() { "123 043", "038 093" } });
            person.AddPerson(new Person() { Name = " Sam ", Age = 22, PhoneNumber = new List<string>() { "789 342", "458 932" } });

            person.AddPersons(new Person() { Name = " John ", Age = 23, PhoneNumber = new List<string>() { "064 021", "012 984" } },
                new Person() { Name = " Zack ", Age = 24, PhoneNumber = new List<string>() { "017 454", "034 888" } },
                new Person() { Name = " Henry ", Age = 25, PhoneNumber = new List<string>() { "000 982", "983 127" } });

            person.IntoduceAll();
            */
            // Друга частина завдання
            RandomList rand = new RandomList();
            rand.Runer();
            rand.Introduce();
        }

       
    }

    class Person
    {
        List<Person> people = new List<Person>();

        public string Name { get; set; }
        public int Age { get; set; }
        public IEnumerable<string> PhoneNumber { get; set; }

        public void IntoduceAll()
        {
            foreach (var p in people)
            {
                Console.WriteLine($"I'm {p.Name}, and I'm {p.Age} year old. My phone numbers is -> ");
                foreach (var i in p.PhoneNumber)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public void AddPerson(Person person)
        {
            people.Add(person);
        }

        public void AddPersons(params Person[] persons)
        {
            people.AddRange(persons);
        }
    }
}
