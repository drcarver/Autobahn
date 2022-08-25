using Newtonsoft.Json;

namespace SchemaOrg;

public partial class RdfsSubPropertyOf
{
    [JsonProperty("@id")]
    public string Id { get; set; }
}