using Gw2.Connector;
using Gw2.Mapper;
using Gw2.Models.BaseModels;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gw2.Items
{
    public class ItemsManager : IItemsManager
    {
        private IApiConnector apiConnector;
        private IApiMapper apiMapper;
        private readonly ILogger<ItemsManager> logger;

        public ItemsManager(IApiConnector apiConnector, IApiMapper apiMapper, ILogger<ItemsManager> logger)
        {
            this.apiConnector = apiConnector;
            this.apiMapper = apiMapper;
            this.logger = logger;
        }

        public ICollection<int> GetAllItems()
        {
            logger.LogInformation("Items Manager doing stuff");
            var items = apiConnector.ApiCall("v2/items");
            return apiMapper.MapTo<List<int>>(items);
        }

        public ItemComplete GetItem(string id)
        {
            logger.LogInformation("Items Manager doing stuff");
            var item = apiConnector.ApiCall($"v2/items/{id}");
            logger.LogInformation(id);
            logger.LogInformation(item);
            return apiMapper.MapTo<ItemComplete>(item);
        }


    }
}
