using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ViewModel
{

    public List<Account> Accounts { get; set; }
    public int attempts { get; set; } = 3;
    public string firstName { get; set; }
    public string lastName { get; set; }
    public decimal balance { get; set; }
    public Account LoggedInAccount { get; private set; }
    public Account FoundAccount { get; private set; }
    public ViewModel()
    {
        Accounts = new AccountRepository().GetAccounts();
    }

    public void LoginAccount(string username, string password)
    {
        LoggedInAccount = Accounts.FirstOrDefault(x => x.Username == username && x.Password == password);
        if (LoggedInAccount != null)
        {
            firstName = LoggedInAccount.FirstName;
            lastName = LoggedInAccount.LastName;
            balance = LoggedInAccount.Balance;
        }
    }

    public void FindAccount(string username)
    {
        FoundAccount = Accounts.FirstOrDefault(x =>x.Username == username);

        if (FoundAccount != null)
        {
            firstName = FoundAccount.FirstName;
            lastName = FoundAccount.LastName;
            balance = FoundAccount.Balance;
        }
    }

}