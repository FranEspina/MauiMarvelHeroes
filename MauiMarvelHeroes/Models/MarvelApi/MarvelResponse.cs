using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace MauiMarvelHeroes.Models.MarvelApi;

public partial class MarvelResponse<T>
{
    [JsonPropertyName("code")]
    public long Code { get; set; }

    [JsonPropertyName("status")]
    public string Status { get; set; }

    [JsonPropertyName("copyright")]
    public string Copyright { get; set; }

    [JsonPropertyName("attributionText")]
    public string AttributionText { get; set; }

    [JsonPropertyName("attributionHTML")]
    public string AttributionHtml { get; set; }

    [JsonPropertyName("etag")]
    public string Etag { get; set; }

    [JsonPropertyName("data")]
    public Data<T> Data { get; set; }
}

public partial class Data<T>
{
    [JsonPropertyName("offset")]
    public long Offset { get; set; }

    [JsonPropertyName("limit")]
    public long Limit { get; set; }

    [JsonPropertyName("total")]
    public long Total { get; set; }

    [JsonPropertyName("count")]
    public long Count { get; set; }

    [JsonPropertyName("results")]
    public List<T> Results { get; set; }
}
