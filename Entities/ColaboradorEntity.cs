using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ColaboradorEntity
    {
        [Key]
        [StringLength(50)]
        public string ColaboradorID { get; set; }

        [Required]
        [StringLength(50)]

        public string NombreColaborador { get; set; }


        public ICollection<SucursalDetalleEntity> SucursalDetalle { get;set; }


    }
}
