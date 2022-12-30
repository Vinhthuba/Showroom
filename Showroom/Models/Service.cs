namespace Showroom.Models
{
    public class Service
    {
        public int Id { get; set; }
        public string? inurance { get; set; }
        public string? aotomotive_parts { get; set; }
        public string? service_about_car { get; set; }
        public ICollection<Store>? Stores { get; set; }


    }
}
