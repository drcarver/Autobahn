using Newtonsoft.Json;

namespace SchemaOrg;

public partial class Graph
{
    [JsonProperty("@id")]
    public string Id { get; set; }

    [JsonProperty("@type")]
    [JsonConverter(typeof(SingleOrArrayConverter<string>))]
    public List<string> SchemaType { get; set; }

    [JsonProperty("rdfs:comment")]
    public string RdfsComment { get; set; }

    [JsonProperty("rdfs:label")]
    public string RdfsLabel { get; set; }

    [JsonProperty("schema:domainIncludes")]
    [JsonConverter(typeof(SingleOrArrayConverter<SchemaDomainIncludes>))]
    public List<SchemaDomainIncludes> SchemaDomainIncludes { get; set; }
 
    [JsonProperty("schema:rangeIncludes")]
    [JsonConverter(typeof(SingleOrArrayConverter<SchemaRangeIncludes>))]
    public List<SchemaRangeIncludes> SchemaRangeIncludes { get; set; }

    [JsonProperty("schema:isPartOf")]
    public SchemaIsPartOf SchemaIsPartOf { get; set; }

    [JsonProperty("schema:source")]
    [JsonConverter(typeof(SingleOrArrayConverter<SchemaSource>))]
    public List<SchemaSource> SchemaSource { get; set; }

    [JsonProperty("rdfs:subClassOf")]
    [JsonConverter(typeof(SingleOrArrayConverter<RdfsSubClassOf>))]
    public List<RdfsSubClassOf> RdfsSubClassOf { get; set; }

    [JsonProperty("skos:exactMatch")]
    public SkosExactMatch SkosExactMatch { get; set; }

    [JsonProperty("owl:equivalentProperty")]
    public OwlEquivalentProperty OwlEquivalentProperty { get; set; }

    [JsonProperty("rdfs:subPropertyOf")]
    [JsonConverter(typeof(SingleOrArrayConverter<RdfsSubPropertyOf>))]
    public List<RdfsSubPropertyOf> RdfsSubPropertyOf { get; set; }

    [JsonProperty("schema:supersededBy")]
    public SchemaSupersededBy SchemaSupersededBy { get; set; }

    [JsonProperty("skos:closeMatch")]
    [JsonConverter(typeof(SingleOrArrayConverter<SkosCloseMatch>))]
    public List<SkosCloseMatch> SkosCloseMatch { get; set; }

    [JsonProperty("owl:equivalentClass")]
    [JsonConverter(typeof(SingleOrArrayConverter<OwlEquivalentClass>))]
    public List<OwlEquivalentClass> OwlEquivalentClass { get; set; }

    [JsonProperty("dcterms:source")]
    [JsonConverter(typeof(SingleOrArrayConverter<DctermsSource>))]
    public List<DctermsSource> DctermsSource { get; set; }

    [JsonProperty("schema:inverseOf")]
    public SchemaInverseOf SchemaInverseOf { get; set; }
}