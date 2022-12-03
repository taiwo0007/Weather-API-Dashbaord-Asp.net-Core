using System.ComponentModel.DataAnnotations;

namespace TestApi;

public class WeatherApiModel
{
    
    [Required]
    [StringLength(15, ErrorMessage = "Country name too long.")]
    public string? PlaceName { get; set; }
    public string? countryName { get; set; }
    public string? regionName { get; set; }
    public string? temperature { get; set; }
    public string? locationName { get; set;  }
    public string? conditionIcon { get; set; }
    public string? conditionText { get; set; }
    public string? windMph { get; set; }
    public string? windDegree { get; set; }
    public string? windDirection { get; set; }
    public string? pressure { get; set; }
    public string? precipitation { get; set; }
    public string? humidity { get; set; }
    public string? feelsLike { get; set; }
    public string? uvIndex { get; set; }
    public string? gust { get; set; }
    public string? localTimeFromApi { get; set; }
    public string? localTimeFromApiFormatted { get; set; }
    
    public String name;
    
    
    
    
}