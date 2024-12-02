namespace Bazele.HW
{
    public struct BankAccount
    {
        public int Id;
        public string Name;
        public decimal Value;
    }

    public struct BankManager
    {
        public List<BankAccount> BankAccounts;

        public BankManager()
        {
            BankAccounts = new List<BankAccount>();
        }

        public void AddBankAcount(string name, decimal value)
        {
            var bankAccount = new BankAccount { Id = BankAccounts.Count() + 1, Name = name, Value = value };
            BankAccounts.Add(bankAccount);
            Console.WriteLine($"Bank account with name: {name} added successfuly!");
        }

        public void DisplayAccounts()
        {
            foreach (var bankAccount in BankAccounts)
            {
                Console.WriteLine($"name: {bankAccount.Name} id: {bankAccount.Id}");
            }
        }

        public BankAccount? FindAccounts(int id)
        {
            BankAccount? account = null;
            foreach (var bankAccount in BankAccounts)
            {
                if (bankAccount.Id == id)
                {
                    account = bankAccount;
                    break;
                }
            }
            return account;
        }

        public void DeleteAccounts(int id)
        {
            BankAccount? account = null;
            foreach (var bankAccount in BankAccounts)
            {
                if (bankAccount.Id == id)
                {
                    account = bankAccount;
                    break;
                }
            }

            if (account != null)
            {
                BankAccounts.Remove((BankAccount)account);
                Console.WriteLine("Removed Succesfully");
            }
            else
            {
                Console.WriteLine("Bank account not found!");
            }
        }
    }
}
