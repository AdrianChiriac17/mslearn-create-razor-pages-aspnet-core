using System.ComponentModel.DataAnnotations;

namespace ContosoPizza.Models;

public class Pizza
{
    public int Id { get; set; }

    [Required]
    public string? Name { get; set; }

    [Required]
    public PizzaSize Size { get; set; }
    public bool IsGlutenFree { get; set; }


    [Required]
    [Range(0.01, 9999.99)]
    public decimal Price { get; set; }

    [Required]
    public string? Toppings { get; set; } = string.Empty;
}

public enum PizzaSize { Small, Medium, Large }