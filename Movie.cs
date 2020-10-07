﻿using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace SampleApp
{
    public class Movie
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [Required]
        [Display(Name = "Movie Name")]
        [JsonProperty(PropertyName = "movieName")]
        public string MovieName { get; set; }

        [Required]
        [JsonProperty(PropertyName = "rating")]
        public string Rating { get; set; }

        [Required]
        [Display(Name = "Release Date")]
        [JsonProperty(PropertyName = "releaseDate")]
        public DateTime ReleaseDate { get; set; }
    }

}
