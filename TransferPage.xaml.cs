
namespace PROGBankingProject;

public partial class TransferPage : ContentPage
{

    public ViewModel vm;

	public TransferPage()
	{
		InitializeComponent();
        vm = new ViewModel();
   	}

    private void OnTransferConfirmed(object sender, EventArgs e)
    {
        string username = TransferEntry.Text;
        Account account = vm.FindAccount(username);
        if (account != null)
        {
            string message = $"Account found for {account.FirstName} {account.LastName}. Current balance: {account.Balance:C}";
            DisplayAlert("Account Found", message, "OK");
        }
        else
        {
            DisplayAlert("Account Not Found", $"No account found for username {username}.", "OK");
        }
    }
    private void ReturnBtnClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new AccountPage());
    }
}