namespace financial_Tracker
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
        protected override Window CreateWindow(IActivationState activationState)
        {
            //set window size
            var window = base.CreateWindow(activationState);

            const int newWidth = 375;
            const int newHeight = 869;

            window.Width = newWidth;
            window.Height = newHeight;

            //To prevent the window screen resizing
            window.MinimumHeight = window.MaximumHeight = window.Height = newHeight;
            window.MinimumWidth = window.MaximumWidth = window.Width = newWidth;

            return window;
        }
    }
}