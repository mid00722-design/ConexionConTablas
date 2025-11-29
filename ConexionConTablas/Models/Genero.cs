using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConexionConTablas.Models
{
    [Table("genero")]
    public class Genero
    {
        [Key]
        public int Idgenero { get; set; }

        [Column("Genero")]
        public string GeneroTexto { get; set; } // si decides mantenerlo
        public int Idcliente { get; set; }

        public Cliente Cliente { get; set; }
    }
}
