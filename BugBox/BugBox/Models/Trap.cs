namespace BugBox.Models
{
    public class Trap
    {
        public int TrapId { get; set; }
        public string Name { get; set; }
        public string Comment { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public int Status { get; set; }
    }
}