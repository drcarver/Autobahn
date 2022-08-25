using Newtonsoft.Json;

namespace SchemaOrg;

public partial class SkosCloseMatch
{
    [JsonProperty("@id")]
    public string Id { get; set; }
}