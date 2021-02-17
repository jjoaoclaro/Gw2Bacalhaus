using Gw2.Models.Tracker;
using Gw2.Tracker;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Controllers.Tracker
{
    [ApiController]
    [Route("[controller]")]
    public class TrackerController : ControllerBase
    {
        private readonly ILogger<TrackerController> _logger;
        private ITrackerManager trackerManager;

        public TrackerController(ILogger<TrackerController> logger, ITrackerManager trackerManager)
        {
            this._logger = logger;
            this.trackerManager = trackerManager;
        }



        [HttpPost("/buyOrder")]
        public IActionResult GetSessionValueBuyOrder([FromBody] ICollection<TrackerItem> trackerSession)
        {
            _logger.LogInformation("cenas");

            return Ok(trackerManager.SessionValueHighestOrder(trackerSession));
        }
    }
}
