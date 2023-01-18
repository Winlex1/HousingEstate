using System;
using System.Collections.Generic;
using System.Text;

namespace HousingEstate
{
    class Flat
    {
        private int flatnum;
        private int area;
        private int numberOfapartments;
        public List<Person> people = new List<Person>();
        public int FlatNum
        {
            get { return flatnum; }
            set { this.flatnum = value; }
        }
        public int Area
        {
            get { return area; }
            set
            {
                this.area = value;
            }
        }
        public int NumberOfapartments
        {
            get { return numberOfapartments; }
            set { numberOfapartments = value; }
        }
        public Flat(int flatnum, int area, int numberOfapartments)
        {
            this.flatnum = flatnum;
            this.area = area;
            this.numberOfapartments = numberOfapartments;
        }
        public void AddHabitant(Person habitant)
        {
            people.Add(habitant);
        }
        public string GetInfoAboutAllHabitants()
        {
            string s = "";
            foreach (Person v in people)
            {
                s += v + "\n";
            }

            return s;
        }
        public override string ToString()
        {
            return String.Format($"Flatnum is {flatnum} , the flat's surface area is {area} and it has {numberOfapartments} apartments.");
        }
    }
}