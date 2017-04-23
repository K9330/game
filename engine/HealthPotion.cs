using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class HealthPotion : Item
    {
        public int HealingAmount { get; set; }

        public HealthPotion(int id, string name, string namePlural, int healingAmount) : base(id, name, namePlural)
        {
            HealingAmount = healingAmount;
        }
    }
}