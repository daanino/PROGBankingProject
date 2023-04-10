

using System;
using Microsoft.Maui.Controls;

namespace PROGBankingProject;
public partial class MainPage : ContentPage
{
    // By Musa Khawaja
    private int attempts = 3;
    public ViewModel vm;

    public MainPage()
    {
        InitializeComponent();

        vm = new ViewModel();
    }

    private void OnLoginClicked(object sender, EventArgs e)
    {
        string username = UsernameEntry.Text;
        string password = PasswordEntry.Text;
        vm.LoginAccount(username, password);

        if (vm.LoggedInAccount != null)
        {
            var accountPage = new AccountPage(vm.LoggedInAccount);
            Navigation.PushAsync(accountPage);
        }
        else
        {
            vm.attempts--;
            if (vm.attempts > 0)
            {
                DisplayAlert("Invalid Login", $"You have {vm.attempts} attempts left.", "OK");
            }
            else
            {
                DisplayAlert("Invalid Login", "You have no more attempts left.", "OK");
            }
        }
    }

    private void OnCreatePasswordClicked(object sender, EventArgs e)
    {
        string newUsername = NewUsernameEntry.Text;
        string newPassword = NewPasswordEntry.Text;
        string newFirstName = NewFirstNameEntry.Text;
        string newLastName = NewLastNameEntry.Text;

        Account newAccount = new Account
        {
            Username = newUsername,
            Password = newPassword,
            FirstName = newFirstName,
            LastName = newLastName,
            Balance = 0
        };

        vm.Accounts.Add(newAccount); // Creates new account using credentials provided by the entries above


        DisplayAlert("Account Created", $"Your new username is: {newUsername}. Your new password is: {newPassword}.", "OK");
    }
}
