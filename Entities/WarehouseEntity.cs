using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class WarehouseEntity
    {
        [Key]
        [MaxLength(50)]
        public string WarehouseId{ get; set; }

        [Required]
        [MaxLength(50)]
        public string WarehouseName{ get; set; }

        [Required]
        public string WarehouseAddress { get; set; }

        //Relacion con Almacenamiento
        public ICollection<StorageEntity> Storages { get; set; } // 1 a N




    }
}
