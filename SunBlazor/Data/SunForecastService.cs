using GetAPISunset;

namespace SunBlazor.Data
{
    public class SunForecastService
    {
        public static async Task<Root> GetWebApiLongLatAsync(string SunDate)
        {
            HttpClient httpClient = new HttpClient();

            var latitude = 60.67452;
            var longitude = 17.14174;
            var uri = $"https://api.sunrise-sunset.org/json?lat={latitude}&lng={longitude}&date={SunDate}";

            HttpResponseMessage response = await httpClient.GetAsync(uri);
            response.EnsureSuccessStatusCode();
            Root wd = await response.Content.ReadFromJsonAsync<Root>();
            return wd;
        }
    }
}
