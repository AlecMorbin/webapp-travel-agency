using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Test_Tecnico_MVC___Web_API.Models
{
    public class PacchettoViaggio
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Il campo è obbligatorio")]
        public string Name { get; set; }

        [Column(TypeName=  "text")]
        [Required(ErrorMessage = "Il campo è obbligatorio")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Il campo è obbligatorio")]
        public string Destination { get; set; }

        [Required(ErrorMessage = "Il campo è obbligatorio")]
        public double Price { get; set; }

        [Required(ErrorMessage = "Il campo è obbligatorio")]
        public string Image { get; set; }

        [Required(ErrorMessage = "Il campo è obbligatorio")]
        public int Duration { get; set; }


        public PacchettoViaggio() { }

        public PacchettoViaggio(string name, string description, string destination, double price, string image, int duration)
        {
            Name = name;
            Description = description;
            Destination = destination;
            Price = price;
            Image = image;
            Duration = duration;
        }
    }
}
