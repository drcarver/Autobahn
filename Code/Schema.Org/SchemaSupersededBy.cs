using Newtonsoft.Json;

namespace Schema.Org;

public class SchemaSupersededBy
{
    [JsonProperty("@id")]
    public string Id { get; set; }
}