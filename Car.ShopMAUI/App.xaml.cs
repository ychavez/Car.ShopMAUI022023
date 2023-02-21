using Car.ShopMAUI.Views;

namespace Car.ShopMAUI;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new MainTabbedPage();
	}
}
