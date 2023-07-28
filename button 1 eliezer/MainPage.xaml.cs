namespace button_1_eliezer;

public partial class MainPage : ContentPage
{
	

	public MainPage()
	{
		InitializeComponent();
	}
    private void Button_Clicked(object sender, EventArgs e)
    {
        (sender as Button).Text = "Presióname de nuevo";
    }

}

