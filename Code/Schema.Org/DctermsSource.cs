using Newtonsoft.Json;

namespace SchemaOrg;

public partial class DctermsSource
{
    [JsonProperty("@id")]
    public string Id { get; set; }
}