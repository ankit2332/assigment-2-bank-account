using System;
using System.Collections.Generic;
using System.Text;

namespace assigment_2_bank_account
{
    class account
    {
        private string name;
        private double balance;

        public account(string name, double balance)
        {
            this.name = name;
            this.balance = balance;
        }

        public double Chechbalance()
        {
            return balance;
        }

        public double withdrawmoney(double Moneyout)
        {
            if (Moneyout > balance)
            {
                Console.WriteLine("you don't have money in you're account");
                    return 0;
            }
            else if(Moneyout > 0)
            {
                Console.WriteLine("Withdraw successful!");
                balance = balance - Moneyout;
            }
            else
            {
                Console.WriteLine("scam!");
            }
            return balance;
        }
        public double depositmoney(double Moneyin)
        {
            if (Moneyin > 0)
            {
                Console.WriteLine("money added");
                balance = balance + Moneyin;
            }
            else
            {
                Console.WriteLine("scam, do you want me to take your money out???:");
            }
            return balance;
        }

        public double AddInterest(double InterestRate)
        {
            string date = DateTime.Now.ToShortDateString();
            Console.WriteLine(date);
            if (date == "12/01/2021")
            {
                balance = balance * InterestRate;
            }
            return balance;
        }
            
    }
}