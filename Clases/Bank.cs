namespace sprint_1_activity_3.Clases;

public class Account
{
    public string AccountNumber { get; private set; }
    public string Owner { get; private set; }
    public decimal Balance { get; private set; }

    public Account(string owner, string accountNumber)
    {
        Owner = owner;
        AccountNumber = accountNumber;
        Balance = 0;
    }

    public void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            Balance += amount;
            Console.WriteLine($"Depósito exitoso. Nuevo saldo: {Balance}");
        }
        else
        {
            Console.WriteLine("El depósito debe ser mayor a 0.");
        }
    }

    public void ShowBalance()
    {
        Console.WriteLine($"Cuenta: {AccountNumber}");
        Console.WriteLine($"Dueño: {Owner}");
        Console.WriteLine($"Saldo actual: {Balance}");
    }
}