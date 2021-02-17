using Gw2.Models.Tracker;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gw2.Tracker
{
    public interface ITrackerParser
    {
        ICollection<TrackerItem> ParseTrackerSession(string session);
    }
}
