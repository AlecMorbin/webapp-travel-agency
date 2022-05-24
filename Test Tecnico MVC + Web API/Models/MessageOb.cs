using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Test_Tecnico_MVC___Web_API.Models
{
    public class MessageOb
    {
        [Key]
        public int Id { get; set; } 
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        [Column(TypeName = "text")]
        public string Message { get; set; }
        public DateTime? DateTime { get; set; }

        public int PackageId { get; set; }
        public Package? Package { get; set; }

        public MessageOb() { }

        public MessageOb(string name, string surname, string message, int packageId)
        {
            Name = name;
            Surname = surname;
            Message = message;
            PackageId = packageId;
        }
    }
}
