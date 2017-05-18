using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Attack
    {
        public int AttackId { get; set; } 
        public string AttackName { get; set; }
        public int DamageType { get; set; }
        public int MaxDamage { get; set; }
        public int MinDamage { get; set; }

        public Attack(int attackId, string attackName, int damageType, int maxDamage, int minDamage)
        {
            AttackId = attackId;
            AttackName = attackName;
            DamageType = damageType;
            MaxDamage = maxDamage;
            MinDamage = minDamage;
        }
            
    }
}
