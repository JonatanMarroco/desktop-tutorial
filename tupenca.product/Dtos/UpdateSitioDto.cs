using System.ComponentModel.DataAnnotations;
using System.Drawing;
using tupenca.Common.Types;

namespace tupenca.Common.Dtos;

public record UpdateSitioDto(
    [Required]
        string nombre,
    [Required]
        string url,
    [Required]
        TipoSitio formaReg,
    [Required]
        string id
);
