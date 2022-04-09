namespace MAUIBugs.ShellNavBugOne;

public partial class ShellNavigationBug1 : Shell
{
	public ShellNavigationBug1()
	{
		InitializeComponent();
		Shell.SetTabBarIsVisible(this, false);
	}
}

