

using System;
using Microsoft.Maui.Controls;

namespace PROGBankingProject;
public partial class MainPage : ContentPage
{
    private int attempts = 3;
    private string USERNAME = "username";
    private string PASSWORD = "password";

    public MainPage()
    {
        InitializeComponent();
    }

    private void OnLoginClicked(object sender, EventArgs e)
    {
        string username = UsernameEntry.Text;
        string pass = PasswordEntry.Text;

        if (username == USERNAME && pass == PASSWORD)
        {
            Navigation.PushAsync(new AccountPage());
        }
        else
        {
            attempts--;
            if (attempts > 0)
            {
                DisplayAlert("Invalid Login", $"You have {attempts} attempts left.", "OK");
            }
            else
            {
                DisplayAlert("Invalid Login", "You have no more attempts left.", "OK");
            }
        }
    }

    private void OnCreatePasswordClicked(object sender, EventArgs e)
    {
        Random random = new Random();
        string newUsername = "";
        for (int i = 0; i < 5; i++)
        {
            newUsername += (char)random.Next('a', 'z' + 1);
        }

        string newPassword = random.Next(1000, 10000).ToString();

        Account u = new Account(newUsername, newPassword, "", "", 0);
        DisplayAlert("Password Created", $"Your new username is: {USERNAME}. Your new password is: {PASSWORD}.", "OK");
    }
}
