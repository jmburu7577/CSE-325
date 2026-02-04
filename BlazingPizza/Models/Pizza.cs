namespace BlazingPizza.Models;
using System.Globalization;

public class Pizza
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public string ImageUrl { get; set; } = "img/pizza-slice.svg";

    public string GetFormattedPrice() => Price.ToString("C", new CultureInfo("en-KE"));
}
