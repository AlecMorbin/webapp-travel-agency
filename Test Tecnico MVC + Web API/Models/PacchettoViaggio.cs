using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Test_Tecnico_MVC___Web_API.Models
{
    public class PacchettoViaggio
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Il campo è obbligatorio")]
        public string Nome { get; set; }

        [Column(TypeName=  "text")]
        [Required(ErrorMessage = "Il campo è obbligatorio")]
        public string Descrizione { get; set; }

        [Required(ErrorMessage = "Il campo è obbligatorio")]
        public string Destinazione { get; set; }

        [Required(ErrorMessage = "Il campo è obbligatorio")]
        public double Prezzo { get; set; }

        [Required(ErrorMessage = "Il campo è obbligatorio")]
        public string Image { get; set; }

        [Required(ErrorMessage = "Il campo è obbligatorio")]
        public int Durata { get; set; }


        public PacchettoViaggio() { }

        public PacchettoViaggio(string nome, string descrizione, string destinazione, double prezzo, string image, int durata)
        {
            Nome = nome;
            Descrizione = descrizione;
            Destinazione = destinazione;
            Prezzo = prezzo;
            Image = image;
            Durata = durata;
        }
    }
}
