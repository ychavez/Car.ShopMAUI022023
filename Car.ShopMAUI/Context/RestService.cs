
using System.Text.Json;

namespace Car.ShopMAUI.Context
{
    public class RestService
    {
        HttpClient _httpClient;
        Uri _urlBase;

        public RestService()
        {
            _urlBase = new Uri("https://dwshopwebclient20230216212752.azurewebsites.net/api");
            _httpClient = new();
            _httpClient.BaseAddress = _urlBase;
        }

        public async Task<List<Models.Car>> GetCars()
        {
            var response = await _httpClient.GetAsync("/CarsForSalesApi");
           
            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();


                return JsonSerializer.Deserialize<List<Models.Car>>(content,
                    new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase });
            }

            throw new Exception("Error al tratar de obtener la informacion");
        
        }

    }
}
