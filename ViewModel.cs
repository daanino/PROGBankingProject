using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public partial class ViewModel : ObservableObject
{
    public ObservableCollection<Account> Accountlist { get; set; } = new ObservableCollection<Account>(AccountRepository.GetAccounts());

    [ObservableProperty]
    string pass;
    [ObservableProperty]
    string firstName;
    [ObservableProperty]
    string lastName;
    [ObservableProperty]
    double bal;

    public void CreateAccount()
    {
        
    }
    public void FindAccount(string username)
    {
        Account u = accounts.FirstOrDefault(x => x.Username == username);
    }

}