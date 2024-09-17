namespace ARES.Businesslogik.Models
{
    public class Schaden
    {
        public int Id { get; set; }
        public string Beschreibung { get; set; }
        public int AutoId { get; set; }
        public Auto Auto { get; set; }
    }
}
