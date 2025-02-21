using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class InsufficientFundsException : Exception
{
    public InsufficientFundsException(string message) : base(message) { }
}


class BankAccountI
{
    private double balance;

    public BankAccountI(double initialBalance)
    {
        balance = initialBalance;
    }


    public void Withdraw(double amount)
    {
        if (amount < 0)
        {
            throw new ArgumentException("Withdrawal amount cannot be negative.");
        }
        if (amount > balance)
        {
            throw new InsufficientFundsException("Insufficient funds for withdrawal.");
        }

        balance -= amount;
        Console.WriteLine("Withdrawal successful. Remaining Balance: " + balance);
    }
}

class BankTransaction
{
    public static void Main()
    {
        try
        {
            Console.WriteLine("Enter initial account balance:");
            double initialBalance = double.Parse(Console.ReadLine());

            BankAccountI account = new BankAccountI(initialBalance);

            Console.WriteLine("Enter withdrawal amount:");
            double amount = double.Parse(Console.ReadLine());

            account.Withdraw(amount);
        }
        catch (InsufficientFundsException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input! Please enter a numeric value.");
        }
        finally
        {
            Console.WriteLine("Transaction attempt completed.");
        }
    }
}

