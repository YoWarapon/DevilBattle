using System.Threading.Tasks;

namespace DevilBattle
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private async void leaderboard_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.LeaderboardPage());
        }
    }

}
