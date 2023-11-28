using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class TransportistaEntity
    {
        [Key]
        [StringLength(50)]
        public string TransportistaID { get; set; }

        [Required]
        [StringLength(50)]

        public string NombreTransportista { get; set; }

        [Required]
        public decimal TarifaxKilometro { get; set; }

        public int ViajeID { get; set; }

        public ViajeEntity Viaje { get; set; }  
    }
}
