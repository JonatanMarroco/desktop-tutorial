using System.Text.Json.Serialization;

namespace tupenca.Common.Types;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum TipoSitio
{
    abierto,
    autorizacion,
    invitacion,
    cerrada
}