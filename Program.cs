using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Part_5___If_Statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int program;
            Console.WriteLine("Would you like to run program 1, 2 or 3?");
            if (Int32.TryParse(Console.ReadLine(), out program))
            {
                if (program == 1)
                {
                    Program1();
                }
                else if (program == 2)
                {
                    Program2();
                }
                else if (program == 3)
                {
                    Program3();
                }
                else
                {
                    Console.WriteLine("That wasn't an option!");
                }
            }

            // ------------------------------------------------------------------------------- ONE
            static void Program1()
            {
                Random generator = new Random();
                double fee, initialBalance, depositAmount, withdrawlAmount, billPayment, accountBalance;
                string transactionType;
                Console.WriteLine("Simple Banking Machines --");
                Console.WriteLine("");
                fee = 0.75;
                initialBalance = generator.Next(100, 150);
                Console.WriteLine("Bank of Blorb");
                Console.WriteLine("-------------");
                Thread.Sleep(500);
                Console.WriteLine("Choose one of the following: Deposit, Withdrawl, bill Payment, Account Balance");
                transactionType = Console.ReadLine().ToUpper();
            // Deposit 
                if (transactionType == "DEPOSIT")
                {
                    Thread.Sleep(250);
                    Console.WriteLine("Deposit Amount: ");
                    if (Double.TryParse(Console.ReadLine(), out depositAmount))
                    {
                        if (depositAmount < 10)
                        {
                            Console.WriteLine("The minimum deposit amount is $10");
                        }
                        else
                        {
                            accountBalance = initialBalance + depositAmount - fee;
                            accountBalance = Math.Round(accountBalance, 2);
                            Console.WriteLine($"You deposited ${depositAmount} and now have ${accountBalance} in your bank account.");
                            Thread.Sleep(1000);
                            Console.WriteLine("      Transaction Finished");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input.");
                    }
                }
            // Withdrawl
                else if (transactionType == "WITHDRAWL")
                {
                    Thread.Sleep(250);
                    Console.WriteLine("Withdrawl Amount: ");
                    if (Double.TryParse(Console.ReadLine(), out withdrawlAmount))
                    {
                        if (withdrawlAmount > initialBalance - fee)
                        {
                            Console.WriteLine("You can't take more than you have");
                            Thread.Sleep(1000);
                            Console.WriteLine("      Transaction Finished");
                        }
                        else if (withdrawlAmount < 10)
                        {
                            Console.WriteLine("The minimum withdrawl amount is $10");
                            Thread.Sleep(1000);
                            Console.WriteLine("      Transaction Finished");
                        }
                        else
                        {
                            accountBalance = initialBalance - withdrawlAmount - fee;
                            accountBalance = Math.Round(accountBalance, 2);
                            Console.WriteLine($"You withdrawled ${withdrawlAmount}, and you now have ${accountBalance} in your bank account.");
                            Thread.Sleep(1000);
                            Console.WriteLine("      Transaction Finished");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input.");
                    }
                }
            // Bill Payment
                else if (transactionType == "BILL PAYMENT")
                {
                    Thread.Sleep(250);
                    Console.WriteLine("Amount: ");
                    if (Double.TryParse(Console.ReadLine(), out billPayment))
                    {
                        if (billPayment > initialBalance - fee)
                        {
                            Console.WriteLine("You can't take more than you have");
                            Thread.Sleep(1000);
                            Console.WriteLine("      Transaction Finished");
                        }
                        else if (billPayment < 1)
                        {
                            Console.WriteLine("Minimum of $1");
                            Thread.Sleep(1000);
                            Console.WriteLine("      Transaction Finished");
                        }
                        else
                        {
                            accountBalance = initialBalance - billPayment - fee;
                            accountBalance = Math.Round(accountBalance, 2);
                            Console.WriteLine($"You took ${billPayment}, and you now have ${accountBalance} in your bank account.");
                            Thread.Sleep(1000);
                            Console.WriteLine("      Transaction Finished");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input.");
                    }
                }
            // Account Balance
                else if (transactionType == "ACCOUNT BALANCE")
                {
                    Thread.Sleep(250);
                    accountBalance = initialBalance - fee;
                    Console.WriteLine($"Your account balance is ${accountBalance}.");
                    Thread.Sleep(1000);
                    Console.WriteLine("      Transaction Finished");
                }
            // Invalid
                else
                {
                    Console.WriteLine("Invalid Input.");
                }
            }



            // ------------------------------------------------------------------------------- TWO
            static void Program2()
            {
                // user number or randomly generated number??
                Console.WriteLine("Parking Garage Cost --");
                Console.WriteLine("");
            }



            // ------------------------------------------------------------------------------- THREE
            static void Program3()
            {
                
                Console.WriteLine("Hurricane --");
                Console.WriteLine("");
                Console.WriteLine("Hurricane Intensity Scale(Saffir-Simpson");
            }

        }
    }
}