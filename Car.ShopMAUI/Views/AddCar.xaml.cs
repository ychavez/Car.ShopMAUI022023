

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
        Models.Car car = new()
        {
            Brand = entryMarca.Text,
            Description = entryDescripcion.Text,
            Model = entryModelo.Text,
            Year = int.Parse(entryAnio.Text),
            Price = decimal.Parse(entryPrecio.Text)
        };

        await new RestService().SetCar(car);
        await Navigation.PopAsync();
    }
}

/*
 * 1 agregar el tabbed page como pagina de navegacion
 * 2 agregar un boton que nos permita hacer push de una nueva pagina de contenido
 * 3 esta pagina de contenido tendra que tener los controles necesarios para poder dar de alta
 *    una nueva ciudad contemplando una foto (URL) y latitud y longitud
 * 4 esta pagina tambien tendra que tener un boton para capturar
 */