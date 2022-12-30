namespace Showroom.Models
{
    public class Category
    {
        public int Id { get; set; }
        public int productID { get; set; }
        public string? car_name { get; set; }
        public string? category { get; set;}
        public string? colletions { get; set;}
        public ICollection<Car>? Cars { get; set; }


    }
}
