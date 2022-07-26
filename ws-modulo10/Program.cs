
using System;
using ws_modulo10.Entities;

namespace ws_modulo10
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account(1001, "Alex", 500.0);
            //BusinessAccount businessAccount = new BusinessAccount(1002, "Maria", 0.0, 500.00);

            //Upcasting
            //Account acc1 = businessAccount; // atribuir uma subclasse para superclasse
            //Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.00);
            Account acc3 = new SavingsAccount(1004, "Joana", 500.0, 0.01);


            acc1.WithDraw(10.0);
            acc3.WithDraw(10.0);

            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc3.Balance);
            ////Downcasting
            //BusinessAccount acc4 = (BusinessAccount)acc2;
            //acc4.Loan(100.00);


            //if (acc3 is BusinessAccount)
            //{
            //    BusinessAccount acc5 = acc3 as BusinessAccount;
            //    acc5.Loan(200.00);
            //    Console.WriteLine("Loan!");
            //}

            //if (acc3 is SavingsAccount)
            //{
            //    SavingsAccount acc5 = (SavingsAccount)acc3;
            //    acc5.UpdateBalance(200.00);
            //    Console.WriteLine("Update!");
            //}




        }
    }
}
