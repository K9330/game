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

        public const int I_ID_RUSTED_SWORD = 1;
        public const int I_ID_WOODEN_CLUB = 2;
        public const int I_ID_RAT_TAIL = 3;
        public const int I_ID_PIECE_OF_FUR = 4;
        public const int I_ID_SNAKE_FANG = 5;
        public const int I_ID_SNAKESKIN = 6;
        public const int I_ID_SPIDER_SILK = 7;
        public const int I_ID_SPIDER_FANG = 8;
        public const int I_ID_HEALTH_POTION = 9;
        public const int I_ID_ADVENTURER_PASS = 10;

        public const int E_ID_RAT = 1;
        public const int E_ID_SNAKE = 2;
        public const int E_ID_GIANT_SPIDER = 3;

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

        static AllStuff()
        {
            PopulateItems();
            PopulateEnemys();
            PopulateQuests();
            PopulateLocations();
        }

        private static void PopulateItems()
        {
            Items.Add(new Weapon(I_ID_RUSTED_SWORD, "Rusted sword", "Rusty swords", 1, 5));
            Items.Add(new Item(I_ID_RAT_TAIL, "Rat tail", "Rat tails"));
            Items.Add(new Item(I_ID_PIECE_OF_FUR, "Piece of fur", "Pieces of fur"));
            Items.Add(new Item(I_ID_SNAKE_FANG, "Snake fang", "Snake fangs"));
            Items.Add(new Item(I_ID_SNAKESKIN, "Snakeskin", "Snakeskins"));
            Items.Add(new Weapon(I_ID_WOODEN_CLUB, "Wuuden club", "Wooden clubs", 3, 10));
            Items.Add(new HealthPotion(I_ID_HEALTH_POTION, "Health potion", "Healing potions", 5));
            Items.Add(new Item(I_ID_SPIDER_FANG, "Spider fang", "Spider fangs"));
            Items.Add(new Item(I_ID_SPIDER_SILK, "Spider silk", "Spider silks"));
            Items.Add(new Item(I_ID_ADVENTURER_PASS, "Adventurer pass", "Adventurer passes"));
        }

        private static void PopulateEnemys()
        {
            Enemy rat = new Enemy(E_ID_RAT, "Rat", 5, 3, 10, 3, 3);
            rat.LootTable.Add(new LootI(ItemByID(I_ID_RAT_TAIL), 75, false));
            rat.LootTable.Add(new LootI(ItemByID(I_ID_PIECE_OF_FUR), 75, true));

            Enemy snake = new Enemy(E_ID_SNAKE, "Snake", 5, 3, 10, 3, 3);
            snake.LootTable.Add(new LootI(ItemByID(I_ID_SNAKE_FANG), 75, false));
            snake.LootTable.Add(new LootI(ItemByID(I_ID_SNAKESKIN), 75, true));

            Enemy giantSpider = new Enemy(E_ID_GIANT_SPIDER, "Giant spider", 20, 5, 20, 10, 10);
            giantSpider.LootTable.Add(new LootI(ItemByID(I_ID_SPIDER_FANG), 75, true));
            giantSpider.LootTable.Add(new LootI(ItemByID(I_ID_SPIDER_SILK), 25, false));

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
                    "Kill rats in the alchemist's garden and bring back 3 rat tails.", 20, 10);

            clearAlchemistGarden.QCompletionI.Add(new QCompletionI(ItemByID(I_ID_RAT_TAIL), 3));

            clearAlchemistGarden.RewardItem = ItemByID(I_ID_HEALTH_POTION);

            Quest clearFarmersField =
                new Quest(
                    Q_ID_CLEAR_FARMERS_FIELD,
                    "Clear the farmer's field",
                    "Kill snakes in the farmer's field and bring back 3 snake fangs.", 20, 20);

            clearFarmersField.QCompletionI.Add(new QCompletionI(ItemByID(I_ID_SNAKE_FANG), 3));

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