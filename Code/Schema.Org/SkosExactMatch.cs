using Newtonsoft.Json;

namespace Schema.Org;

public class SkosExactMatch
{
    [JsonProperty("@id")]
    public string Id { get; set; }
}