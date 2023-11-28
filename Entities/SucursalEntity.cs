using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class SucursalEntity
    {
        [Key]
        [StringLength(10)]
        public string SucursalID { get; set; }

        [Required] 
        [StringLength(100)]
        public string SucursalNombre { get; set; }

        [StringLength(600)]
        public string SucursalDireccion { get; set; }


        public ICollection<SucursalDetalleEntity> SucursalDetalle { get; set; }


    }
}
