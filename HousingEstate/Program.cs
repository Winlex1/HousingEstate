using System;

namespace HousingEstate
{
    class Program
    {
        static void Main(string[] args)
        {

            Person person = new Person("Alex", "Neviem", 16);
            Person person1 = new Person("Robko", "Neviem", 0);
            Person person2 = new Person("Michal", "Neviem", 12);
            Person person3 = new Person("Alex", "Neviem", 122677);

            Flat flat = new Flat(1, 2, 1);
            Console.WriteLine(person.ToString());
            flat.AddHabitant(person2);
            flat.AddHabitant(person3);
            flat.AddHabitant(person1);
            flat.PrintList();
            Console.WriteLine(flat.ToString());
        }
    }
}