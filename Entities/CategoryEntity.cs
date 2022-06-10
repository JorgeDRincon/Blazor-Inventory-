using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class CategoryEntity
    {
        [Key]
        [MaxLength(50)]
        public string CategoryId { get; set; }

        [Required]
        [MaxLength(15)]
        public string CategoryName { get; set; }

        //Relacion con Productos
        public ICollection<ProductEntity> Products { get; set; } // 1 a N

    }
}
