using Microsoft.Maui.Maps;

namespace Car.ShopMAUI.Views;

public class MapCars : ContentPage
{
	Microsoft.Maui.Controls.Maps.Map map;
	public MapCars()
	{
        Title = "MapCars";
		
		
	}


    protected override void OnAppearing()
    {
        base.OnAppearing();

        map = new(MapSpan.FromCenterAndRadius(new Location(47.673988, -122.121513),
            Distance.FromKilometers(5)));
        map.IsShowingUser = false;
       Content = map;
    }
}
 