using System.Configuration;

namespace EpiRevision.Models
{
    public class Constants
    {
        public static string OmdbApiKey => ConfigurationManager.AppSettings["OmdbApiKey"];
    }
}