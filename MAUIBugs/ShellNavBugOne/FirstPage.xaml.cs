namespace MAUIBugs.ShellNavBugOne;

public partial class FirstPage : ContentPage
{
	public FirstPage()
	{
		InitializeComponent();
	}

	private void NavigateClicked(object sender, EventArgs e)
	{
		Shell.Current.GoToAsync("///sampleApp/settings");
	}
}

