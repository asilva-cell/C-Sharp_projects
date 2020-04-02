using System;

namespace MyBank
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BanckAccount("Adriana", 10000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance}.");

            account.MakeWithdrawal(120, DateTime.Now, "Groceries");
            Console.WriteLine($"Your new balance is {account.Balance}.");

            account.MakeDeposit(3120, DateTime.Now, "Tax Return");
            Console.WriteLine($"Your new balance is {account.Balance}.");


            Console.WriteLine(account.GetAccountHistory());

            ////check that initial balance must be >0 - IF YIU CATCH IT, IT KEEPS RUNNING
            //try
            //{
            //    var invalidAcc = new BanckAccount("invalid", -10000);
            //}
            //catch (ArgumentOutOfRangeException e)
            //{
            //    Console.WriteLine("Exception caught: You're creating an account with negative balance.");
            //    Console.WriteLine(e.ToString());

            //}

            ////This still runs: IF YIU CATCH IT, IT KEEPS RUNNING
            //account.MakeWithdrawal(100, DateTime.Now, "Shoes");
            //Console.WriteLine($"Your new balance is {account.Balance}.");


        }
    }
}
