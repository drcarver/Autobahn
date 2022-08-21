using Newtonsoft.Json;

namespace Schema.Org;

public class Graph
{
    [JsonProperty("@id")]
    public string Id { get; set; }

    [JsonProperty("@type")]
    public string Type { get; set; }

    [JsonProperty("rdfs:comment")]
    public string RdfsComment { get; set; }

    [JsonProperty("rdfs:label")]
    public string RdfsLabel { get; set; }

    [JsonProperty("schema:domainIncludes")]
    public object SchemaDomainIncludes { get; set; }

    [JsonProperty("schema:rangeIncludes")]
    public object SchemaRangeIncludes { get; set; }

    [JsonProperty("schema:isPartOf")]
    public SchemaIsPartOf SchemaIsPartOf { get; set; }

    [JsonProperty("schema:source")]
    public object SchemaSource { get; set; }

    [JsonProperty("rdfs:subClassOf")]
    public object RdfsSubClassOf { get; set; }

    [JsonProperty("skos:exactMatch")]
    public SkosExactMatch SkosExactMatch { get; set; }

    [JsonProperty("owl:equivalentProperty")]
    public OwlEquivalentProperty OwlEquivalentProperty { get; set; }

    [JsonProperty("rdfs:subPropertyOf")]
    public RdfsSubPropertyOf RdfsSubPropertyOf { get; set; }

    [JsonProperty("schema:supersededBy")]
    public SchemaSupersededBy SchemaSupersededBy { get; set; }

    [JsonProperty("skos:closeMatch")]
    public SkosCloseMatch SkosCloseMatch { get; set; }

    [JsonProperty("owl:equivalentClass")]
    public OwlEquivalentClass OwlEquivalentClass { get; set; }

    [JsonProperty("dcterms:source")]
    public DctermsSource DctermsSource { get; set; }

    [JsonProperty("schema:inverseOf")]
    public SchemaInverseOf SchemaInverseOf { get; set; }
}