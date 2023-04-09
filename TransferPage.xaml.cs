
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
        vm.FindAccount(username);
        if (vm.FoundAccount != null)
        {
            string message = $"Account found for {vm.FoundAccount.FirstName} {vm.FoundAccount.LastName}. Current balance: {vm.LoggedInAccount.Balance:C}";
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