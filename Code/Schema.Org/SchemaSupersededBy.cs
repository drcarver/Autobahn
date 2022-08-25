using Newtonsoft.Json;

namespace SchemaOrg;

public partial class SchemaSupersededBy
{
    [JsonProperty("@id")]
    public string Id { get; set; }
}