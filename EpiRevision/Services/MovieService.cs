using EpiRevision.Abstractions;
using EpiRevision.Models;
using EpiRevision.Models.Api;
using System.Net.Http;
using System.Threading.Tasks;

namespace EpiRevision.Services
{
    public class MovieService : IMovieService
    {
        public async Task<MovieSearch> Search(string s)
        {
            string url = $"https://www.omdbapi.com/?apikey={Constants.OmdbApiKey}&s={s}";

            MovieSearch searchResult = null;

            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    searchResult = await response.Content.ReadAsAsync<MovieSearch>();
                }
            }

            return searchResult;
        }
    }
}