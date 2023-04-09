public class Account
{
    public string Username { get; set; }
    public string Password { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public decimal Balance { get; set; }

    public Account(string username, string pass, string firstName, string lastName, decimal bal)
    {
        Username = username;
        Password = pass;
        FirstName = firstName;
        LastName = lastName;
        Balance = bal;
    }
    public Account() { }

}

public class AccountRepository
{
    public List<Account> GetAccounts()
    {
        List<Account> accounts = new List<Account>()
        {
            new Account(){ Username = "daniel0102", Password = "password123", FirstName = "Daniel", LastName = "Bautista", Balance = 1.20M},
            new Account(){ Username = "musa123", Password = "SecurePassword!", FirstName = "Musa", LastName = "Khawaja", Balance = 5509305.30M},
        };
        return accounts;
    }
}