using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EpiRevision.Models.Api
{
    public class MovieSearch
    {
        [JsonProperty("Search")]
        public IEnumerable<Movie> Search { get; set; }

        [JsonProperty("totalResults")]
        public string TotalResults { get; set; }

        [JsonProperty("Response")]
        public string Response { get; set; }
    }
}