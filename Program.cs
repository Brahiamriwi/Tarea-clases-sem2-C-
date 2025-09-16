using System;
using BankApp;
using sprint_1_activity_3.Clases;
using System.Collections.Generic;

List<Person> students = new List<Person>();

bool next = true;

while (next)
{
    Person person = new Person();

    Console.WriteLine("Ingresa el nombre completo del estudiante: ");
    person.Name = Console.ReadLine();

    Console.WriteLine("Ingresa la edad del estudiante: ");
    person.Age = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Ingresa el grado del estudiante: ");
    person.Grade = Convert.ToInt32(Console.ReadLine());

    students.Add(person);

    Console.WriteLine("¿Quieres agregar otro estudiante? (s/n): ");
    string answer = Console.ReadLine().ToLower();
    if (answer != "s")
    {
        next = false;
    }
}

Console.WriteLine("LISTA DE ESTUDIANTES");
foreach (var student in students)
{
    Console.WriteLine(student.StudentInfo());
}


// Second part - Bank accounts

namespace BankApp
{
    class Program
    {
        static List<Account> accounts = new List<Account>();
        static Random rnd = new Random();

        static void Main()
        {
            bool running = true;

            while (running)
            {
                Console.WriteLine("--- MENÚ BANCO ---");
                Console.WriteLine("1. Abrir una nueva cuenta");
                Console.WriteLine("2. Consultar saldo");
                Console.WriteLine("3. Depositar dinero");
                Console.WriteLine("4. Salir");
                Console.Write("Opción: ");
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        OpenAccount();
                        break;
                    case "2":
                        CheckBalance();
                        break;
                    case "3":
                        DepositMoney();
                        break;
                    case "4":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }
        }

        static void OpenAccount()
        {
            Console.Write("Ingresa el nombre del dueño: ");
            string owner = Console.ReadLine();

            // Generar número aleatorio de 10 dígitos
            string accountNumber = "";
            for (int i = 0; i < 10; i++)
            {
                accountNumber += rnd.Next(0, 10).ToString();
            }

            Account newAccount = new Account(owner, accountNumber);
            accounts.Add(newAccount);

            Console.WriteLine($"Cuenta creada con éxito.");
            Console.WriteLine($"Número: {accountNumber}");
            Console.WriteLine($"Dueño: {owner}");
            Console.WriteLine("Saldo inicial: 0");
        }

        static void CheckBalance()
        {
            Console.Write("Ingresa el número de cuenta: ");
            string number = Console.ReadLine();

            Account acc = accounts.Find(a => a.AccountNumber == number);
            if (acc == null)
            {
                Console.WriteLine("La cuenta no existe.");
            }
            else
            {
                acc.ShowBalance();
            }
        }

        static void DepositMoney()
        {
            Console.Write("Ingresa el número de cuenta: ");
            string number = Console.ReadLine();

            Account acc = accounts.Find(a => a.AccountNumber == number);
            if (acc == null)
            {
                Console.WriteLine("La cuenta no existe.");
                return;
            }

            Console.Write("Monto a depositar: ");
            decimal amount = Convert.ToDecimal(Console.ReadLine());

            acc.Deposit(amount);
        }
    }
}
