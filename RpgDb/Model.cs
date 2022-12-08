using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgDb
{
    public class Model
    {
        public class RpgContext : DbContext
        {
            public DbSet<Item> Items { get; set; }
            public DbSet<QuestItem> Quests { get; set; }
            public DbSet<WeaponItem> Weapons { get; set; }
            public DbSet<PotionItem> Potions { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
                    => optionsBuilder.UseSqlServer($"Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=RpgItemDatabase");

        }


        public class Item
        {
            public int Id { get; set; }
            public string Category { get; set; }
            public string Tag { get; set; }
        }

        public class PotionItem
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Type { get; set; }
            public string Effect { get; set; }

            public int ItemId { get; set; }
        }

        public class WeaponItem
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Damage { get; set; }

            public int ItemId { get; set; }
        }

        public class QuestItem
        {
            public int Id { get; set; }
            public string Type { get; set; }
            public string QuestGoal { get; set; }
            public string Reward { get; set; }

            public int ItemId { get; set; }
        }
    }
}
