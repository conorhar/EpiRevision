using EpiRevision.Models.Api;
using EPiServer.Data.Dynamic;
using EPiServer.PlugIn;
using EPiServer.Scheduler;
using System.Linq;

namespace EpiRevision.Business.ScheduledJobs
{
    [ScheduledPlugIn(
        DisplayName = "Delete movies",
        Description = "Removes movies from the DDS",
        GUID = "1B737DE2-8883-44D1-BE57-C25FF0B091C7"
    )]
    public class DeleteMovies : ScheduledJobBase
    {
        private bool stopSignal;

        public DeleteMovies()
        {
            IsStoppable = true;
        }

        public override string Execute()
        {
            //delete movies from dds

            if (stopSignal)
            {
                return "The job has been stopped";
            }
            else
            {
                var store = DynamicDataStoreFactory.Instance.CreateStore(typeof(Movie));
                var countMovies = store.Items<Movie>().Count();

                DynamicDataStoreFactory.Instance.DeleteStore(typeof(Movie), true);

                return $"{countMovies} movies were deleted";
            }
        }

        public override void Stop()
        {
            stopSignal = true;
            base.Stop();
        }
    }
}