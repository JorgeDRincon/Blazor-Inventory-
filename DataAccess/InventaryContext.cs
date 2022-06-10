using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DataAccess
{
    public class InventaryContext:DbContext {

        public DbSet<ProductEntity> Products { get; set; }
        public DbSet<CategoryEntity> Categories { get; set; }
        public DbSet<InputOutputEntity> InOuts { get; set; }
        public DbSet<StorageEntity> Storages { get; set; }
        public DbSet<WarehouseEntity> WareHouses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                options.UseSqlServer("Server=JORGE-LAPTOP; Database=InventoryPlatzi; integrated security=true"); //Elimine el User y el password
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder){
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<CategoryEntity>().HasData(
                new CategoryEntity { CategoryId="ASH",CategoryName="Aseo del Hogar"},
                new CategoryEntity { CategoryId="ASP", CategoryName="Aseo Personal"},
                new CategoryEntity { CategoryId="HGR", CategoryName="Hogar"},
                new CategoryEntity { CategoryId= "PRF", CategoryName="Perfumeria"},
                new CategoryEntity { CategoryId="SLD", CategoryName="Salud"},
                new CategoryEntity { CategoryId="VDJ", CategoryName="Video Juegos"}
            );

            modelBuilder.Entity<WarehouseEntity>().HasData(
                new WarehouseEntity { WarehouseId=Guid.NewGuid().ToString(),WarehouseName="Bodega Central", 
                    WarehouseAddress= "109 Osigian Blvd #300"
                }, 
                new WarehouseEntity { WarehouseId=Guid.NewGuid().ToString(), WarehouseName="Bodega New Mexico",
                    WarehouseAddress= "191 South Ave"
                }
                
            );
        }





    }
}
