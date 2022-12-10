namespace Website.Models
{
    public class Cocktail
    {
        public int CocktailID { get; set; }
        public string? CocktailName { get; set; }
        public string? CocktailStory { get; set; }
        public Color? Color { get; set; }
        public Glass? Glass { get; set; }
        public List<Ingredient>? Ingredients { get; set; }
        public Preparation? Preparation { get; set; }
        public Temperature? Temperature { get; set; }
    }
}
