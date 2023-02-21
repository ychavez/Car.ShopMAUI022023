namespace Car.ShopMAUI.Views;

public class MapCars : ContentPage
{
	public MapCars()
	{
		Title = "MapCars";
		Content = new VerticalStackLayout
		{
			Children = {
				new Label { HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center, Text = "Welcome to .NET MAUI!"
				}
			}
		};
	}
}