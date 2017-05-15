using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public static class AllStuff
    {
        public static readonly List<Item> Items = new List<Item>();
        public static readonly List<Enemy> Enemys = new List<Enemy>();
        public static readonly List<Quest> Quests = new List<Quest>();
        public static readonly List<Location> Locations = new List<Location>();

        public const int I_ID_SWORD = 1;
        public const int I_ID_MACE = 2;
        public const int I_ID_RAT_BODY = 3;
        public const int I_ID_PIECE_OF_FUR = 4;
        public const int I_ID_SNAKE_BODY = 5;
        public const int I_ID_SNAKESKIN = 6;
        public const int I_ID_SPIDER_SILK = 7;
        public const int I_ID_SPIDER_BODY = 8;
        public const int I_ID_HEALTH_POTION = 9;
        public const int I_ID_ADVENTURER_PASS = 10;
        public const int I_ID_RAT_SUBJECTION_PROOF = 10;
        public const int I_ID_SNAKE_SUBJECTION_PROOF = 10;
        public const int I_ID_SPIDER_SUBJECTION_PROOF = 10;
        public const int I_ID_THIEF_SUBJECTION_PROOF = 10;
        public const int I_ID_BANDIT_SUBJECTION_PROOF = 10;

        public const int E_ID_RAT = 1;
        public const int E_ID_SNAKE = 2;
        public const int E_ID_GIANT_SPIDER = 3;
        public const int E_ID_THIFE = 4;
        public const int E_ID_BANDIT = 5;

        public const int Q_ID_CLEAR_ALCHEMIST_GARDEN = 1;
        public const int Q_ID_CLEAR_FARMERS_FIELD = 2;

        public const int L_ID_HOME = 1;
        public const int L_ID_TOWN_SQUARE = 2;
        public const int L_ID_GUARD_POST = 3;
        public const int L_ID_ALCHEMIST_HUT = 4;
        public const int L_ID_ALCHEMISTS_GARDEN = 5;
        public const int L_ID_FARMHOUSE = 6;
        public const int L_ID_FARM_FIELD = 7;
        public const int L_ID_BRIDGE = 8;
        public const int L_ID_SPIDER_NEST = 9;
        public const int L_ID_ADVENTURER_GUILD = 10;
        public const int L_ID_FOREST = 11;
        public const int L_ID_SLUMS = 12;
        public const int L_ID_MARKET = 13;
        public const int L_ID_BLACKSMITH = 14;
        public const int L_ID_GENERAL_STORE = 15;
        public const int L_ID_MAGE_STORE = 16;
        public const int L_ID_MAGE_TOWER = 17;
        public const int L_ID_TRAINING_FACILITY = 18;
        public const int L_ID_FOOD_STORE = 19;

        static AllStuff()
        {
            PopulateItems();
            PopulateEnemys();
            PopulateQuests();
            PopulateLocations();
        }

        private static void PopulateItems()
        {
            Items.Add(new Weapon(I_ID_SWORD, "Sword", "Swords", 1, 25));
            Items.Add(new Item(I_ID_RAT_BODY, "Rat tail", "Rat tails"));
            Items.Add(new Item(I_ID_PIECE_OF_FUR, "Piece of fur", "Pieces of fur"));
            Items.Add(new Item(I_ID_SNAKE_BODY, "Snake fang", "Snake fangs"));
            Items.Add(new Item(I_ID_SNAKESKIN, "Snakeskin", "Snakeskins"));
            Items.Add(new Weapon(I_ID_MACE, "Mace", "Mace", 5, 20));
            Items.Add(new HealthPotion(I_ID_HEALTH_POTION, "Health potion", "Healing potions", 5));
            Items.Add(new Item(I_ID_SPIDER_BODY, "Spider fang", "Spider fangs"));
            Items.Add(new Item(I_ID_SPIDER_SILK, "Spider silk", "Spider silks"));
            Items.Add(new Item(I_ID_ADVENTURER_PASS, "Adventurer pass", "Adventurer passes"));
            Items.Add(new Item(I_ID_RAT_SUBJECTION_PROOF, "Adventurer pass", "An proof that you have 'dealt' whit rat"));
            Items.Add(new Item(I_ID_SNAKE_SUBJECTION_PROOF, "Snake subjection proof", "An proof that you have 'dealt' whit snake"));
            Items.Add(new Item(I_ID_SPIDER_SUBJECTION_PROOF, "Spider subjection proof", "An proof that you have 'dealt' whit spider"));
            Items.Add(new Item(I_ID_THIEF_SUBJECTION_PROOF, "Thife subjection proof", "An proof that you have 'dealt' whit thife"));
            Items.Add(new Item(I_ID_BANDIT_SUBJECTION_PROOF, "Bandit subjection proof", "An proof that you have 'dealt' whit bandit"));
        }

        private static void PopulateEnemys()
        {
            Enemy rat = new Enemy(E_ID_RAT, "Rat", 7, 2, 10, 30, 30);
            rat.LootTable.Add(new LootI(ItemByID(I_ID_RAT_BODY), 100, true));
            rat.LootTable.Add(new LootI(ItemByID(I_ID_PIECE_OF_FUR), 50, false));
            rat.LootTable.Add(new LootI(ItemByID(I_ID_RAT_SUBJECTION_PROOF), 100, true));

            Enemy snake = new Enemy(E_ID_SNAKE, "Snake", 15, 5, 10, 50, 50);
            snake.LootTable.Add(new LootI(ItemByID(I_ID_SNAKE_BODY), 100, true));
            snake.LootTable.Add(new LootI(ItemByID(I_ID_SNAKESKIN), 50, false));
            snake.LootTable.Add(new LootI(ItemByID(I_ID_SNAKE_SUBJECTION_PROOF), 100, true));

            Enemy giantSpider = new Enemy(E_ID_GIANT_SPIDER, "Giant spider", 20, 10, 20, 100, 100);
            giantSpider.LootTable.Add(new LootI(ItemByID(I_ID_SPIDER_BODY), 100, true));
            giantSpider.LootTable.Add(new LootI(ItemByID(I_ID_SPIDER_SILK), 25, false));
            giantSpider.LootTable.Add(new LootI(ItemByID(I_ID_SPIDER_SUBJECTION_PROOF), 100, true));

            Enemy thife = new Enemy(E_ID_THIFE, "Thife", 40, 50, 100, 250, 250);
            thife.LootTable.Add(new LootI(ItemByID(I_ID_THIEF_SUBJECTION_PROOF), 100, true));

            Enemy bandit = new Enemy(E_ID_BANDIT, "Bandit", 50, 100, 100, 300, 3000);
            bandit.LootTable.Add(new LootI(ItemByID(I_ID_BANDIT_SUBJECTION_PROOF), 100, true));

            Enemys.Add(rat);
            Enemys.Add(snake);
            Enemys.Add(giantSpider);
        }

        private static void PopulateQuests()
        {
            Quest clearAlchemistGarden =
                new Quest(
                    Q_ID_CLEAR_ALCHEMIST_GARDEN,
                    "Clear the alchemist's garden",
                    "Kill rats in the alchemist's garden and bring back 5 rat tails.", 20, 50);

            clearAlchemistGarden.QCompletionI.Add(new QCompletionI(ItemByID(I_ID_RAT_SUBJECTION_PROOF), 5));

            clearAlchemistGarden.RewardItem = ItemByID(I_ID_HEALTH_POTION);

            Quest clearFarmersField =
                new Quest(
                    Q_ID_CLEAR_FARMERS_FIELD,
                    "Clear the farmer's field",
                    "Kill snakes in the farmer's field and bring back 5 snake fangs.", 20, 75);

            clearFarmersField.QCompletionI.Add(new QCompletionI(ItemByID(I_ID_SNAKE_SUBJECTION_PROOF), 5));

            clearFarmersField.RewardItem = ItemByID(I_ID_ADVENTURER_PASS);

            Quests.Add(clearAlchemistGarden);
            Quests.Add(clearFarmersField);
        }

        private static void PopulateLocations()
        {
            // Create each location
            Location home = new Location(L_ID_HOME, "Home", "Your house. You really shuld to clean up sometimes.");

            Location townSquare = new Location(L_ID_TOWN_SQUARE, "Town square", "You see a fountain and market.");

            Location alchemistHut = new Location(L_ID_ALCHEMIST_HUT, "Alchemist's hut", "There are many strange plants and metals on the shelves.");
            alchemistHut.QAvailableHere = QuestByID(Q_ID_CLEAR_ALCHEMIST_GARDEN);

            Location alchemistsGarden = new Location(L_ID_ALCHEMISTS_GARDEN, "Alchemist's garden", "Kind a creepy.");
            alchemistsGarden.EnemysExistence = EnemyByID(E_ID_RAT);

            Location farmhouse = new Location(L_ID_FARMHOUSE, "Farmhouse", "There is a farmhouse.");
            farmhouse.QAvailableHere = QuestByID(Q_ID_CLEAR_FARMERS_FIELD);

            Location farmersField = new Location(L_ID_FARM_FIELD, "Farmer's field", "Huge field.");
            farmersField.EnemysExistence = EnemyByID(E_ID_SNAKE);

            Location guardPost = new Location(L_ID_GUARD_POST, "Guard post", "There is a large, guard here.", ItemByID(I_ID_ADVENTURER_PASS));

            Location bridge = new Location(L_ID_BRIDGE, "Bridge", "A stone bridge crosses a wide river.");

            Location spiderField = new Location(L_ID_SPIDER_NEST, "Forest", "You see spider webs covering most of the trees in this forest.");
            spiderField.EnemysExistence = EnemyByID(E_ID_GIANT_SPIDER);

            // Link the locations together
            home.LocationToNorth = townSquare;

            townSquare.LocationToNorth = alchemistHut;
            townSquare.LocationToSouth = home;
            townSquare.LocationToEast = guardPost;
            townSquare.LocationToWest = farmhouse;

            farmhouse.LocationToEast = townSquare;
            farmhouse.LocationToWest = farmersField;

            farmersField.LocationToEast = farmhouse;

            alchemistHut.LocationToSouth = townSquare;
            alchemistHut.LocationToNorth = alchemistsGarden;

            alchemistsGarden.LocationToSouth = alchemistHut;

            guardPost.LocationToEast = bridge;
            guardPost.LocationToWest = townSquare;

            bridge.LocationToWest = guardPost;
            bridge.LocationToEast = spiderField;

            spiderField.LocationToWest = bridge;

            // Add the locations to the static list
            Locations.Add(home);
            Locations.Add(townSquare);
            Locations.Add(guardPost);
            Locations.Add(alchemistHut);
            Locations.Add(alchemistsGarden);
            Locations.Add(farmhouse);
            Locations.Add(farmersField);
            Locations.Add(bridge);
            Locations.Add(spiderField);
        }

        public static Item ItemByID(int id)
        {
            foreach (Item item in Items)
            {
                if (item.ID == id)
                {
                    return item;
                }
            }

            return null;
        }

        public static Enemy EnemyByID(int id)
        {
            foreach (Enemy monster in Enemys)
            {
                if (monster.ID == id)
                {
                    return monster;
                }
            }

            return null;
        }

        public static Quest QuestByID(int id)
        {
            foreach (Quest quest in Quests)
            {
                if (quest.ID == id)
                {
                    return quest;
                }
            }

            return null;
        }

        public static Location LocationByID(int id)
        {
            foreach (Location location in Locations)
            {
                if (location.ID == id)
                {
                    return location;
                }
            }

            return null;
        }
    }
}