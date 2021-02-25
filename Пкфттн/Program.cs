using System;

namespace Пкфттн
{
    class Program
    {
        static void Main(string[] args)
        {
            Account<int> account1 = new Account<int>(1) { Sum = 10000 };
            Account<int> account2 = new Account<int>(2) { Sum = 4500 };
            Transaction<Account<int>> transaction = new Transaction<Account<int>>
            {
                FromAccount = account1,
                ToAccount=account2,
                Sum=4500
            };
            transaction.FromAccount.Sum -= transaction.Sum;
            transaction.ToAccount.Sum += transaction.Sum;
            Console.WriteLine("account1="+account1.Sum);
            Console.WriteLine("account2=" + account2.Sum);

            Account<string> account3 = new Account<string>("r1") { Sum = 15000 };
            Account<string> account4 = new Account<string>("r2") { Sum = 40500 };
            Transaction<Account<string>> transaction2 = new Transaction<Account<string>>
            {
                FromAccount = account3,
                ToAccount = account4,
                Sum = 4500
            };
            if (transaction2.FromAccount.Sum > transaction2.Sum)
            {
                transaction2.FromAccount.Sum -= transaction.Sum;
                transaction2.ToAccount.Sum += transaction.Sum;
                Console.WriteLine("account3=" + account3.Sum);
                Console.WriteLine("account4=" + account4.Sum);
            }
            else
            {
                Console.WriteLine("Денег нет");
            }
        }
    }
}
