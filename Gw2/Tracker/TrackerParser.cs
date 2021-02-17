using Gw2.Models.Tracker;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gw2.Tracker
{
    public class TrackerParser : ITrackerParser
    {

        public ICollection<TrackerItem> ParseTrackerSession(string session)
        {
            var trackerItems = new List<TrackerItem>();

            var lines = session.Split('\n');

            for(int i = 1; i < lines.Length; i++)
            {
                var item = lines[i].Split(',');
                trackerItems.Add(new TrackerItem
                {
                    Id = Convert.ToInt32(item[0].Replace("\"", "")),
                    Rarity = item[1].Replace("\"", ""),
                    Type = item[2].Replace("\"", ""),
                    Name = item[3].Replace("\"", ""),
                    Amount = Convert.ToInt32(item[4].Replace("\"", ""))
                });
            }

            return trackerItems;
        }
    }
}
