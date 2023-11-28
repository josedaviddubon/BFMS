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
        public string ColaboradorID { get; set; }

        public string NombreColaborador { get; set; }
    }
}
