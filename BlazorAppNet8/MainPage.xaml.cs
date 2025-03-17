namespace BlazorAppNet8;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}

	private async void OnOpenBlazorWindowClicked(object sender, EventArgs e)
	{
		var blazorWindow = new BlazorWindow();
		await Navigation.PushModalAsync(blazorWindow);
	}
}

