using System;
using System.Collections.Generic;

namespace AddressBook
{
    class Sort : IComparer<Person>
    {
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
        public void sortByName(List <Person> p)
        {

            p.Sort(this.CompareByName);
            
        }

        public void sortByCity(List<Person> p)
        {
            p.Sort(this.CompareByCity);
        }

        public void sortByState(List<Person> p)
        {
            p.Sort(this.CompareByState);
        }

        public void sortByZip(List<Person> p)
        {
            p.Sort(this.CompareByZip);
        }

        int IComparer<Person>.Compare(Person x, Person y)
        {
            throw new NotImplementedException();
        }
    }
}
