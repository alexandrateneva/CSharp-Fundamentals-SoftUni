namespace _01.BankAccount
{
    using System;
    using System.Collections.Generic;

    public class BankAccountProgram
    {
        public static void Main()
        {
            var accounts = new Dictionary<int, global::BankAccount>();
            var input = Console.ReadLine();

            while (input != "End")
            {
                var tokens = input.Split(' ');
                switch (tokens[0])
                {
                    case "Create": Create(tokens, accounts); break;
                    case "Deposit": Deposit(tokens, accounts); break;
                    case "Withdraw": Withdraw(tokens, accounts); break;
                    case "Print": Print(tokens, accounts); break;
                }

                input = Console.ReadLine();
            }
        }

        public static void Create(string[] tokens, Dictionary<int, global::BankAccount> accounts)
        {
            var id = int.Parse(tokens[1]);
            if (accounts.ContainsKey(id))
            {
                Console.WriteLine("Account already exists");
            }
            else
            {
                var acc = new global::BankAccount();
                acc.ID = id;
                accounts.Add(id, acc);
            }

        }

        public static void Deposit(string[] tokens, Dictionary<int, global::BankAccount> accounts)
        {
            var id = int.Parse(tokens[1]);
            var amount = double.Parse(tokens[2]);
            if (accounts.ContainsKey(id))
            {
                accounts[id].Deposit(amount);
            }
            else
            {
                Console.WriteLine("Account does not exist");
            }
        }

        public static void Withdraw(string[] tokens, Dictionary<int, global::BankAccount> accounts)
        {
            var id = int.Parse(tokens[1]);
            var amount = double.Parse(tokens[2]);
            if (accounts.ContainsKey(id))
            {
                if (accounts[id].Balance < amount)
                {
                    Console.WriteLine("Insufficient balance");
                }
                else
                {
                    accounts[id].Withdraw(amount);
                }
            }
            else
            {
                Console.WriteLine("Account does not exist");
            }
        }

        public static void Print(string[] tokens, Dictionary<int, global::BankAccount> accounts)
        {
            var id = int.Parse(tokens[1]);
            if (accounts.ContainsKey(id))
            {
                Console.WriteLine(accounts[id].ToString());
            }
            else
            {
                Console.WriteLine("Account does not exist");
            }
        }
    }
}
