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

        private async void begin_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.Market());

        }

        private async void setting_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.Setting());
        }
    }

}
