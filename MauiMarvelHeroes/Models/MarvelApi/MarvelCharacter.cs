using MauiMarvelHeroes.Services.MarvelApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MauiMarvelHeroes.Models.MarvelApi
{
    public partial class MarvelCharacter : IMarvelQueryable
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("modified")]
        public string Modified { get; set; }

        [JsonPropertyName("thumbnail")]
        public Thumbnail Thumbnail { get; set; }

        [JsonPropertyName("resourceURI")]
        public Uri ResourceUri { get; set; }

        public bool HasThumbnail()
        {
            return Thumbnail != null 
                && Thumbnail.Path != null 
                && Thumbnail.Path.ToString().Length != 0 
                && !Thumbnail.Path.ToString().Contains("image_not_available");
        }
    }



}
