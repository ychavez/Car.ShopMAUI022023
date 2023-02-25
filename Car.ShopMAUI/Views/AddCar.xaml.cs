

using Car.ShopMAUI.Context;
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using System.Drawing;
using System.Drawing.Imaging;


namespace Car.ShopMAUI.Views;

public partial class AddCar : ContentPage
{
    public AddCar()
    {
        InitializeComponent();
    }



    private async void btnAceptar_Clicked(object sender, EventArgs e)
    {
       // var location = await Geolocation.Default.GetLocationAsync();

        Models.Car car = new()
        {
            Brand = entryMarca.Text,
            Description = entryDescripcion.Text,
            Model = entryModelo.Text,
            Year = int.Parse(entryAnio.Text),
            PhotoUrl = entryUrlPhoto.Text,
            Price = decimal.Parse(entryPrecio.Text),
            //Lat = location.Latitude,
            //Lon = location.Longitude
        };

        await new RestService().SetCar(car);
        await Navigation.PopAsync();
    }

    private async void btnPhoto_Clicked(object sender, EventArgs e)
    {

        string action = await DisplayActionSheet("Cual deberia de tomar?", "Cancel", "Ok", "Galeria", "Camara");

     

        var photo = action == "Galeria" ? await MediaPicker.Default.PickPhotoAsync() : await MediaPicker.Default.CapturePhotoAsync();

        imgCar.Source = ImageSource.FromStream(async x =>  await photo.OpenReadAsync());

        var imgName = Guid.NewGuid().ToString();

        var account = new Account("dm0wb7rsq", "833115171146254", "axg8X4k3SFhntwaceKoOGtFyz40");

        var cloudinary = new Cloudinary(account);


        var photoStream = await photo.OpenReadAsync();



        var uploadsParams = new ImageUploadParams
        {
            File = new FileDescription(Guid.NewGuid().ToString(), await photo.OpenReadAsync()),
            EagerTransforms = new List<Transformation>(){
               new EagerTransformation().Width(100).Height(100)}
        };
        var uploadResults = await cloudinary.UploadAsync(uploadsParams);


        var urlPhoto = uploadResults.Url;

        entryUrlPhoto.Text = urlPhoto.AbsoluteUri;
    }
}

