using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Enemy : Creatures
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int MaximumDamage { get; set; }
        public int RewardExperiencePoints { get; set; }
        public int GoldReward { get; set; }
        public List<LootI> LootTable { get; set; }
        public List<Attack> AttackList { get; set; }

        public Enemy(int id, string name, int maximumDamage, int rewardExperiencePoints, int goldReward, int CurrentHP, int MaxHP, int bluntResPerc, int slashResPerc, int pierceRecPerc, int fireRecPerc, int waterRecPerc, int magicRecPerc, int dodgePerc, int blockPerc, int parryPerc)
            : base(CurrentHP, MaxHP, bluntResPerc, slashResPerc, pierceRecPerc, fireRecPerc, waterRecPerc, magicRecPerc, dodgePerc, blockPerc, parryPerc)
        {
            ID = id;
            Name = name;
            MaximumDamage = maximumDamage;
            RewardExperiencePoints = rewardExperiencePoints;
            GoldReward = goldReward;
            LootTable = new List<LootI>();
            AttackList = new List<Attack>();
        }
    }
}