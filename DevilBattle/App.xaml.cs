namespace DevilBattle
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            //return new Window(new MainPage());

            //test page
            return new Window(new Views.LeaderboardPage());
        }
    }
}