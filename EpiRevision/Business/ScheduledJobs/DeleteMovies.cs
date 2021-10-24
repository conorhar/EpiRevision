using EPiServer.PlugIn;
using EPiServer.Scheduler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;

namespace EpiRevision.Business.ScheduledJobs
{
    [ScheduledPlugIn(
        DisplayName = "A test job",
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
                Thread.Sleep(5000);
                return "The job has been stopped";
            }
            else
            {
                Thread.Sleep(5000);
                return "to do!!!!!!!!!";
            }
        }

        public override void Stop()
        {
            stopSignal = true;
            base.Stop();
        }
    }
}