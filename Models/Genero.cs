using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TallerApi_SanchezSaltos.Models
{
    public class Genero
    {
        public int Id { get; set; }
        
        public string Nombre { get; set; }
        
        public Boolean Estado { get; set; }
    }
}
