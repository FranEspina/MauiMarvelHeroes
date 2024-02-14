using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MauiMarvelHeroes.Models.MarvelApi;

public partial class Thumbnail
{
    [JsonPropertyName("path")]
    public Uri Path { get; set; }

    [JsonPropertyName("extension")]
    public string Extension { get; set; }

    [JsonIgnore]
    public string Url { get => $"{Path}.{Extension}".Replace("http:", "https:"); }
}

