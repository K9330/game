using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;	
using System.IO;

using Engine;

namespace game
{
    public partial class Game001 : Form
    {
        private Player _player;
        private Enemy _currentE;
        private const string PLAYER_DATA_FILE_NAME = "PlayerData.xml";
        public Game001()
        {
            InitializeComponent();

            if (File.Exists(PLAYER_DATA_FILE_NAME))
            {
                _player = Player.CreatePlayerFromXmlString(File.ReadAllText(PLAYER_DATA_FILE_NAME));
            }
            else
            {
                _player = Player.CreateDefaultPlayer();
            }

            MoveTo(_player.CurrentLocation);

            UpdatePlayerStats();
        }
        private void cboWeapons_SelectedIndexChanged(object sender, EventArgs e)
        {
            _player.CurrentWeapon = (Weapon)cboWeapons.SelectedItem;
        }
        private void btnNorth_Click(object sender, EventArgs e)
        {
            MoveTo(_player.CurrentLocation.LocationToNorth);
        }

        private void btnEast_Click(object sender, EventArgs e)
        {
            MoveTo(_player.CurrentLocation.LocationToEast);
        }

        private void btnSouth_Click(object sender, EventArgs e)
        {
            MoveTo(_player.CurrentLocation.LocationToSouth);
        }

        private void btnWest_Click(object sender, EventArgs e)
        {
            MoveTo(_player.CurrentLocation.LocationToWest);
        }

        private void UpdatePlayerStats()
        {
            // Refresh player information and inventory controls
            lblHitPoints.Text = _player.CurrentHP.ToString();
            lblGold.Text = _player.Gold.ToString();
            lblExperience.Text = _player.ExperiencePoints.ToString();
            lblLevel.Text = _player.Level.ToString();
        }

