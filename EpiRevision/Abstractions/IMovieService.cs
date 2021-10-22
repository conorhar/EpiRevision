using EpiRevision.Models.Api;
using System.Threading.Tasks;

namespace EpiRevision.Abstractions
{
    public interface IMovieService
    {
        Task<MovieSearch> Search(string s);
        Task<Movie> GetMovie(string id);
    }
}