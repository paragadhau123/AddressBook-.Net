using System;
using System.Collections.Generic;

namespace AddressBook
{
    class Sort : IComparer<Person>
    {
        public int CompareByName(Person x, Person y)
        {
            return x.getFname().CompareTo(y.getFname());

        }
        public int CompareByCity(Person x, Person y)
        {
            return x.getCity().CompareTo(y.getCity());

        }
        public int CompareByState(Person x, Person y)
        {
            return x.getState().CompareTo(y.getState());

        }
        public int CompareByZip(Person x, Person y)
        {
            return x.getZip().CompareTo(y.getZip());

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
