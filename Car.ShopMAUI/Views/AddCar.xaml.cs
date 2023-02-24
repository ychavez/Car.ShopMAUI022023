

using Car.ShopMAUI.Context;

namespace Car.ShopMAUI.Views;

public partial class AddCar : ContentPage
{
    public AddCar()
    {
        InitializeComponent();
    }



    private async void btnAceptar_Clicked(object sender, EventArgs e)
    {
        var location = await Geolocation.Default.GetLocationAsync();

        Models.Car car = new()
        {
            Brand = entryMarca.Text,
            Description = entryDescripcion.Text,
            Model = entryModelo.Text,
            Year = int.Parse(entryAnio.Text),
            Price = decimal.Parse(entryPrecio.Text),
            Lat = location.Latitude,
            Lon = location.Longitude
        };

        await new RestService().SetCar(car);
        await Navigation.PopAsync();
    }
}

