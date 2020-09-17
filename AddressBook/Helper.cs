using System;
using System.Collections;
using System.Collections.Generic;


namespace AddressBook
{
    class Helper
    {


        public void addRecord()
        {
            String fname, lname, address, city, state, phone, zip;
            Console.WriteLine("Enter First Name");
            fname = Console.ReadLine();
            Console.WriteLine("Enter Last Name");
            lname = Console.ReadLine();
            Console.WriteLine("Enter Address");
            address = Console.ReadLine();
            Console.WriteLine("Enter City");
            city = Console.ReadLine();
            Console.WriteLine("Enter State");
            state = Console.ReadLine();
            Console.WriteLine("Enter Zip");
            zip = Console.ReadLine();
            Console.WriteLine("Enter phone number");
            phone = Console.ReadLine();
            List<Person> person = new ArrayList<Person>();
            person.Add(new Person(fname, lname, address, city, state, phone, zip));
        }  
           
        }
    }

