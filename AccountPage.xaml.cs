using System.Runtime.Serialization;

namespace PROGBankingProject;

public partial class AccountPage : ContentPage
{
	public AccountPage()
	{
		InitializeComponent();
	}
	private void DepositBtnClicked(object sender, EventArgs e)
	{
        Navigation.PushAsync(new DepositPage());
	}
    private void WithdrawBtnClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new WithdrawPage());
    }
    private void TransferBtnClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new TransferPage());
    }
    private void LogoutBtnClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new MainPage());
    }
}