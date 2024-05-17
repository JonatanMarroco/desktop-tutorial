using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace tupenca.Business.Domain
{
    public class Usuario
    {
        [Required] public required string nombre { get; set; }
        [Required] public required string apellido { get; set; }
        [Required] public required string correo { get; set; }
        [Required] public required string clave { get; set; }
        [Required] public required string telefono { get; set; }
        [Required] public int Id { get; set; }
    }
}