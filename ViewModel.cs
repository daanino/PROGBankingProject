using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public partial class ViewModel : ObservableObject
{
    public ObservableCollection<Account> Accounts { get; set; } = new ObservableCollection<Account>(AccountRepository.GetAccounts());

    [ObservableProperty]
    string firstName;
    [ObservableProperty]
    string lastName;
    [ObservableProperty]
    double balance;

    public void LoginAccount(string username, string pass)
    {
        Account u = Accounts.FirstOrDefault(x => x.Username == username && x.Password == pass);

        firstName = u.FirstName;
        lastName = u.LastName;
        balance = u.Balance;
    }

    public void FindAccount(string username)
    {
        Account u = Accounts.FirstOrDefault(x =>x.Username == username);

        firstName = u.FirstName;
        lastName = u.LastName;
        balance = u.Balance;
    }

}