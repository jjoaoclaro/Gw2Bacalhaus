using Gw2.Connector;
using Gw2.Mapper;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Gw2.Models.Tracker;
using Gw2.Models.Commerce;

namespace Gw2.Tracker
{
    public class TrackerManager : ITrackerManager
    {
        private IApiConnector apiConnector;
        private IApiMapper apiMapper;
        private ITrackerParser trackerParser;
        private readonly ILogger<TrackerManager> logger;

        public TrackerManager(IApiConnector apiConnector, IApiMapper apiMapper, ITrackerParser trackerParser, ILogger<TrackerManager> logger)
        {
            this.trackerParser = trackerParser;
            this.logger = logger;
            this.apiConnector = apiConnector;
            this.apiMapper = apiMapper;
        }

        public int SessionValueHighestOrder(ICollection<TrackerItem> trackerSession)
        {
            logger.LogInformation("into trackerManager");
            //var items = trackerParser.ParseTrackerSession(trackerSession);

            var itemIdList = String.Join(",", trackerSession.Select(a => a.Id));

            var result = apiConnector.ApiCall($"v2/commerce/prices?ids={itemIdList}");

            var listings = apiMapper.MapTo<List<ItemOrderValue>>(result);

            var total = 0;

            foreach(var item in trackerSession)
            {
                var listing = listings.FirstOrDefault(a => a.Id == item.Id);
                if (listing != null)
                {
                    total += listing.Sells.UnitPrice * item.Amount;
                }
            }

            return total;
        }
    }
}
