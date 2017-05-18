using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Creatures
    {
        public int CurrentHP { get; set; }
        public int MaxHP { get; set; }
        public int BluntResPerc { get; set; }
        public int SlashResPerc { get; set; }
        public int PierceRecPerc { get; set; }
        public int FireRecPerc { get; set; }
        public int WaterRecPerc { get; set; }
        public int MagicRecPerc { get; set; }
        public int DodgePerc { get; set; }
        public int BlockPerc { get; set; }
        public int ParryPerc { get; set; }

        public Creatures(int currentHP, int maxHP, int bluntResPerc, int slashResPerc, int pierceRecPerc, int fireRecPerc, int waterRecPerc, int magicRecPerc, int dodgePerc, int blockPerc, int parryPerc)
        {
            CurrentHP = currentHP;
            MaxHP = maxHP;
            BluntResPerc = bluntResPerc;
            SlashResPerc = slashResPerc;
            PierceRecPerc = pierceRecPerc;
            FireRecPerc = fireRecPerc;
            WaterRecPerc = waterRecPerc;
            MagicRecPerc = magicRecPerc;
            DodgePerc = dodgePerc;
            BlockPerc = blockPerc;
            ParryPerc = parryPerc;
        }
    }
}