using System;

namespace AddressBook
{
    class Program
    {

        static void Main(string[] args)
          {
            Console.WriteLine("Hello Welcome To AddressBook Management");
            int choice;
            int i = 0;
            Helper help = new Helper();
           
            while (i == 0)
            {
                Console.WriteLine("--- Address Book Management ---\n");
                Console.WriteLine("\t--MENU--");
                Console.WriteLine("1: Add New Person      ");
                Console.WriteLine("2: Display Records     ");
                Console.WriteLine("3: Edit Records        ");
                Console.WriteLine("4; Delete Records      ");
                Console.WriteLine("5: Sort Records		  ");
                Console.WriteLine("6: Search Records	  ");
                Console.WriteLine("7: Exit		        \n");
                Console.WriteLine("--- Enter Your Choice---");

              String  opt = Console.ReadLine();
               choice = Convert.ToInt32(opt);

                switch (choice)
                {
                    case 1:
                        help.AddRecord();
                        break;
                    case 2:
                        help.DisplayRecord();
                        break;
                    case 3:
                        Console.WriteLine("Enter First Name To Edit Records :");
                        String firstName=Console.ReadLine();
                        help.EditRecord(firstName);
                        break;
                    case 4:
                        Console.WriteLine("Enter First Name To Delete Records :");
                        String Name = Console.ReadLine();
                        help.DeleteRecord(Name);
                        break;
                    case 5:
                        help.SortRecord();
                        break;
                    case 6:
                        help.searchInRecords();
                        break;
                    case 7:
                        i = 1;
                        break;
                    default:
                        Console.WriteLine("Please Enter Valid Option!!!");
                        break;
                }
            }
        }
    }
}
