namespace financial_Tracker;

public partial class IncomePage : ContentPage
{
	public IncomePage()
	{
		InitializeComponent();
	}

    private void OnPickerSelectedIndexChanged(object sender, EventArgs e)
    {
        var picker = (Picker)sender;
        int selectedIndex = picker.SelectedIndex;

        if (selectedIndex != -1)
        {
            dataCategory.Text = (string)picker.ItemsSource[selectedIndex];
        }
    }

    private void income_continueBtn_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new MainPage());
    }
}