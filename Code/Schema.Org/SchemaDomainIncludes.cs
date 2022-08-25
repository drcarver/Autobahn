using Newtonsoft.Json;

namespace SchemaOrg;

public partial class SchemaDomainIncludes
{
    [JsonProperty("@id")]
    public string Id { get; set; }
}