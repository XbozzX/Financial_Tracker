namespace financial_Tracker
{
    public partial class MainPage : ContentPage
    {
     

        public MainPage()
        {
            InitializeComponent();
        }

        private void IncomeBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new IncomePage());
        }

        private void ExpensesBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Expenses());
        }

    }
}