using Newtonsoft.Json;

namespace SchemaOrg;

public partial class RdfsSubClassOf
{
    [JsonProperty("@id")]
    public string Id { get; set; }
}