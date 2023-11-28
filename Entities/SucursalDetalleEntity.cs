using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class SucursalDetalleEntity
    {
        public int SucursalDetalleID { get; set; }

        public Nullable<decimal> DistanciaporViaje { get; set; }


        //Relacion con Sucursales 

        public int SucursalID { get; set; }

        public SucursalEntity Sucursal { get; set; }

        //Relacion con Colaborador
        public int ColaboradorID { get; set; }

        public ColaboradorEntity Colaborador { get; set; } 



    }
}
