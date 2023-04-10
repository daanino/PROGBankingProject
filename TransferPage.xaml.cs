
using System.Security.Principal;

namespace PROGBankingProject;

public partial class TransferPage : ContentPage
{

    public ViewModel vm;

	public TransferPage(Account account)
	{
		InitializeComponent();
        vm = new ViewModel();
        BindingContext = account;
    }

    private void OnTransferConfirmed(object sender, EventArgs e)
    {
        Account selectedAccount = (Account)BindingContext;
        string username = TransferToEntry.Text;
        vm.FindAccount(username);
        if (vm.FoundAccount != null)
        {
            if (decimal.TryParse(TransferEntry.Text, out decimal transferAmt))
            {
                if (selectedAccount.Balance - transferAmt < 0)
                {
                    // If balance will become negative after transfer
                    DisplayAlert("Error", "Transfer amount cannot exceed balance", "OK");
                }
                else
                {
                    selectedAccount.Balance -= transferAmt;
                    vm.FoundAccount.Balance += transferAmt;
                    DisplayAlert("Transfer Successful", $"Account found for {vm.FoundAccount.FirstName} {vm.FoundAccount.LastName}. Transfer successful. Current balance: {selectedAccount.Balance:C}", "OK");
                }
            }
            else
            {
                DisplayAlert("Error", "An error occured.", "OK");
            }
        }
        else
        {
            DisplayAlert("Error", $"There was no account found for username {username}.", "OK");
        }
    }
    private void ReturnBtnClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new AccountPage((Account)BindingContext));
    }
}