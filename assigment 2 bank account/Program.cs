using System;

namespace assigment_2_bank_account
{
    class Program
    {
        static void Main(string[] args)
        {
            account ankit = new account("ankit", 23132123);
            Console.WriteLine(ankit.Chechbalance());
            Console.WriteLine(ankit.withdrawmoney(10));
            Console.WriteLine(ankit.depositmoney(100));
        }
    
    }
}
