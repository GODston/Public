namespace ExampleFlyoutBurgerButton;

public partial class TabbedP : TabbedPage
{
	public TabbedP()
	{
        NavigationPage.SetTitleView(this, new NewContent2());

        InitializeComponent();

		_Page1.Content = new NewContent1();
	}
}