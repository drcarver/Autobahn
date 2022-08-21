using Newtonsoft.Json;

namespace Schema.Org;

public class SchemaIsPartOf
{
    [JsonProperty("@id")]
    public string Id { get; set; }
}