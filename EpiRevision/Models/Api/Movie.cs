using EPiServer.Data;
using EPiServer.Data.Dynamic;
using Newtonsoft.Json;

namespace EpiRevision.Models.Api
{
    public class Movie : IDynamicData
    {
        [JsonProperty("Title")]
        public string Title { get; set; }

        [JsonProperty("Year")]
        public string Year { get; set; }

        [JsonProperty("imdbID")]
        public string ImdbID { get; set; }

        [JsonProperty("Type")]
        public string Type { get; set; }

        [JsonProperty("Poster")]
        public string Poster { get; set; }
        public Identity Id { get; set; }
    }
}