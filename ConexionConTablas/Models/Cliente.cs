using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConexionConTablas.Models
{
    [Table("cliente")] // ← nombre exacto de la tabla en MySQL
    public class Cliente
    {
        [Key] // ← Esto indica que es la clave primaria
        public int Idcliente { get; set; }

        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Genero { get; set; }
    }
}

