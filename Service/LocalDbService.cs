using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using ShopMate.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopMate.Service
{
    public class LocalDbService : DbContext
    {
        //private const string DB_NAME = "shoplist_local_db.db3";
        //public readonly SQLiteAsyncConnection connection;
        //public LocalDbService()
        //{
        //    connection = new SQLiteAsyncConnection(Path.Combine(FileSystem.AppDataDirectory, DB_NAME));
        //    InitializeDatabaseAsync();
        //}

        //private async void InitializeDatabaseAsync()
        //{
        //    await connection.CreateTableAsync<Recipe>();
        //    await connection.CreateTableAsync<ShopCart>();
        //    await connection.CreateTableAsync<Item>(); // Add this line to create the Item table
        //}
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<ShopCart> ShopCarts { get; set; }
        public DbSet<Item> Items { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var databasePath = $"Filename={DbPath.GetPath("shopmate_local_db.db")}";
            //var connectionStringBuilder = new SqliteConnectionStringBuilder { DataSource = databasePath };
            //var connectionString = connectionStringBuilder.ToString();
            //var connection = new SqliteConnection(connectionString);

            optionsBuilder.UseSqlite(databasePath);
        }
    }
}
