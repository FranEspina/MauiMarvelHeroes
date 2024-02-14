using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MauiMarvelHeroes.Models.MarvelApi
{

    public partial class MarvelComic
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

        [JsonPropertyName("textObjects")]
        public List<TextObject> TextObjects { get; set; }

        [JsonPropertyName("resourceURI")]
        public Uri ResourceUri { get; set; }

        [JsonPropertyName("urls")]
        public List<Url> Urls { get; set; }

        [JsonPropertyName("series")]
        public Series Series { get; set; }

        [JsonPropertyName("variants")]
        public List<Series> Variants { get; set; }

        [JsonPropertyName("collections")]
        public List<object> Collections { get; set; }

        [JsonPropertyName("collectedIssues")]
        public List<object> CollectedIssues { get; set; }

        [JsonPropertyName("dates")]
        public List<Date> Dates { get; set; }

        [JsonPropertyName("prices")]
        public List<Price> Prices { get; set; }

        [JsonPropertyName("thumbnail")]
        public Thumbnail Thumbnail { get; set; }

        [JsonPropertyName("images")]
        public List<Thumbnail> Images { get; set; }

        [JsonPropertyName("creators")]
        public Creators Creators { get; set; }

        [JsonPropertyName("characters")]
        public Characters Characters { get; set; }

        [JsonPropertyName("stories")]
        public Stories Stories { get; set; }

        [JsonPropertyName("events")]
        public Characters Events { get; set; }
    }

    public partial class Characters
    {
        [JsonPropertyName("available")]
        public long Available { get; set; }

        [JsonPropertyName("collectionURI")]
        public Uri CollectionUri { get; set; }

        [JsonPropertyName("items")]
        public List<Series> Items { get; set; }

        [JsonPropertyName("returned")]
        public long Returned { get; set; }
    }

    public partial class Series
    {
        [JsonPropertyName("resourceURI")]
        public Uri ResourceUri { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }

    public partial class Creators
    {
        [JsonPropertyName("available")]
        public long Available { get; set; }

        [JsonPropertyName("collectionURI")]
        public Uri CollectionUri { get; set; }

        [JsonPropertyName("items")]
        public List<CreatorsItem> Items { get; set; }

        [JsonPropertyName("returned")]
        public long Returned { get; set; }
    }

    public partial class CreatorsItem
    {
        [JsonPropertyName("resourceURI")]
        public Uri ResourceUri { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("role")]
        public string Role { get; set; }
    }

    public partial class Date
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("date")]
        public string DateDate { get; set; }
    }

    public partial class Thumbnail
    {
        [JsonPropertyName("path")]
        public Uri Path { get; set; }

        [JsonPropertyName("extension")]
        public string Extension { get; set; }
    }

    public partial class Price
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("price")]
        public double PricePrice { get; set; }
    }

    public partial class Stories
    {
        [JsonPropertyName("available")]
        public long Available { get; set; }

        [JsonPropertyName("collectionURI")]
        public Uri CollectionUri { get; set; }

        [JsonPropertyName("items")]
        public List<StoriesItem> Items { get; set; }

        [JsonPropertyName("returned")]
        public long Returned { get; set; }
    }

    public partial class StoriesItem
    {
        [JsonPropertyName("resourceURI")]
        public Uri ResourceUri { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }
    }

    public partial class TextObject
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("language")]
        public string Language { get; set; }

        [JsonPropertyName("text")]
        public string Text { get; set; }
    }

    public partial class Url
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("url")]
        public Uri UrlUrl { get; set; }
    }



  

   

    

    

    

    
}
