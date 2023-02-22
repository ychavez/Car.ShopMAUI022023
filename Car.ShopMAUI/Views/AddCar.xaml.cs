

namespace Car.ShopMAUI.Views;

public partial class AddCar : ContentPage
{
    public AddCar()
    {
        InitializeComponent();
    }



    private void btnAceptar_Clicked(object sender, EventArgs e)
    {
        Models.Car car = new()
        {
            Brand = entryMarca.Text,
            Description = entryDescripcion.Text,
            Model = entryModelo.Text,
            Year = int.Parse(entryAnio.Text),
            Price = decimal.Parse(entryPrecio.Text)
        };
    }
}