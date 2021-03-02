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
            
            Bank ourBank = new Bank("Assignment-Bank", 5);


            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("\t\t\t"+ourBank.Name);
                Console.WriteLine("\n1.Add New Account");
                Console.WriteLine("2.Delete Account");
                Console.WriteLine("3.Show Account Informain");
                Console.WriteLine("4.Print Account Details");
                Console.WriteLine("5.Deposit");
                Console.WriteLine("6.Withdraw");
                Console.WriteLine("7.Tranfer");
                Console.WriteLine("8.Transaction");
                Console.Write("Enter Your Choice (1 - 8) : ");
                int ch = int.Parse(Console.ReadLine());
                if (ch == 1)
                {
                    Console.Write("\nEnter Account Name: ");
                    string name = (Console.ReadLine());
                    Console.Write("Enter Intial Balance: ");
                    int  balance = int.Parse(Console.ReadLine());
                    Console.Write("Enter Road Number : ");
                    int road =int.Parse(Console.ReadLine());
                    Console.Write("Enter House Number : ");
                    int houseno = int.Parse(Console.ReadLine());
                    Console.Write("Enter City Name : ");
                    string city = Console.ReadLine();
                    Console.Write("Enter Country Name: ");
                    string country = Console.ReadLine();

                    ourBank.AddAccount(new Account(Account.lastnumber++,name, balance,new Address(road, houseno, city, country)));
                    Console.WriteLine("Account Create Successfuly for account number:"+(Account.lastnumber-1));
                    continue;

                }

                else if (ch == 2)
                {
                    Console.Write("Enter Account Number To Delete :  ");
                    int del = int.Parse(Console.ReadLine());
                    ourBank.DeleteAccount(del);
                    continue;
                }
                else if (ch == 3)
                {
                    Console.Write("Enter Account Number To Show Information :  ");
                    int acn = int.Parse(Console.ReadLine());
                    ourBank.SearchAccount(acn);
                    continue;
                }

                else if (ch == 5)
                {
                    Console.Write("\nEnter Account Number To Deposit: ");
                    int acnd = int.Parse(Console.ReadLine());
                    Console.Write("Enter Deposit Ammount : ");
                    double amount = double.Parse(Console.ReadLine());
                    ourBank.Deposit(acnd, amount);
                }
                else if (ch == 6)
                {
                    Console.Write("\nEnter Account Number To Withdraw: ");
                    int acnd = int.Parse(Console.ReadLine());
                    Console.Write("Enter Withdraw Ammount : ");
                    double amount = double.Parse(Console.ReadLine());
                    ourBank.Withdraw(acnd, amount);
                }

                else if (ch == 7)
                {
                    Console.Write("\nEnter Account Number To Transfer : ");
                    int facn = int.Parse(Console.ReadLine());
                    Console.Write("\nEnter Account Number From Transfer: ");
                    int sacn = int.Parse(Console.ReadLine());
                    Console.Write("Enter Transfer Ammount : ");
                    double amount = double.Parse(Console.ReadLine());
                    ourBank.Transfer(facn, sacn, amount);
                }


            }


        }
    }
}
