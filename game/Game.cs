using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Engine;

namespace game
{
    public partial class Game : Form
    {
        private Player _player;
        public Game()
        {

            InitializeComponent();

            _player = new Player();

            //stats
            _player.MaximumHitPoints = 10;
            _player.CurrentHitPoints = 10;
            _player.MaximumStamina = 10;
            _player.CurrentStamina = 10;
            _player.MaximumMacigPoints = 0;
            _player.CurrentMagicPoints = 0;
            _player.Gold = 100;
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
            
            lblmaxhp.Text = _player.MaximumHitPoints.ToString();
            lblcurrenthp.Text = _player.CurrentHitPoints.ToString();
            lblmaxmp.Text = _player.MaximumMacigPoints.ToString();
            lblcurrentmp.Text = _player.CurrentMagicPoints.ToString();
            lblcurrentstamina.Text = _player.Gold.ToString();
            lblgold.Text = _player.Potential.ToString();
        }

        private void Game_Load(object sender, EventArgs e)
        {

        }
        
    }
}
