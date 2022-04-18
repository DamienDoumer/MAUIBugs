using MAUIBugs.Pages;

namespace MAUIBugs;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new ViewSizeReferenceBug.SizeReferenceBug();
	}
}
