using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace tupenca.Common.Dtos;

public class CreateUsuarioDto
{
    [Required]
    public string nombre { get; set; }

    [Required]
    public string apellido { get; set; }

    [Required]
    public string correo { get; set; }

    [Required]
    [MinLength(8)]
    public string clave { get; set; }

    [Required]
    public string telefono { get; set; }
    
    [Required]
    public int tenantId { get; set; }
}
