using System.ComponentModel.DataAnnotations;

namespace tupenca.Common.Dtos;

public record UsuarioDto(
    string nombre,
    string apellido,
    string correo,
    string clave,
    string telefono,
    int tenantId,
    int id
);
