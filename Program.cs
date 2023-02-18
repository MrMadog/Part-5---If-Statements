using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Part_5___If_Statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
// Program Choice 
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
            else
            {
                Console.WriteLine("Invalid Input.");
            }


            // ------------------------------------------------------------------------------- ONE
            static void Program1()
            {
                Random generator = new Random();
                double fee, initialBalance, depositAmount, withdrawalAmount, billPayment, accountBalance;
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
                            Thread.Sleep(1000);
                            Console.WriteLine("      Transaction Failed");
                        }
                        else
                        {
                            accountBalance = initialBalance + depositAmount - fee;
                            accountBalance = Math.Round(accountBalance, 2);
                            Console.WriteLine($"You deposited ${depositAmount} and now have ${accountBalance} in your bank account.");
                            Thread.Sleep(1000);
                            Console.WriteLine("      Transaction Complete");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input.");
                    }
                }
            // Withdrawal
                else if (transactionType == "WITHDRAWAL")
                {
                    Thread.Sleep(250);
                    Console.WriteLine("Withdrawl Amount: ");
                    if (Double.TryParse(Console.ReadLine(), out withdrawalAmount))
                    {
                        if (withdrawalAmount > initialBalance - fee)
                        {
                            Console.WriteLine("You can't take more than you have");
                            Thread.Sleep(1000);
                            Console.WriteLine("      Transaction Failed");
                        }
                        else if (withdrawalAmount < 10)
                        {
                            Console.WriteLine("The minimum withdrawl amount is $10");
                            Thread.Sleep(1000);
                            Console.WriteLine("      Transaction Failed");
                        }
                        else
                        {
                            accountBalance = initialBalance - withdrawalAmount - fee;
                            accountBalance = Math.Round(accountBalance, 2);
                            Console.WriteLine($"You withdrawled ${withdrawalAmount}, and you now have ${accountBalance} in your bank account.");
                            Thread.Sleep(1000);
                            Console.WriteLine("      Transaction Complete");
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
                            Console.WriteLine("      Transaction Failed");
                        }
                        else if (billPayment < 1)
                        {
                            Console.WriteLine("Minimum of $1");
                            Thread.Sleep(1000);
                            Console.WriteLine("      Transaction Failed");
                        }
                        else
                        {
                            accountBalance = initialBalance - billPayment - fee;
                            accountBalance = Math.Round(accountBalance, 2);
                            Console.WriteLine($"You took ${billPayment}, and you now have ${accountBalance} in your bank account.");
                            Thread.Sleep(1000);
                            Console.WriteLine("      Transaction Complete");
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
                    Console.WriteLine("      Transaction Complete");
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
                int minParked;

                Console.WriteLine("Parking Garage Cost --");
                Console.WriteLine("");

                Console.WriteLine("How long were you parked(In minutes): ");
                if (Int32.TryParse(Console.ReadLine(), out minParked))
                {
                    if (minParked <= 0)
                    {
                        Console.WriteLine("Invalid Input.");
                    }
                    else if (minParked <= 60)
                    {
                        Console.WriteLine("You are being charged for 1 hour: $4");
                    }
                    else if (minParked <= 120)
                    {
                        Console.WriteLine("You are being charged for 2 hours: $6");
                    }
                    else if (minParked <= 180)
                    {
                        Console.WriteLine("You are being charged for 3 hours: $8");
                    }
                    else if (minParked <= 240)
                    {
                        Console.WriteLine("You are being charged for 4 hours: $10");
                    }
                    else if (minParked <= 300)
                    {
                        Console.WriteLine("You are being charged for 5 hours: $12");
                    }
                    else if (minParked <= 360)
                    {
                        Console.WriteLine("You are being charged for 6 hours: $14");
                    }
                    else if (minParked <= 420)
                    {
                        Console.WriteLine("You are being charged for 7 hours: $16");
                    }
                    else if (minParked <= 480)
                    {
                        Console.WriteLine("You are being charged for 8 hours: $18");
                    }
                    else if (minParked < 540)
                    {
                        Console.WriteLine("You are being charged for the day: $20");
                    }
                    else
                    {
                        Console.WriteLine("You are being charged for the day: $20");
                    } 
                }
                else
                {
                    Console.WriteLine("Invalid Input.");
                }
            }



            // ------------------------------------------------------------------------------- THREE
            static void Program3()
            {

                Console.WriteLine("Hurricane --");
                Console.WriteLine("");
                Console.WriteLine("Hurricane Intensity Scale(Saffir-Simpson)");

                int num1;
                Console.WriteLine("Pick a number");
                num1 = Convert.ToInt32(Console.ReadLine());

                switch (num1)
                {
                    case < 10:
                        Console.WriteLine("Hello world");
                        break;

                    case > 10:
                        Console.WriteLine("Goodbye world");
                        break;
                }

            }

        }
    }
}