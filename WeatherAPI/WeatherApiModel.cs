namespace WeatherAPI;
using System.ComponentModel.DataAnnotations;
public class WeatherApiModel
{
    [Required]
    [StringLength(15, ErrorMessage = "Country name too long.")]
    public string? PlaceName { get; set; }
    public string? CountryName { get; set; }
    public string? Temperature { get; set; }
    public string? LocationName { get; set;  }
    public string? ConditionIcon { get; set; }
    public string? ConditionText { get; set; }
    public string? WindMph { get; set; }
    public string? WindDegree { get; set; }
    public string? WindDirection { get; set; }
    public string? Pressure { get; set; }
    public string? Precipitation { get; set; }
    public string? Humidity { get; set; }
    public string? FeelsLike { get; set; }
    public string? UvIndex { get; set; }
    public string? Gust { get; set; }
    public string? LocalTimeFromApi { get; set; }
    public string? LocalTimeFromApiFormatted { get; set; }
}