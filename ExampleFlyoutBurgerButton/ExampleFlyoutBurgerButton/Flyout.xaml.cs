namespace ExampleFlyoutBurgerButton;

public partial class Flyout : FlyoutPage
{
	public Flyout()
	{
		InitializeComponent();

		Flyout = new MainPage();
		Detail = new NavigationPage( new TabbedP() );
	}

    public override bool ShouldShowToolbarButton()
    {
        return false;
    }
}