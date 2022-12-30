namespace Showroom.Models
{
    public class Store
    {
        public int Id { get; set; }
        public string? car_id { get; set; }
        public string? service { get; set;}

        public ICollection<Car_store>? Car_store { get; set; }

    }
}
