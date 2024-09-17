namespace ARES.Businesslogik.Models
{
    public class Termin
    {
        public int Id { get; set; }
        public DateTime Abholung { get; set; }
        public bool Erledigt { get; set; }
        public int AutoId { get; set; }
        public Auto Auto { get; set; }
    }
}