        private void MoveTo(Location newLocation)
        {
            //Does the location have any required items
            if (!_player.HasRequiredItemToEnterThisLocation(newLocation))
            {
                rtbMessages.Text += "You must have a " + newLocation.IRequiredToEnter.Name + " to enter this location." + Environment.NewLine;
                return;
            }

            
            _player.CurrentLocation = newLocation;

            
            btnNorth.Visible = (newLocation.LocationToNorth != null);
            btnEast.Visible = (newLocation.LocationToEast != null);
            btnSouth.Visible = (newLocation.LocationToSouth != null);
            btnWest.Visible = (newLocation.LocationToWest != null);

            
            rtbLocation.Text = newLocation.Name + Environment.NewLine;
            rtbLocation.Text += newLocation.Description + Environment.NewLine;

            // Completely heal the player
            _player.CurrentHP = _player.MaxHP;

            // Update Hit Points in UI
            lblHitPoints.Text = _player.CurrentHP.ToString();


            
            if (newLocation.QAvailableHere != null)
            {
                // See if the player already has the quest, and if they've completed it
                bool pAlreadyHasQ = _player.HasThisQuest(newLocation.QAvailableHere);
                bool playerAlreadyCompletedQuest = _player.CompletedThisQuest(newLocation.QAvailableHere);

                
                if (pAlreadyHasQ)
                {
                    
                    if (!playerAlreadyCompletedQuest)
                    {
                        
                        bool playerHasAllIToCompleteQ = _player.HasAllQCompletionI(newLocation.QAvailableHere);
                        
                        if (playerHasAllIToCompleteQ)
                        {
                           
                            rtbMessages.Text += Environment.NewLine;
                            rtbMessages.Text += "You complete the '" + newLocation.QAvailableHere.Name + "' quest." + Environment.NewLine;

                            
                            _player.RemoveQCompletionI(newLocation.QAvailableHere);

                            // Give quest rewards
                            rtbMessages.Text += "You receive: " + Environment.NewLine;
                            rtbMessages.Text += newLocation.QAvailableHere.RewardExperiencePoints.ToString() + " experience points" + Environment.NewLine;
                            rtbMessages.Text += newLocation.QAvailableHere.RewardGold.ToString() + " gold" + Environment.NewLine;
                            rtbMessages.Text += newLocation.QAvailableHere.RewardItem.Name + Environment.NewLine;
                            rtbMessages.Text += Environment.NewLine;

                            _player.AddExperiencePoints(newLocation.QAvailableHere.RewardExperiencePoints);
                            _player.Gold += newLocation.QAvailableHere.RewardGold;

                            // Add the reward inventory
                            _player.AddIToInventory(newLocation.QAvailableHere.RewardItem);

                            // Mark the quest as completed
                            _player.MarkQCompleted(newLocation.QAvailableHere);
                        }
                    }
                }
                else
                {
                    
                    
                    rtbMessages.Text += "You receive the " + newLocation.QAvailableHere.Name + " quest." + Environment.NewLine;
                    rtbMessages.Text += newLocation.QAvailableHere.Description + Environment.NewLine;
                    rtbMessages.Text += "To complete it, return with:" + Environment.NewLine;
                    foreach (QCompletionI qci in newLocation.QAvailableHere.QCompletionI)
                    {
                        if (qci.Quantity == 1)
                        {
                            rtbMessages.Text += qci.Quantity.ToString() + " " + qci.Details.Name + Environment.NewLine;
                        }
                        else
                        {
                            rtbMessages.Text += qci.Quantity.ToString() + " " + qci.Details.NamePlural + Environment.NewLine;
                        }
                    }
                    rtbMessages.Text += Environment.NewLine;

                    // Add the quest to the player's quest list
                    _player.Quests.Add(new PQ(newLocation.QAvailableHere));
                }
            }

            
            if (newLocation.EnemysExistence != null)
            {
                rtbMessages.Text += "You see a " + newLocation.EnemysExistence.Name + Environment.NewLine;

                // Make a new enemy
                Enemy standardE = AllStuff.EnemyByID(newLocation.EnemysExistence.ID);

                _currentE = new Enemy(standardE.ID, standardE.Name, standardE.MaximumDamage,
                    standardE.RewardExperiencePoints, standardE.GoldReward, standardE.CurrentHP, standardE.MaxHP);

                foreach (LootI lootI in standardE.LootTable)
                {
                    _currentE.LootTable.Add(lootI);
                }

                cboWeapons.Visible = true;
                cboPotions.Visible = true;
                btnUseWeapon.Visible = true;
                btnUsePotion.Visible = true;
            }
            else
            {
                _currentE = null;

                cboWeapons.Visible = false;
                cboPotions.Visible = false;
                btnUseWeapon.Visible = false;
                btnUsePotion.Visible = false;
            }

            // Refresh player's inventory list
            UpdateInventoryListInUI();

            // Refresh player's quest list
            UpdateQuestListInUI();

            // Refresh player's weapons combobox
            UpdateWeaponListInUI();

            // Refresh player's potions combobox
            UpdatePotionListInUI();
        }

        private void UpdateInventoryListInUI()
        {
            dgvInventory.RowHeadersVisible = false;

            dgvInventory.ColumnCount = 2;
            dgvInventory.Columns[0].Name = "Name";
            dgvInventory.Columns[0].Width = 197;
            dgvInventory.Columns[1].Name = "Quantity";

            dgvInventory.Rows.Clear();

            foreach (InventoryI inventoryItem in _player.Inventory)
            {
                if (inventoryItem.Quantity > 0)
                {
                    dgvInventory.Rows.Add(new[] { inventoryItem.Details.Name, inventoryItem.Quantity.ToString() });
                }
            }
        }

        private void UpdateQuestListInUI()
        {
            dgvQuests.RowHeadersVisible = false;

            dgvQuests.ColumnCount = 2;
            dgvQuests.Columns[0].Name = "Name";
            dgvQuests.Columns[0].Width = 197;
            dgvQuests.Columns[1].Name = "Done?";

            dgvQuests.Rows.Clear();

            foreach (PQ playerQuest in _player.Quests)
            {
                dgvQuests.Rows.Add(new[] { playerQuest.Details.Name, playerQuest.IsCompleted.ToString() });
            }
        }

