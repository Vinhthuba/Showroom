namespace Showroom.Models
{
    public class Car_store
    {
        public int Id { get; set; }

        public int car_id { get; set; }
        public int store_id { get; set; }
        public ICollection<Car>? Cars { get; set; }


    }
}
