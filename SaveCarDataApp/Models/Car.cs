using System.ComponentModel.DataAnnotations;

namespace SaveCarDataApp.Models
{
    public class Car
    {
        public int Id { get; set; }
        [Required]
        public string Brand { get; set; }
        public int Year { get; set; }
        public string Model { get; set; }
        public bool SpareWheel { get; set; }

    }
}
