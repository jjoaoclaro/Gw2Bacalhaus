using Gw2.Connector;
using Gw2.Items;
using Gw2.Mapper;
using Gw2.Tracker;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gw2
{
    public class DependencyControl
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            ConnectorContainer.ConfigureServices(services);

            services.AddTransient<IApiMapper, ApiMapper>();
            services.AddTransient<IItemsManager, ItemsManager>();
            services.AddTransient<ITrackerParser, TrackerParser>();
            services.AddTransient<ITrackerManager, TrackerManager>();

        }
    }
}
