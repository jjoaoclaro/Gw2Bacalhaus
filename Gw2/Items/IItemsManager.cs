using Gw2.Models.BaseModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gw2.Items
{
    public interface IItemsManager
    {
        public ICollection<int> GetAllItems();

        public ItemComplete GetItem(string id);
    }
}
