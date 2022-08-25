using Newtonsoft.Json;

namespace SchemaOrg;

public partial class OwlEquivalentClass
{
    [JsonProperty("@id")]
    public string Id { get; set; }
}