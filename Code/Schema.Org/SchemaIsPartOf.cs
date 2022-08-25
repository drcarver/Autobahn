using Newtonsoft.Json;

namespace SchemaOrg;

public partial class SchemaIsPartOf
{
    [JsonProperty("@id")]
    public string Id { get; set; }
}