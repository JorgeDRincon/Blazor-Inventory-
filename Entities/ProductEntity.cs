using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ProductEntity
    {
        [Key]
        [MaxLength(50)]
        public string ProductId { get; set; }

        [Required]
        [MaxLength(20)]
        public string ProductName { get; set; }

        [MaxLength(600)]
        public string ProductDescription { get; set; }

        [Required]
        [MaxLength(50)]
        public int TotalQuantity { get; set; }
        
        //Relacion con Categorias
        public string CategoryId { get; set; }
        public CategoryEntity Category { get; set; }

        //Relacion con Almacenamiento
        public ICollection<StorageEntity> Storages { get;  set; } // 1 a N

    }
}
