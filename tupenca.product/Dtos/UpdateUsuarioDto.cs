using System.ComponentModel.DataAnnotations;
using System.Drawing;
namespace tupenca.Common.Dtos;

public record UpdateUsuarioDto(
    [Required]
        string nombre,
    [Required]
        string apellido,
    [Required]
        string correo,
    [Required]
    [MinLength(8)]
        string clave,
    [Required]
        string telefono,
    [Required]
        int tenantId
);
