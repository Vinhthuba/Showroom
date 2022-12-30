using System;

namespace Showroom.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string? name { get; set; }
        public string? exterior_color { get; set; }  //mau ngoai that 
        public string? work_productivity  { get; set; }
        public float? cylinder_number  { get; set; }
        public DateTime year  { get; set; }
        public float length  { get; set; }
        public float width  { get; set; }
        public float height  { get; set; }
        public float weight  { get; set; }
        public string? maximum_weight  { get; set; }
        public float top_speed  { get; set; }
        public string? interior_color  { get; set; }
        public int number_of_seat  { get; set; }
        public float price  { get; set; }
        public ICollection<Category>? Categorys { get; set; }
        public ICollection<Car_store>? Car_stores { get; set; }
    }
}
