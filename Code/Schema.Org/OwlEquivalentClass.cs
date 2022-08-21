using Newtonsoft.Json;

namespace Schema.Org;

public class OwlEquivalentClass
{
    [JsonProperty("@id")]
    public string Id { get; set; }
}