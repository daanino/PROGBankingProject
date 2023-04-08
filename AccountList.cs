public class Account
{
    public string Username { get; set; }
    public string Password { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public double Balance { get; set; }

    public Account(string username, string pass, string firstName, string lastName, double bal)
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
            new Account(){ Username = "daniel0102", Password = "password123", FirstName = "Daniel", LastName = "Bautista", Balance = 1.20},
            new Account(){ Username = "musa123", Password = "SecurePassword!", FirstName = "Musa", LastName = "Khawaja", Balance = 5509305.30},
        };
        return accounts;
    }
}