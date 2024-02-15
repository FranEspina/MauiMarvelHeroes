using MauiMarvelHeroes.Services.MarvelApi;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MauiMarvelHeroes.Models.MarvelApi;
public partial class MarvelComic : IMarvelQueryable
{
    [JsonPropertyName("id")]
    public long Id { get; set; }

    [JsonPropertyName("digitalId")]
    public long DigitalId { get; set; }

    [JsonPropertyName("title")]
    public string Title { get; set; }

    [JsonPropertyName("issueNumber")]
    public long IssueNumber { get; set; }

    [JsonPropertyName("variantDescription")]
    public string VariantDescription { get; set; }

    [JsonPropertyName("description")]
    public string Description { get; set; }

    [JsonPropertyName("modified")]
    public string Modified { get; set; }

    [JsonPropertyName("isbn")]
    public string Isbn { get; set; }

    [JsonPropertyName("upc")]
    public string Upc { get; set; }

    [JsonPropertyName("diamondCode")]
    public string DiamondCode { get; set; }

    [JsonPropertyName("ean")]
    public string Ean { get; set; }

    [JsonPropertyName("issn")]
    public string Issn { get; set; }

    [JsonPropertyName("format")]
    public string Format { get; set; }

    [JsonPropertyName("pageCount")]
    public long PageCount { get; set; }

    [JsonPropertyName("resourceURI")]
    public Uri ResourceUri { get; set; }

    [JsonPropertyName("series")]
    public ComicSeries Series { get; set; }

    [JsonPropertyName("variants")]
    public List<ComicSeries> Variants { get; set; }

    [JsonPropertyName("dates")]
    public List<Date> Dates { get; set; }

    [JsonPropertyName("prices")]
    public List<Price> Prices { get; set; }

    [JsonPropertyName("thumbnail")]
    public Thumbnail Thumbnail { get; set; }

    [JsonPropertyName("images")]
    public List<Thumbnail> Images { get; set; }

    public bool HasThumbnail()
    {
        return Thumbnail != null
            && Thumbnail.Path != null
            && Thumbnail.Path.ToString().Length != 0
            && !Thumbnail.Path.ToString().Contains("image_not_available");
    }
}

public partial class ComicSeries
{
    [JsonPropertyName("resourceURI")]
    public Uri ResourceUri { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public partial class Date
{
    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("date")]
    public string DateDate { get; set; }
}

public partial class Price
{
    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("price")]
    public double PricePrice { get; set; }
}


