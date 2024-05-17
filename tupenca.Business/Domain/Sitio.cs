using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using tupenca.Common.Types;

namespace tupenca.Business.Domain
{
    public class Sitio
    {
        [Required] public required string nombre { get; set; }
        [Required] public required string url { get; set; }
        [Required] public required TipoSitio formaReg { get; set; }
        [Required] public int Id { get; set; }
    }
}

