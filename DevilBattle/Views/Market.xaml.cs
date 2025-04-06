namespace DevilBattle.Views;

public partial class Market : ContentPage
{
	public Market()
	{
		InitializeComponent();
	}

    private void OnMinClicked(object sender, EventArgs e)
    {
        AmountEntry.Text = "1";
    }

    private void OnMaxClicked(object sender, EventArgs e)
    {
        AmountEntry.Text = "9999"; 
    }

    private void OnCancelAmount(object sender, EventArgs e)
    {
        AmountPopup.IsVisible = false;
    }

    private void OnConfirmAmount(object sender, EventArgs e)
    {
        int amount = int.Parse(AmountEntry.Text);
        AmountPopup.IsVisible = false;
    }

    private void OnItemTapped(object sender, EventArgs e)
    {
        AmountPopup.IsVisible = true;
        AmountEntry.Text = "1"; 
    }


}