        private void UpdateWeaponListInUI()
        {
            List<Weapon> weapons = new List<Weapon>();

            foreach (InventoryI inventoryItem in _player.Inventory)
            {
                if (inventoryItem.Details is Weapon)
                {
                    if (inventoryItem.Quantity > 0)
                    {
                        weapons.Add((Weapon)inventoryItem.Details);
                    }
                }

                if (weapons.Count == 0)
                {
                    // The player doesn't have any weapons, so hide the weapon combobox and "Use" button
                    cboWeapons.Visible = false;
                    btnUseWeapon.Visible = false;
                }
                else
                {
                    cboWeapons.SelectedIndexChanged -= cboWeapons_SelectedIndexChanged;
                    cboWeapons.DataSource = weapons;
                    cboWeapons.SelectedIndexChanged += cboWeapons_SelectedIndexChanged;
                    cboWeapons.DisplayMember = "Name";
                    cboWeapons.ValueMember = "ID";

                    if (_player.CurrentWeapon != null)
                    {
                        cboWeapons.SelectedItem = _player.CurrentWeapon;
                    }
                    else
                    {
                        cboWeapons.SelectedIndex = 0;
                    }
                }

            }

            if (weapons.Count == 0)
            {
                // The player doesn't have any weapons, so hide the weapon combobox and "Use" button
                cboWeapons.Visible = false;
                btnUseWeapon.Visible = false;
            }
            else
            {
                cboWeapons.DataSource = weapons;
                cboWeapons.DisplayMember = "Name";
                cboWeapons.ValueMember = "ID";

                cboWeapons.SelectedIndex = 0;
            }
        }

        private void UpdatePotionListInUI()
        {
            List<HealthPotion> healingPotions = new List<HealthPotion>();

            foreach (InventoryI inventoryItem in _player.Inventory)
            {
                if (inventoryItem.Details is HealthPotion)
                {
                    if (inventoryItem.Quantity > 0)
                    {
                        healingPotions.Add((HealthPotion)inventoryItem.Details);
                    }
                }
            }

            if (healingPotions.Count == 0)
            {
                // The player doesn't have any potions, so hide the potion combobox and "Use" button
                cboPotions.Visible = false;
                btnUsePotion.Visible = false;
            }
            else
            {
                cboPotions.DataSource = healingPotions;
                cboPotions.DisplayMember = "Name";
                cboPotions.ValueMember = "ID";

                cboPotions.SelectedIndex = 0;
            }
        }

