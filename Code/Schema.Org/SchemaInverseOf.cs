using Newtonsoft.Json;

namespace Schema.Org;

public class SchemaInverseOf
{
    [JsonProperty("@id")]
    public string Id { get; set; }
}