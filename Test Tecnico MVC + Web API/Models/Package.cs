﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Test_Tecnico_MVC___Web_API.Models
{
    public class Package
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

        [JsonIgnore]
        public List<MessageOb> messages { get; set; }

        public Package() { }

        public Package(string name, string description, string destination, double price, string image, int duration)
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
