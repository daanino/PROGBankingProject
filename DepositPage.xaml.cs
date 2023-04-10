namespace PROGBankingProject;

public partial class DepositPage : ContentPage
{
    AccountRepository _accountRepository;
    public DepositPage(Account account)
	{
		InitializeComponent();
        BindingContext = account;
    }
    private void DepositBtnClicked(object sender, EventArgs e)
    {
        if (decimal.TryParse(DepositEntry.Text, out decimal depositAmt))
        {
            Account selectedAccount = (Account)BindingContext;
            selectedAccount.Balance += depositAmt;
            DisplayAlert("Success",$"Your balance is now {selectedAccount.Balance}", "OK");
        }
        else
        {
            // Handle the case where the text cannot be parsed as a double.
            DisplayAlert("Error","An error occurred.", "OK");
        }
    }
    private void ReturnBtnClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new AccountPage((Account)BindingContext));
    }
}