using System;
using System.Collections.Generic;

namespace AddressBook
{
    public class Helper
    {
         Person person = null;
         Sort sort = new Sort();
         List<Person> list = new List<Person>();

         String fname = null;
         String lname, address, city, state, phone, zip;

        public void AddRecord()
        {
            int i = 0;
            while (i == 0)
            {
                Console.WriteLine("Enter First Name");
                fname = Console.ReadLine();
                //Checking for duplicates
                if (CheckExist(fname))
                {
                    Console.WriteLine("Record with name " + fname + " already exist!!\nPlease enter another name");
                }
                else
                {
                    i = 1;
                }
            }
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
            person = new Person(fname, lname, address, city, state, phone, zip);
            list.Add(person);
           
        }

        public void DisplayRecord()
        {
           
            if (list.Count == 0)
            {
                Console.WriteLine("!!No Records!!");

            }
            else
            {
                foreach (Person k in list)
                {
                    Console.WriteLine(k);
                }
            }
        }
        public void EditRecord(String fname)
        {
            for (int k = 0; k < list.Count; k++)
            {
                if (list[k].FirstName.Equals(fname))
                {
                    Person person = list[k];
                    Console.WriteLine(person);
                    while (k == 0)
                    {
                        Console.WriteLine("What You Want to edit...\n"
                                + "\t1: Address\n"
                                + "\t2: city\n"
                                + "\t3: State\n"
                                + "\t4: Phone\n"
                                + "\t5: Zip Code\n"
                                + "\t6. Save And Exit\n");
                        String option = Console.ReadLine();
                        int choice = Convert.ToInt32(option);
                        switch (choice)
                        {
                            case 1:
                                Console.WriteLine("Enter new Street : ");
                                String address = Console.ReadLine();
                                person.Address=address;
                                break;
                            case 2:
                                Console.WriteLine("Enter new City : ");
                                String city = Console.ReadLine();
                                person.City=city;
                                break;
                            case 3:
                                Console.WriteLine("Enter new State : ");
                                String state = Console.ReadLine();
                                person.State=state;
                                break;
                            case 4:
                                Console.WriteLine("Enter new Phone : ");
                                String phone = Console.ReadLine();
                                person.PhoneNo=phone;
                                break;
                            case 5:
                                Console.WriteLine("Enter new Zip Code : ");
                                String zip = Console.ReadLine();
                                person.ZipCode=zip;
                                break;
                            case 6:
                                k = 1;
                                break;
                            default:
                                Console.WriteLine("Please Enter Valid Option");
                                break;
                        }
                        foreach (Person t in list)
                        {
                            Console.WriteLine(t);
                        }
                    }
                } //end of edit() method
            }
        }
        public void DeleteRecord(string firstName)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].FirstName.Equals(firstName))
                {
                    list.Remove(person);
                }
            }
        }
        public void SortRecord()
        {
            Console.WriteLine("Sort By...\n"
                + "1: First Name\n"
                + "2: City\n"
                + "3: State\n"
                + "4: Zip Code\n"
                + "5: Back");
            String option = Console.ReadLine();
            int choice = Convert.ToInt32(option);
            switch (choice)
            {
                case 1:
                    sort.sortByName(list);
                    break;
                case 2:
                    sort.sortByCity(list);
                    break;
                case 3:
                    sort.sortByState(list);
                    break;
                case 4:
                    sort.sortByZip(list);
                    break;
                case 5:
                    return;
                    break;
                default:
                    Console.WriteLine("Please Enter Valid Option...");
                    break;
            }
        }
        public bool CheckExist(string fname)
        {
            int flag = 0;
            foreach (Person person in list)
            {
                if (person.FirstName.Equals(fname))
                {
                    flag = 1;
                    break;
                }
            }
            if (flag == 1)
            {
                return true;
            }
            return false;
        }
    }
}



