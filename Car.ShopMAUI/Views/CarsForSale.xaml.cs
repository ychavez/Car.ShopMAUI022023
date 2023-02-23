using Car.ShopMAUI.Context;


namespace Car.ShopMAUI.Views;

public partial class CarsForSale : ContentPage
{

    public CarsForSale()
    {
        InitializeComponent();

    }

    private async Task LoadList()
    {
        CarsList.ItemsSource = await new RestService().GetCars();
    }


    protected async override void OnAppearing()
    {
        await LoadList();
        base.OnAppearing();
    }

    

    protected override void OnDisappearing()
    {
        CarsList.ItemsSource = null;
        base.OnDisappearing();
    }

    private async void ToolbarItem_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new AddCar());
    }

    private async void Button_OnClicked(object sender, EventArgs e)
    {
        var favoriteResult = await new DataContext()
            .SetFavorite((Models.Car)((Button)sender).BindingContext);

        await DisplayAlert("Auto favorito", favoriteResult ?
            "Auto agregado correctamente" : "El auto ya se encuentra en favoritos", "Ok");
    }
}