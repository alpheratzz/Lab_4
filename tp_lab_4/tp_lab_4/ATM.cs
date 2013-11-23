using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace tp_lab_4
{
    class ATM
    {
        private int curr_id, acc_num;
        private UniversalAccount curr_acc;
        private List<UniversalAccount> acc_base;
        private List<int> pin_base;

        public ATM()
        {
            curr_id = 0;
            acc_num = 0;
            acc_base = new List<UniversalAccount>();
            pin_base = new List<int>();
        }

        public ATM(List<UniversalAccount> acc_base, List<int> pin_base)
        {
            curr_id = 0;
            this.acc_base = acc_base;
            this.pin_base = pin_base;
            acc_num = Math.Min(acc_base.Count, pin_base.Count);
        }

        public void StartMenu()
        {
            int pin;
            UniversalAccount tmp;
            bool f = true;
            while (f)
            {
                Console.Clear();
                Console.WriteLine("[1]Create an account\n[2]Log in\n[0]Exit");
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.D1:
                        CreateAccount();
                        break;
                    case ConsoleKey.D2:
                        Console.Write("Enter your account ID: ");
                        curr_id = int.Parse(Console.ReadLine());
                        Console.Write("Enter PIN: ");
                        pin = int.Parse(Console.ReadLine());
                        if (Login(curr_id, pin))
                        {
                            curr_acc = acc_base[curr_id - 1];
                            Console.WriteLine("You have succesfully logged in.");
                            AccountMenu();
                        }
                        else
                            Console.WriteLine("Error: wrong account ID or PIN. Access denied.");
                        break;
                    case ConsoleKey.D0:
                        f = false;
                        break;
                    default:
                        break;
                }
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey(true);
            }
        }

        private void AccountMenu()
        {
            bool f = true;
            while (f)
            {
                double amount = 0;
                Console.Clear();
                Console.WriteLine("[1]Check balance\n[2]Deposit\n[3]Withdraw\n[0]Log out");
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.D1:
                        curr_acc.CheckBalance();
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey(true);
                        break;
                    case ConsoleKey.D2:
                        Console.Write("Amount to deposit: ");
                        amount = double.Parse(Console.ReadLine());
                        curr_acc.Deposit(amount);
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey(true);
                        break;
                    case ConsoleKey.D3:
                        Console.Write("Amount to withdraw: ");
                        amount = double.Parse(Console.ReadLine());
                        DateTime paydate = DateTime.Now;
                        if (curr_acc.GetType() == Type.GetType("TimedMaturityAccount"));
                        {
                            Console.WriteLine("Enter payment date(year, month(1..12), day):");
                            paydate = new DateTime(int.Parse(Console.ReadLine()), 
                                int.Parse(Console.ReadLine()), 
                                int.Parse(Console.ReadLine()));

                        }
                        Console.WriteLine("Withdrawn amount: {0}", curr_acc.Withdraw(amount, paydate));
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey(true);
                        break;
                    case ConsoleKey.D0:
                        f = false;
                        break;
                    default:
                        break;
                }
            }
        }

        private UniversalAccount CreateAccount()
        {
            UniversalAccount acc;
            Console.Clear();
            Console.WriteLine("[1]Checking account");
            Console.WriteLine("[2]Savings account");
            Console.WriteLine("\t[3]Timed maturity account");
            Console.WriteLine("[4]Overdraft account");
            Console.WriteLine("[0]Cancel");
            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.D1:
                    acc = new CheckingAccount();
                    break;
                case ConsoleKey.D2:
                    acc = new SavingsAccount();
                    break;
                case ConsoleKey.D3:
                    acc = new TimedMaturityAccount();
                    break;
                case ConsoleKey.D4:
                    acc = new OverdraftAccount();
                    break;
                case ConsoleKey.D0:
                    acc = null;
                    break;
                default:
                    acc = null;
                    Console.WriteLine("Warning: you pressed wrong key. Account wasn't created.");
                    break;
            }
            if (acc != null)
            {
                Random r = new Random();
                acc_num++;
                acc_base.Add(acc);
                int pin = r.Next() % 10000;
                pin_base.Add(pin.GetHashCode());
                Console.WriteLine("New account was created.ID: {0}, PIN: {1}", acc_num, pin);
            }
            return acc;
        }

        private bool Login(int id, int pin)
        {
            return id <= acc_num && pin.GetHashCode() == pin_base[id - 1];
        }
    }
}
