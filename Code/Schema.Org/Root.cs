using Newtonsoft.Json;

namespace Schema.Org;

public class Root
{
    [JsonProperty("@context")]
    public Context Context { get; set; }

    [JsonProperty("@graph")]
    public List<Graph> Graph { get; set; }
}