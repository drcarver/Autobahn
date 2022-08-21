using Newtonsoft.Json;

namespace Schema.Org;

public class DctermsSource
{
    [JsonProperty("@id")]
    public string Id { get; set; }
}