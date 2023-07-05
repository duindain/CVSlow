namespace CVSlow;

public partial class MainPage : ContentPage
{	
	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
        Application.Current.Dispatcher.Dispatch(async () =>
        {
            await Application.Current.MainPage.Navigation.PushAsync(new ListPage());
        });
    }
}