        private void btnUseWeapon_Click(object sender, EventArgs e)
        {
            // Get the currently selected weapon from the cboWeapons ComboBox
            Weapon currentWeapon = (Weapon)cboWeapons.SelectedItem;

            // Determine the amount of damage to do to the monster
            int damageToE = RandomNumberGenerator.NumberBetween(currentWeapon.MinimumDamage, currentWeapon.MaximumDamage);

            // Apply the damage to the monster's CurrentHitPoints
            _currentE.CurrentHP -= damageToE;

            // Display message
            rtbMessages.Text += "You hit the " + _currentE.Name + " for " + damageToE.ToString() + " points." + Environment.NewLine;

            // Check if the monster is dead
            if (_currentE.CurrentHP <= 0)
            {
                
                rtbMessages.Text += Environment.NewLine;
                rtbMessages.Text += "You defeated the " + _currentE.Name + Environment.NewLine;

                // Give player experience points for killing
                _player.AddExperiencePoints(_currentE.RewardExperiencePoints);
                rtbMessages.Text += "You receive " + _currentE.RewardExperiencePoints.ToString() + " experience points" + Environment.NewLine;

                // Give player gold for killing 
                _player.Gold += _currentE.GoldReward;
                rtbMessages.Text += "You receive " + _currentE.GoldReward.ToString() + " gold" + Environment.NewLine;

                // Get random loot items from the enemy
                List<InventoryI> lootedItems = new List<InventoryI>();

                // Add items to the lootedItems list, comparing a random number to the drop percentage
                foreach (LootI lootItem in _currentE.LootTable)
                {
                    if (RandomNumberGenerator.NumberBetween(1, 100) <= lootItem.ItemDropPercentage)
                    {
                        lootedItems.Add(new InventoryI(lootItem.Details, 1));
                    }
                }

                // If no items were randomly selected, then add the default loot item(s).
                if (lootedItems.Count == 0)
                {
                    foreach (LootI lootItem in _currentE.LootTable)
                    {
                        if (lootItem.IsDefaultItem)
                        {
                            lootedItems.Add(new InventoryI(lootItem.Details, 1));
                        }
                    }
                }

                // Add the looted items to the player's inventory
                foreach (InventoryI inventoryI in lootedItems)
                {
                    _player.AddIToInventory(inventoryI.Details);

                    if (inventoryI.Quantity == 1)
                    {
                        rtbMessages.Text += "You loot " + inventoryI.Quantity.ToString() + " " + inventoryI.Details.Name + Environment.NewLine;
                    }
                    else
                    {
                        rtbMessages.Text += "You loot " + inventoryI.Quantity.ToString() + " " + inventoryI.Details.NamePlural + Environment.NewLine;
                    }
                }

                // Refresh player information and inventory controls
                lblHitPoints.Text = _player.CurrentHP.ToString();
                lblGold.Text = _player.Gold.ToString();
                lblExperience.Text = _player.ExperiencePoints.ToString();
                lblLevel.Text = _player.Level.ToString();

                UpdateInventoryListInUI();
                UpdateWeaponListInUI();
                UpdatePotionListInUI();

                // Add a blank line to the messages box, just for appearance.
                rtbMessages.Text += Environment.NewLine;

                // Move player to current location (to heal player and create a new monster to fight)
                MoveTo(_player.CurrentLocation);
            }
            else
            {
                // Monster is still alive
                                
                int damageToPlayer = RandomNumberGenerator.NumberBetween(0, _currentE.MaximumDamage);
                
                rtbMessages.Text += "The " + _currentE.Name + " did " + damageToPlayer.ToString() + " points of damage." + Environment.NewLine;

                // Subtract damage from player
                _player.CurrentHP -= damageToPlayer;

                // Refresh player data in UI
                lblHitPoints.Text = _player.CurrentHP.ToString();

                if (_player.CurrentHP <= 0)
                {
                    // Display message
                    rtbMessages.Text += "The " + _currentE.Name + " killed you." + Environment.NewLine;

                    // Move player to "Home"
                    MoveTo(AllStuff.LocationByID(AllStuff.L_ID_HOME));
                }
            }
        }

        private void ScrollToBottomOfMessages()
        {
            rtbMessages.SelectionStart = rtbMessages.Text.Length;
            rtbMessages.ScrollToCaret();
        }

        private void btnUsePotion_Click(object sender, EventArgs e)
        {
            // Get the currently selected potion from the combobox
            HealthPotion potion = (HealthPotion)cboPotions.SelectedItem;

            // Add healing amount to the player's current hit points
            _player.CurrentHP = (_player.CurrentHP + potion.HealingAmount);

            // CurrentHitPoints cannot exceed player's MaximumHitPoints
            if (_player.CurrentHP > _player.MaxHP)
            {
                _player.CurrentHP = _player.MaxHP;
            }

            // Remove the potion from the player's inventory
            foreach (InventoryI ii in _player.Inventory)
            {
                if (ii.Details.ID == potion.ID)
                {
                    ii.Quantity--;
                    break;
                }
            }

            // Display message
            rtbMessages.Text += "You drink a " + potion.Name + Environment.NewLine;

            // Monster gets their turn to attack

            // Determine the amount of damage the monster does to the player
            int damageToPlayer = RandomNumberGenerator.NumberBetween(0, _currentE.MaximumDamage);

            // Display message
            rtbMessages.Text += "The " + _currentE.Name + " did " + damageToPlayer.ToString() + " points of damage." + Environment.NewLine;

            // Subtract damage from player
            _player.CurrentHP -= damageToPlayer;

            if (_player.CurrentHP <= 0)
            {
                // Display message
                rtbMessages.Text += "The " + _currentE.Name + " killed you." + Environment.NewLine;

                // Move player to "Home"
                MoveTo(AllStuff.LocationByID(AllStuff.L_ID_HOME));
            }

            // Refresh player data in UI
            lblHitPoints.Text = _player.CurrentHP.ToString();
            UpdateInventoryListInUI();
            UpdatePotionListInUI();
        }

        private void Game001_FormClosing(object sender, FormClosingEventArgs e)
        {
            File.WriteAllText(PLAYER_DATA_FILE_NAME, _player.ToXmlString());
        }
    }
}