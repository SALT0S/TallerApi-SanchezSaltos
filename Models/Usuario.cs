using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TallerApi_SanchezSaltos.Models
{
    public class Usuario
    {
        public int Id { get; set; }

        [Required]
        [Column(TypeName="varchar(10)")]
        public String NombreUsuario { get; set; }

        [Required]
        [Column(TypeName = "varchar (10)")]
        public String Clave { get; set; }

        [Required]
        public Boolean Estado { get; set; }

        public int GeneroId { get; set; }
        
        public Genero Genero { get; set; }
    }
}
