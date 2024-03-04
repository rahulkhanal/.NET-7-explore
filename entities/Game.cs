namespace MyConsoleApp.entities
{
    public class Game
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string Genre { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string? MyProperty { get; set; }
        public string? ImageUri { get; set; }
        public decimal Price { get; set; }

    }
}