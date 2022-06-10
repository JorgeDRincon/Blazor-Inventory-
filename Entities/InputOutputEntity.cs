using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class InputOutputEntity
    {
        [Key]
        public string InOutId { get; set; }

        [Required]
        public DateTime InOutDate { get; set; }

        [Required]
        public int Quantity { get; set; }

        public bool IsInput { get; set; }

        //Relacion con almacenamiento 
        public string StorageId { get; set; }
        public StorageEntity Storage { get; set; } //N a 1
        


    }
}
