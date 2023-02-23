using Car.ShopMAUI.Context;

namespace Car.ShopMAUI.Views;

public partial class FavoriteCars : ContentPage
{
	public FavoriteCars()
	{
		InitializeComponent();
	}

	private async Task LoadData() 
	{
		CarsList.ItemsSource = await new DataContext().GetFavorites();
	}

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        await LoadData();
    }
}