using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter number of accounts to manage: ");
        int n = Convert.ToInt32(Console.ReadLine());
        BankProfile[] records = new BankProfile[n];
        int count = 0;
        while (true)
        {
            Console.WriteLine("\n1. Create Account");
            Console.WriteLine("2. View Balance");
            Console.WriteLine("3. Deposit");
            Console.WriteLine("4. Withdraw");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                if (count >= n)
                {
                    Console.WriteLine("Account storage full.");
                    continue;
                }
                Console.Write("Enter Name: ");
                string name = Console.ReadLine();
                Console.Write("Enter Initial Balance: ");
                double amount = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter Account Type (Savings/Current): ");
                string type = Console.ReadLine();
                records[count] = new BankProfile(name, amount, type);
                Console.WriteLine("Account Created Successfully!");
                Console.WriteLine("Account Number: " + records[count].AccountId);
                count++;
            }
            else if (choice == 2)
            {
                Console.Write("Enter Account Number: ");
                string id = Console.ReadLine();
                bool found = false;
                foreach (var acc in records)
                {
                    if (acc != null && acc.AccountId == id)
                    {
                        Console.WriteLine("Account Holder: " + acc.HolderName);
                        Console.WriteLine("Balance: " + acc.Balance);
                        found = true;
                        break;
                    }
                }
                if (!found)
                    Console.WriteLine("Account not found.");
            }
            else if (choice == 3)
            {
                Console.Write("Enter Account Number: ");
                string id = Console.ReadLine();
                bool found = false;
                foreach (var acc in records)
                {
                    if (acc != null && acc.AccountId == id)
                    {
                        Console.Write("Enter Deposit Amount: ");
                        double amt = Convert.ToDouble(Console.ReadLine());

                        acc.AddFunds(amt);
                        found = true;
                        break;
                    }
                }
                if (!found)
                    Console.WriteLine("Account not found.");
            }
            else if (choice == 4)
            {
                Console.Write("Enter Account Number: ");
                string id = Console.ReadLine();
                bool found = false;
                foreach (var acc in records)
                {
                    if (acc != null && acc.AccountId == id)
                    {
                        Console.Write("Enter Withdrawal Amount: ");
                        double amt = Convert.ToDouble(Console.ReadLine());

                        acc.TakeFunds(amt);
                        found = true;
                        break;
                    }
                }
                if (!found)
                    Console.WriteLine("Account not found.");
            }
            else if (choice == 5)
            {
                Console.WriteLine("Exiting program");
                break;
            }
        }
    }
}