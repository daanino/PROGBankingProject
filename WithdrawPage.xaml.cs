
namespace PROGBankingProject;

public partial class WithdrawPage : ContentPage
{
	public WithdrawPage()
	{
		InitializeComponent();
	}
    private void DepositBtnClicked(object sender, EventArgs e)
    {
        if (double.TryParse(WithdrawEntry.Text, out double withdrawAmt))
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
        Navigation.PushAsync(new AccountPage());
    }
}