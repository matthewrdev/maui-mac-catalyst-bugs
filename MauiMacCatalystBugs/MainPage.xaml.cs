namespace MauiMacCatalystBugs;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

    void Button_Clicked(System.Object sender, System.EventArgs e)
    {
		var window = new Window(new EmptyPage());

		App.Current.OpenWindow(window);
    }
}


