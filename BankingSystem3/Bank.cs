using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem3
{
    class Bank
    {

        private string name;
        private Account[] accounts;
        public Bank(string name, int size)
        {
            this.name = name;
            accounts = new Account[size];
        }
        public string Name
        {
            set { this.name = value; }
            get { return this.name; }
        }
        public Account[] Accounts
        {
            set { this.accounts = value; }
            get { return this.accounts; }
        }

        public void PrintAllAccounts()
        {
            for (int i = 0; i < accounts.Length; i++)
            {
                if (accounts[i] == null)
                {
                    continue;
                }
                accounts[i].PrintAccount();
            }
        }
        public void AddAccount(Account account)
        {
            for (int i = 0; i < accounts.Length; i++)
            {
                if (accounts[i] == null)
                {
                    accounts[i] = account;
                    break;
                }
            }
        }
        public void SearchAccount(int accountNo)
        {
            int flag = 0;
            for (int i = 0; i < accounts.Length; i++)
            {
                if (accounts[i] == null)
                {
                    continue;
                }
                else if (accounts[i].AccountNumber == accountNo)
                {
                    accounts[i].PrintAccount();
                    flag = 0;
                    break;
                }
                else
                {
                    flag = 1;

                }
            }
            if (flag == 1)
                Console.WriteLine("Account Not Found");
        }
        public void DeleteAccount(int accountNo)
        {
            int flag = 0;
            for (int i = 0; i < accounts.Length; i++)
            {
                if (accounts[i] == null)
                {
                    continue;
                }
                else if (accounts[i].AccountNumber == accountNo)
                {
                    flag = 0;
                    for (int j = 0; j < (accounts.Length) - 1; j++)
                    {
                        accounts[j] = accounts[j + 1];


                        if (j == (accounts.Length) - 2)
                        {
                            accounts[j] = null;
                            Console.WriteLine("Account found and Deleted!\n");

                        }

                    }
                }
                else
                    flag = 1;
            }
            if (flag == 1)
                Console.WriteLine("Account not found!");
        }

        
        


    }
}
