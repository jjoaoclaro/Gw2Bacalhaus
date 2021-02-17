using Gw2.Items;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Controllers.Items
{
    [ApiController]
    [Route("[controller]")]
    public class ItemsController : ControllerBase
    {
        private IItemsManager itemsManager;
        private readonly ILogger<ItemsController> _logger;

        public ItemsController (IItemsManager itemsManager, ILogger<ItemsController> logger)
        {
            this.itemsManager = itemsManager;
            this._logger = logger;
        }

        //[HttpGet]
        //public IActionResult GetAllItems()
        //{
        //    var result = itemsManager.GetAllItems();

        //    return Ok(result);
        //}

        [HttpGet("/{id}")]
        public IActionResult GetItem(string id)
        {
            var result = itemsManager.GetItem(id);

            return Ok(result);
        }
    }
}
