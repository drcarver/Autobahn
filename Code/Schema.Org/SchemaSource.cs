﻿using Newtonsoft.Json;

namespace SchemaOrg;

public partial class SchemaSource
{
    [JsonProperty("@id")]
    public string Id { get; set; }
}
