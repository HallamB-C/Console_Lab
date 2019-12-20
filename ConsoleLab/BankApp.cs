using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleLab
{
    class BankApp
    {
        //public static void Main(string[] args)
        //{
        //    //Person p1 = new Person("Bob", 21);
        //    //Person p2 = new Person("Dave", 47);
        //    //Person p3 = new Person("Monica", 13);
        //    //Person p4 = new Person("Susy", 65);

        //    //Console.WriteLine(p1.currentAccount.CheckBalance());
        //    //Console.WriteLine(p2.currentAccount.CheckBalance());

        //    //Console.WriteLine(p1.TransferMoney(p1.currentAccount, p2.currentAccount, 500.0m));

        //    //Console.WriteLine(p1.currentAccount.CheckBalance());
        //    //Console.WriteLine(p2.currentAccount.CheckBalance());

        //    int value = 8;
        //    string binary = Convert.ToString(value, 2);
        //    Console.WriteLine(binary);
        //    Console.ReadLine();
        //}
        public class Person
        {
            public string Name { get; }
            public int Age { get; }
            public List<Account> Accounts { get; }
            public Account currentAccount;
            public Person(string name, int age)
            {
                Name = name;
                Age = age;
                currentAccount = new Account("Current Account", this, AccountType.Current);
                //Accounts.Add(new Account("Current Account", this, AccountType.Current));
            }
            public string TransferMoney(Account sender, Account recipient, decimal amount)
            {
                if (sender.TakeMoney(amount))
                {
                    recipient.AddMoney(amount);
                    return "Money sent successfully";
                }
                else
                {
                    return "Insufficient funds in your account";
                }
            }
        }
        public enum AccountType
        {
            Current,
            Savings
        }

        public class Account
        {
            public string Name { get; }
            public Person Owner { get; }
            public AccountType Type { get; }
            private decimal _Balance { get; set; }

            public Account(string name, Person owner, AccountType type)
            {
                Name = name;
                Owner = owner;
                Type = type;
                _Balance = 1000.0m;
            }
            public decimal CheckBalance()
            {
                return _Balance;
            }
            public bool TakeMoney(decimal amount)
            {
                if (_Balance - amount < 0)
                {
                    return false;
                }
                else
                {
                    _Balance = decimal.Subtract(_Balance, amount);
                    return true;
                }
            }
            public bool AddMoney(decimal amount)
            {
                _Balance = decimal.Add(_Balance, amount);
                return true;
            }
        }
    }
}
