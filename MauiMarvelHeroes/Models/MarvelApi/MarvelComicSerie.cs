﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MauiMarvelHeroes.Models.MarvelApi
{
    public class MarvelComicSerie
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("rating")]
        public string Rating { get; set; }

        [JsonPropertyName("startYear")]
        public int StartYear { get; set; }

        [JsonPropertyName("endYear")]
        public int EndYear { get; set; }

        [JsonPropertyName("thumbnail")]
        public Thumbnail Thumbnail { get; set; }
    }
}
