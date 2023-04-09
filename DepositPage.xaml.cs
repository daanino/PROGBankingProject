namespace PROGBankingProject;

public partial class DepositPage : ContentPage
{
	public DepositPage()
	{
		InitializeComponent();
	}
    private void DepositBtnClicked(object sender, EventArgs e)
    {
        if (decimal.TryParse(DepositEntry.Text, out decimal depositAmt))
        {
            Account selectedAccount = (Account)BindingContext;
            selectedAccount.Balance += depositAmt;
        }
        else
        {
            // Handle the case where the text cannot be parsed as a double.
            DisplayAlert("Error","An error occurred.", "OK");
        }
    }
    private void ReturnBtnClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new AccountPage());
    }
}