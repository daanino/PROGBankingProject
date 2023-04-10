using System.Runtime.Serialization;

namespace PROGBankingProject;

public partial class AccountPage : ContentPage
{
    // By Musa Khawaja
	public AccountPage(Account account)
	{
		InitializeComponent();
        BindingContext = account;
    }

    private void DepositBtnClicked(object sender, EventArgs e)
	{
        Navigation.PushAsync(new DepositPage((Account)BindingContext));
    }
    private void WithdrawBtnClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new WithdrawPage((Account)BindingContext));
    }
    private void TransferBtnClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new TransferPage((Account)BindingContext));
    }
    private void LogoutBtnClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new MainPage());
    }
}