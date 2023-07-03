namespace MovieRaterWebApp.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public required int Year { get; set; }
        public required string Genre { get; set; }
        public required string Director { get; set; }
        public required string Actors { get; set; }
        public required string Country { get; set;}
    }
}
