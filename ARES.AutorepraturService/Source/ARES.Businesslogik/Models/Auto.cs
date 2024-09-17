namespace ARES.Businesslogik.Models
{
    public class Auto
    {
        public int Id { get; set; }
        public string KFZ { get; set; }
        public int AutohalterId { get; set; }
        public Autohalter Autohalter { get; set; }
        public ICollection<Schaden> Schäden { get; set; }
    }
}
