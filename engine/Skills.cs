using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Skills
    {
        /*

        public int Potential { get; set; }//Primary level
        public int SurvivalPotential { get; set; }//Secondary ability level
        public int SurvivalPotentialEXP { get; set; }//Secondary ability level experience
        public int ClothArmorPotential { get; set; }//Secondary ability level
        public int ClothArmorPotentialEXP { get; set; }//Secondary ability level experience
        public int LightArmorPotential { get; set; }//Secondary ability level
        public int LightArmorPotentialEXP { get; set; }//Secondary ability level experience
        public int HeavyArmorPotential { get; set; }//Secondary ability level
        public int HeavyArmorPotentialEXP { get; set; }//Secondary ability level experience
        public int ShieldPotential { get; set; }//Secondary ability level
        public int ShieldPotentialEXP { get; set; }//Secondary ability level experience
        public int OnehandedPotential { get; set; }//Secondary ability level
        public int OnehandedPotentialEXP { get; set; }//Secondary ability level experience
        public int TwohandedPotential { get; set; }//Secondary ability level
        public int TwohandedPotentialEXP { get; set; }//Secondary ability level experience
        public int PolearmPotential { get; set; }//Secondary ability level
        public int PolearmPotentialEXP { get; set; }//Secondary ability level experience
        public int StaffTypePotential { get; set; }//Sub ability level
        public int StaffTypePotentialEXP { get; set; }//Sub ability level experience
        public int SpearTypePotential { get; set; }//Sub ability level
        public int SpearTypePotentialEXP { get; set; }//Sub ability level experience
        public int PolearmSpecialTypePotential { get; set; }//Sub ability level
        public int PolearmSpecialTypePotentialEXP { get; set; }//Sub ability level experience
        public int PladePotential { get; set; }//Secondary ability level
        public int PladePotentialEXP { get; set; }//Secondary ability level experience
        public int SwordPotential { get; set; }//Sub ability level
        public int SwordPotentialEXP { get; set; }//Sub ability level experience
        public int DaggerPotential { get; set; }//Sub ability level
        public int DaggerPotentialEXP { get; set; }//Sub ability level experience
        public int BluntPotential { get; set; }//Secondary ability level
        public int BluntPotentialEXP { get; set; }//Secondary ability level experience
        public int HammerPotential { get; set; }//Sub ability level
        public int HammerPotentialEXP { get; set; }//Sub ability level experience
        public int MacePotential { get; set; }//Sub ability level
        public int MacePotentialEXP { get; set; }//Sub ability level experience
        public int ArcheryPotential { get; set; }//Secondary ability level
        public int ArcheryPotentialEXP { get; set; }//Secondary ability level experience
        public int BowPotential { get; set; }//Sub ability level
        public int BowPotentialEXP { get; set; }//Sub ability levele xperience
        public int CrossbowPotential { get; set; }//Sub ability level
        public int CrossbowPotentialEXP { get; set; }//Sub ability level experience
        public int throwingPotential { get; set; }//Sub ability level
        public int throwingPotentialEXP { get; set; }//Sub ability level experience
        public int HandToHandPotential { get; set; }//Secondary ability level
        public int HandToHandPotentialEXP { get; set; }//Secondary ability level experience
        public int BodyManipulationPotential { get; set; }//Secondary ability level
        public int BodyManipulationPotentialEXP { get; set; }//Secondary ability level experience
        public int StaminaPotential { get; set; }//Secondary ability level
        public int StaminaPotentialEXP { get; set; }//Secondary ability level experience
        public int StrengthPotential { get; set; }//Sub ability level
        public int StrengthPotentialEXP { get; set; }//Sub ability level experience
        public int SpeedPotential { get; set; }//Sub ability level
        public int SpeedPotentialEXP { get; set; }//Sub ability level experience
        public int MagicManipulationPotential { get; set; }//Secondary ability level
        public int MagicManipulationPotentialEXP { get; set; }//Secondary ability level experience
        public int ArtifactMagicManipulationPotential { get; set; }//Sub ability level
        public int ArtifactMagicManipulationPotentialEXP { get; set; }//Sub ability level experience
        public int UnarmedMagicManipulationPotential { get; set; }//Sub ability level
        public int UnarmedMagicManipulationPotentialEXP { get; set; }//Sub ability level experience
        public int ElementMagicManipulationPotential { get; set; }//Sub ability level
        public int ElementMagicManipulationPotentialEXP { get; set; }//Sub ability level experience
        public int DestructionMagicManipulationPotential { get; set; }//Sub ability level
        public int DestructionMagicManipulationPotentialEXP { get; set; }//Sub ability level experience
        public int CreationMagicManipulationPotential { get; set; }//Sub ability level
        public int CreationMagicManipulationPotentialEXP { get; set; }//Sub ability level experience
        public int MagicPowerPotential { get; set; }//Secondary ability level
        public int MagicPowerPotentialEXP { get; set; }//Secondary ability level experience

        public Skills( int Potential, int SurvivalPotential, int SurvivalPotentialEXP, int ClothArmorPotential, int ClothArmorPotentialEXP, int LightArmorPotential, int LightArmorPotentialEXP, int HeavyArmorPotential, int HeavyArmorPotentialEXP, int ShieldPotential, int ShieldPotentialEXP, int OnehandedPotential,  int OnehandedPotentialEXP,  int TwohandedPotential, int TwohandedPotentialEXP, int PolearmPotential, int PolearmPotentialEXP, int StaffTypePotential, int StaffTypePotentialEXP,
         int SpearTypePotential,
         int SpearTypePotentialEXP,
         int PolearmSpecialTypePotential,
         int PolearmSpecialTypePotentialEXP,
         int PladePotential,
         int PladePotentialEXP,
         int SwordPotential,
        int SwordPotentialEXP,
         int DaggerPotential,
         int DaggerPotentialEXP,
         int BluntPotential,
         int BluntPotentialEXP,
         int HammerPotential,
         int HammerPotentialEXP,
         int MacePotential,
         int MacePotentialEXP,
         int ArcheryPotential,
         int ArcheryPotentialEXP,
         int BowPotential,
         int BowPotentialEXP,
         int CrossbowPotential,
         int CrossbowPotentialEXP,
         int throwingPotential,
         int throwingPotentialEXP,
         int HandToHandPotential,
         int HandToHandPotentialEXP,
         int BodyManipulationPotential,
         int BodyManipulationPotentialEXP,
        int StaminaPotential,
         int StaminaPotentialEXP,
         int StrengthPotential,
         int StrengthPotentialEXP,
         int SpeedPotential,
         int SpeedPotentialEXP,
        int MagicManipulationPotential,
         int MagicManipulationPotentialEXP,
         int ArtifactMagicManipulationPotential,
         int ArtifactMagicManipulationPotentialEXP,
         int UnarmedMagicManipulationPotential,
         int UnarmedMagicManipulationPotentialEXP,
         int ElementMagicManipulationPotential,
         int ElementMagicManipulationPotentialEXP,
         int DestructionMagicManipulationPotential,
         int DestructionMagicManipulationPotentialEXP,
         int CreationMagicManipulationPotential,
         int CreationMagicManipulationPotentialEXP,
         int MagicPowerPotential,
         int MagicPowerPotentialEXP);


        _player.Potential = 0;

            //skills
            _player.SurvivalPotential = 0;
            _player.SurvivalPotentialEXP = 0;
            _player.ClothArmorPotential = 0;
            _player.ClothArmorPotentialEXP = 0;
            _player.LightArmorPotential = 0;
            _player.LightArmorPotentialEXP = 0;
            _player.HeavyArmorPotential = 0;
            _player.HeavyArmorPotentialEXP = 0;
            _player.ShieldPotential = 0;
            _player.ShieldPotentialEXP = 0;
            _player.OnehandedPotential = 0;
            _player.OnehandedPotentialEXP = 0;
            _player.TwohandedPotential = 0;
            _player.TwohandedPotentialEXP = 0;
            _player.PolearmPotential = 0;
            _player.PolearmPotentialEXP = 0;
            _player.StaffTypePotential = 0;
            _player.StaffTypePotentialEXP = 0;
            _player.SpearTypePotential = 0;
            _player.SpearTypePotentialEXP = 0;
            _player.PolearmSpecialTypePotential = 0;
            _player.PolearmSpecialTypePotentialEXP = 0;
            _player.PladePotential = 0;
            _player.PladePotentialEXP = 0;
            _player.SwordPotential = 0;
            _player.SwordPotentialEXP = 0;
            _player.DaggerPotential = 0;
            _player.DaggerPotentialEXP = 0;
            _player.BluntPotential = 0;
            _player.BluntPotentialEXP = 0;
            _player.HammerPotential = 0;
            _player.HammerPotentialEXP = 0;
            _player.MacePotential = 0;
            _player.MacePotentialEXP = 0;
            _player.ArcheryPotential = 0;
            _player.ArcheryPotentialEXP = 0;
            _player.BowPotential = 0;
            _player.BowPotentialEXP = 0;
            _player.CrossbowPotential = 0;
            _player.CrossbowPotentialEXP = 0;
            _player.throwingPotential = 0;
            _player.throwingPotentialEXP = 0;
            _player.HandToHandPotential = 0;
            _player.HandToHandPotentialEXP = 0;
            _player.BodyManipulationPotential = 0;
            _player.BodyManipulationPotentialEXP = 0;
            _player.StaminaPotential = 0;
            _player.StaminaPotentialEXP = 0;
            _player.StrengthPotential = 0;
            _player.StrengthPotentialEXP = 0;
            _player.SpeedPotential = 0;
            _player.SpeedPotentialEXP = 0;
            _player.MagicManipulationPotential = 0;
            _player.MagicManipulationPotentialEXP = 0;
            _player.ArtifactMagicManipulationPotential = 0;
            _player.ArtifactMagicManipulationPotentialEXP = 0;
            _player.UnarmedMagicManipulationPotential = 0;
            _player.UnarmedMagicManipulationPotentialEXP = 0;
            _player.ElementMagicManipulationPotential = 0;
            _player.ElementMagicManipulationPotentialEXP = 0;
            _player.DestructionMagicManipulationPotential = 0;
            _player.DestructionMagicManipulationPotentialEXP = 0;
            _player.CreationMagicManipulationPotential = 0;
            _player.CreationMagicManipulationPotentialEXP = 0;
            _player.MagicPowerPotential = 0;
            _player.MagicPowerPotentialEXP = 0;
            */
    }
}
