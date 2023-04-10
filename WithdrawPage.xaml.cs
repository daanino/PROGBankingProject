
namespace PROGBankingProject;

public partial class WithdrawPage : ContentPage
{
    AccountRepository _accountRepository;
    public WithdrawPage(Account account)
	{
		InitializeComponent();
        BindingContext = account;
	}
    private void WithdrawBtnClicked(object sender, EventArgs e)
    {
        if (decimal.TryParse(WithdrawEntry.Text, out decimal withdrawAmt))
        {
            Account selectedAccount = (Account)BindingContext;
            if (selectedAccount.Balance - withdrawAmt < 0)
            {
                // If balance will become negative after withdraw
                DisplayAlert("Error", "Withdraw amount cannot exceed balance", "OK");
            }
            else
            {
                selectedAccount.Balance -= withdrawAmt;
                DisplayAlert("Success", $"Your balance is now {selectedAccount.Balance}", "OK");
            }
        }
        else
        {
            // Handle the case where the text cannot be parsed as a double.
            DisplayAlert("Error", "An error occurred.", "OK");
        }
    }
    private void ReturnBtnClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new AccountPage((Account)BindingContext));
    }
}