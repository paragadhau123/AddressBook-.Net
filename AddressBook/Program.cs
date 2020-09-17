﻿using System;

namespace AddressBook
{
    class Program
    {
        private static string fname;

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
                Console.WriteLine("4: Exit		        \n");
                Console.WriteLine("--- Enter Your Choice---");

                choice = Console.Read();

                switch (choice)
                {
                    case 1:
                        help.addRecord();
                        break;
                    case 2:
                        help.displayRecord();
                        break;
                    case 3:
                        help.editRecord(fname);
                        break;
                    case 4:
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
