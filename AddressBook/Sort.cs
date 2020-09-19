using System;
using System.Collections.Generic;

namespace AddressBook
{
    class Sort : IComparer<Person>
    {
        public void searchByCity(List<Person> person)
        {
            String search;
            List<Person> matches = new List<Person>();
           Console.WriteLine("Enter City Name to search : ");
            search = Console.ReadLine();
            int flag = 0;
            foreach (Person m in person)
            {
                if (m.City.Equals(search))
                {
                    flag = 1;
                    matches.Add(m);
                }
            }
            if (flag == 1)
            {
               Console.WriteLine("...Match Found...");
                foreach (Person m in matches)
                {
                    Console.WriteLine(m);
                }
            }
            else
            {
               Console.WriteLine("!!!Match Not Found!!!");
            }
        }
        public void searchByState(List<Person> person)
        {
            String search;
            List<Person> matches = new List<Person>();
            Console.WriteLine("Enter State Name to search : ");
            search = Console.ReadLine();
            int flag = 0;
            foreach (Person m in person)
            {
                if (m.State.Equals(search))
                {
                    flag = 1;
                    matches.Add(m);
                }
            }
            if (flag == 1)
            {
                Console.WriteLine("...Match Found...");
                foreach (Person m in matches)
                {
                    Console.WriteLine(m);
                }
            }
            else
            {
                Console.WriteLine("!!!Match Not Found!!!");
            }
        }
        public int CompareByName(Person x, Person y)
        {
            return x.FirstName.CompareTo(y.FirstName);

        }
        public int CompareByCity(Person x, Person y)
        {
            return x.City.CompareTo(y.City);

        }
        public int CompareByState(Person x, Person y)
        {
            return x.State.CompareTo(y.State);

        }
        public int CompareByZip(Person x, Person y)
        {
            return x.ZipCode.CompareTo(y.ZipCode);

        }
        public void SortByName(List <Person> p)
        {

            p.Sort(this.CompareByName);
            
        }

        public void SortByCity(List<Person> p)
        {
            p.Sort(this.CompareByCity);
        }

        public void SortByState(List<Person> p)
        {
            p.Sort(this.CompareByState);
        }

        public void SortByZip(List<Person> p)
        {
            p.Sort(this.CompareByZip);
        }

        int IComparer<Person>.Compare(Person x, Person y)
        {
            throw new NotImplementedException();
        }
    }
}
