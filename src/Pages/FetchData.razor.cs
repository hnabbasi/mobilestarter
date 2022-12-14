using MobileStarter.Data;

namespace MobileStarter.Pages;

public partial class FetchData
{
    private WeatherForecast[]? forecasts;

    protected override async Task OnInitializedAsync()
    {
        forecasts = await ForecastService.GetForecastAsync(DateTime.Now);
    }
}