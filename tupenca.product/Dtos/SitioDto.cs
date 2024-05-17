using System.ComponentModel.DataAnnotations;
using tupenca.Common.Types;

namespace tupenca.Common.Dtos;

public record SitioDto(
    string nombre,
    string url,
    TipoSitio formaReg,
    int id
);
