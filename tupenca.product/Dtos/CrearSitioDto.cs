using System.ComponentModel.DataAnnotations;
using System.Drawing;
using tupenca.Common.Types;

namespace tupenca.Common.Dtos;

public class CreateSitioDto
{
    [Required]
    public string nombre { get; set; }

    [Required]
    public string url { get; set; }

    [Required]
    [MinLength(8)]
    public TipoSitio formaReg { get; set; }
}
