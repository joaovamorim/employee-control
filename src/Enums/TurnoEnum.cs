using System.Text.Json.Serialization;

namespace webapínet6_crud.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum TurnoEnum
    {
        Manhã,
        Tarde,
        Noite
    }
}