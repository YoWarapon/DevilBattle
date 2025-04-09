namespace DevilBattle.Views;

public partial class Setting : ContentPage
{
	public Setting()
	{
		InitializeComponent();
	}

    private async void OnBackClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync(); // ย้อนกลับไปหน้าก่อน
    }
}