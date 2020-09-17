using System;

namespace AddressBook
{
    class Program
    {     
         static void Main(string[] args)
          {
            Console.WriteLine("Hello Welcome To AddressBook Management");
            Helper help = new Helper();
            help.addRecord();

        }
    }
}
