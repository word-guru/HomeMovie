namespace HomeMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Producer { get; set; }
        public string Genre { get; set; }
        public string Description { get; set; }
        public List<DateTime> Session { get; set; }

    }
}
