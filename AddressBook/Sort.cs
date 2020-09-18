using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    class Sort : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            return x.getFname().CompareTo(y.getFname());

        }
        public void sortByName(List <Person> p)
        {

            p.Sort(this.Compare);
            
        }
    }
}
