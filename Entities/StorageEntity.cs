using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class StorageEntity
    {
        [Key]
        [MaxLength(50)]
        public string StorageId { get; set; }

        [Required]
        public DateTime LastUpdate { get; set; }

        [Required]
        public int ParcialQuantity { get; set; }

        //Relacion con Productos
        public string ProductId { get; set; }
        public ProductEntity Product { get; set; }
        
        //Relacion con Bodegas
        public string WarehouseId { get; set; }
        public WarehouseEntity Warehouse { get; set; }

        //Relacion con Movimientos (Entradas y salidas) 
        public ICollection<InputOutputEntity> InputOutputs { get; set; } // 1 a N





    }
}
