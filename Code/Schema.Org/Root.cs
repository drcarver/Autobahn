using Newtonsoft.Json;

namespace SchemaOrg;

public partial class Root
{
    [JsonProperty("@context")]
    public Context Context { get; set; }

    [JsonProperty("@graph")]
    public List<Graph> Graph { get; set; }
}