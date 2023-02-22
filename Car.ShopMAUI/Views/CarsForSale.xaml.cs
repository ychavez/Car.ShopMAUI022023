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
}