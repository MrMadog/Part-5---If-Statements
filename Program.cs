using System.Runtime.CompilerServices;

namespace Part_5___If_Statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();

            // ------------------------------------------------------------------------------- ONE

            double fee, initialBalance;
            string transactionType;
            Console.WriteLine("Simple Banking Machines");
            fee = 0.75;
            initialBalance = generator.Next(100, 150);
            Console.WriteLine("Bank of Blorb");
            //Console.WriteLine($"Your bank balance is: ${initialBalance}");
            Console.WriteLine("Transactions Available: Deposit, Withdrawl, bill payment, account balance");
            Console.WriteLine("Pick one");
            transactionType = Console.ReadLine().ToUpper();
            Console.WriteLine(transactionType);

        }
    }
}