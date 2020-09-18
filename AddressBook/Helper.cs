using System;
using System.Collections.Generic;


namespace AddressBook
{
    public class Helper
    {
        Person p = null;
        Sort sort = new Sort();
        List<Person> list = new List<Person>();

        String fname = null;
        String lname, address, city, state, phone, zip;

        public void addRecord()
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
            p = new Person(fname, lname, address, city, state, phone, zip);
            list.Add(p);
            foreach (Person p in list)
            {
                Console.WriteLine(p);
            }
        }

        public void displayRecord()
        {
            //printing message 
            if (list.Count == 0)
            {
                Console.WriteLine("!!No Records!!");

            }
            else
            {
                for (int i = 0; i < list.Count; i++)
                {
                    Console.WriteLine(list[i]);
                }
            }
        }
        public void editRecord(String fname)
        {
            for (int k = 0; k < list.Count; k++)
            {
                Console.WriteLine(list);
                if (list[k].getFname().Equals(fname))
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
                                person.setAddress(address);
                                break;
                            case 2:
                                Console.WriteLine("Enter new City : ");
                                String city = Console.ReadLine();
                                person.setCity(city);
                                break;
                            case 3:
                                Console.WriteLine("Enter new State : ");
                                String state = Console.ReadLine();
                                person.setState(state);
                                break;
                            case 4:
                                Console.WriteLine("Enter new Phone : ");
                                String phone = Console.ReadLine();
                                person.setPhone(phone);
                                break;
                            case 5:
                                Console.WriteLine("Enter new Zip Code : ");
                                String zip = Console.ReadLine();
                                person.setZip(zip);
                                break;
                            case 6:
                                k = 1;
                                break;
                            default:
                                Console.WriteLine("Please Enter Valid Option");
                                break;
                        }
                        Console.WriteLine(list);
                    }
                } //end of edit() method
            }
        }
        public void deleteRecord()
        {
            int id;
            foreach (Person p in list)
            {
                Console.WriteLine("ID: #" + list.IndexOf(p) + " : " + p);

            }
            id = Console.Read();
            Console.WriteLine("\nEnter #ID to delete Contact : ");
            list.RemoveAt(id);
        }
        public void sortRecord()
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
                if (person.getFname().Equals(fname))
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

    

     