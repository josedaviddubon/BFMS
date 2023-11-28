using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Entities
{
    public class ViajeEntity
    {
        public int ViajeID { get; set; }

        public int TransportistaID { get; set; }

        public int ColaboradorID { get; set; }

        public System.DateTime FechaHoraSalida { get; set; }

        public decimal Distancia { get; set; }

        public decimal Costo { get; set; }

        ///Relacion con Transportista 
        
        public ICollection<TransportistaEntity> Transportista { get; set; }

        //Relacion con Colaborador

        public ICollection<ColaboradorEntity> Colaborador { get; set;}
        



    }
}
