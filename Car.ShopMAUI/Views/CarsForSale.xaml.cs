namespace Car.ShopMAUI.Views;

public partial class CarsForSale : ContentPage
{
    private List<Models.Car> cars;
    public CarsForSale()
    {
        InitializeComponent();
        cars = new()
        {
           new()
            {
               Brand="Chevrolet",
               Model="Camaro",
               Description="Camaro SS 2023 500km",
               Price = 100_000,
               Year=2023,
               PhotoUrl="https://acroadtrip.blob.core.windows.net/catalogo-imagenes/s/RT_V_fdf2792f4ef94f45a2624c08ef7ebcca.jpg"
            },
             new()
            {
               Brand="Chevrolet",
               Model="Camaro",
               Description="Camaro SS 2023 500km",
               Price = 100_000,
               Year=2023,
               PhotoUrl="https://acroadtrip.blob.core.windows.net/catalogo-imagenes/s/RT_V_fdf2792f4ef94f45a2624c08ef7ebcca.jpg"
            },
             new()
            {
               Brand="Chevrolet",
               Model="Camaro",
               Description="Camaro SS 2023 500km",
               Price = 100_000,
               Year=2023,
               PhotoUrl="https://acroadtrip.blob.core.windows.net/catalogo-imagenes/s/RT_V_fdf2792f4ef94f45a2624c08ef7ebcca.jpg"
            }
        };
        CarsList.ItemsSource = cars;
    }
}