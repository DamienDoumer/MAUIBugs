namespace MAUIBugs.ShellNavBugOne;

public partial class SettingsPage : ContentPage
{
	int count = 0;

	public SettingsPage()
	{
		InitializeComponent();
	}

	private void NavigateClicked(object sender, EventArgs e)
	{
		Shell.Current.GoToAsync("///sampleApp/first");
	}
}

