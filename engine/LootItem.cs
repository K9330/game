using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class LootI
    {
        public Item Details { get; set; }
        public int ItemDropPercentage { get; set; }
        public bool IsDefaultItem { get; set; }

        public LootI(Item details, int itemDropPercentage, bool isDefaultItem)
        {
            Details = details;
            ItemDropPercentage = itemDropPercentage;
            IsDefaultItem = isDefaultItem;
        }
    }
}