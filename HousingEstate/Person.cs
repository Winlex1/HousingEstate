
using System;
using System.Collections.Generic;
using System.Text;

namespace HousingEstate
{
    class Person
    {
        private string firstname;
        private string lastname;
        private int age;
        public Person(string firstname, string lastname, int age)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.age = age;
        }
        public override string ToString()
        {
            return String.Format($"The age of the person is {age} and his name is {firstname} {lastname}");
        }
    }
}