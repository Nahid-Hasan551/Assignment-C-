using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Address address1 = new Address(4,10,"Dhaka");
            //Account account1 = new Account(1001, "Shakib", 2000, address1);
            //account1.PrintAccount();

            //Account account2 = new Account(1002,"Tamim",3000,new Address(7,20,"Chittagong"));
            //account2.PrintAccount();

            Bank ourBank = new Bank("Developer's bank", 5);
            ourBank.AddAccount(new Account(8, "Shakib", 2000, new Address(4, 10, "Dhaka", "Bangladesh")));


            //ourBank.PrintAllAccounts();

            //   Bank ourBank = new Bank("Developer's bank", 5);
            //  ourBank.AddAccount(new Account(1001, "Shakib", 2000, new Address(4, 10, "Dhaka")));

            //ourBank.PrintAllAccounts();
            //ourBank.DeleteAccount(8);

            for (int i = 1; i <= 10; i++)
            {

                Console.WriteLine("1.Add");
                Console.WriteLine("2.Delete");
                Console.WriteLine("3.Show Account Informain");
                Console.WriteLine("4.Print AllAccount");
                int ch = int.Parse(Console.ReadLine());
                if (ch == 1)
                {
                    Console.Write("Enter AC Name  To Create ");

                    string name = (Console.ReadLine());
                    Console.Write("Enter AC Balance  To Create ");

                    int  balance = int.Parse(Console.ReadLine());

                    Console.Write("Enter Roadnumber  To Create ");

                    int road =int.Parse(Console.ReadLine());





                    ourBank.AddAccount(new Account(Account.lastnumber++,name, balance, new Address(4, 10, "Dhaka", "Bangladesh")));
                    Console.WriteLine("Account Create Successfuly for account number:"+(Account.lastnumber-1));

                    continue;
                   

                }

                else if (ch == 2)
                {
                    Console.Write("Enter AC No For Show Account Inforamtion:  ");
                    int del = int.Parse(Console.ReadLine());
                    ourBank.DeleteAccount(del);
                    continue;
                }
                else if (ch == 3)
                {
                    Console.Write("Enter AC No For Show Account Inforamtion:  ");
                    int acn = int.Parse(Console.ReadLine());
                    ourBank.SearchAccount(acn);
                    break;
                }
            }


        }
    }
}
