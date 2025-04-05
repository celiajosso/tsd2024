using System.ComponentModel.DataAnnotations;

namespace MvcRecipe.Models;

public class Recipe
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public int? Time { get; set; }
    public string? Difficulty { get; set; }
    public int? Likes { get; set; }
    public string? Ingredients { get; set; }
    public string? Process { get; set; }
    public string? Tips { get; set; }
    public string? Tricks { get; set; }
}