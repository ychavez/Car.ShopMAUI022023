using Car.ShopMAUI.Context;
using System;

namespace Car.ShopMAUI.Views;

public partial class CarsForSale : ContentPage
{
  
    public CarsForSale()
    {
        InitializeComponent();
        LoadList();
    }

    private void LoadList()
        => CarsList.ItemsSource = new RestService().GetCars().Result;
}