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

            _player.MaximumHitPoints = 10;
            _player.CurrentHitPoints = 10;
            _player.MaximumMacigPoints = 0;
            _player.CurrentMagicPoints = 0;
            _player.Gold = 100;
            _player.Level = 0;
            _player.ExperiencePoints = 0;

            lblmaxhp.Text = _player.MaximumHitPoints.ToString();
            lblcurrenthp.Text = _player.CurrentHitPoints.ToString();
            lblmaxmp.Text = _player.MaximumMacigPoints.ToString();
            lblcurrentmp.Text = _player.CurrentMagicPoints.ToString();
            lblgold.Text = _player.Gold.ToString();
            lbllevel.Text = _player.Level.ToString();
            lblexperience.Text = _player.ExperiencePoints.ToString();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        
    }
}
