namespace Car.ShopMAUI.Views
{
    public class MainTabbedPage : TabbedPage
    {
        public MainTabbedPage()
        {
            Children.Add(new CarsForSale());
            Children.Add(new FavoriteCars());
            Children.Add(new MapCars());
        }
    }
}
