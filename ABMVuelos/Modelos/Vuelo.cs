using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ABMVuelos.Modelos
{
    public class Vuelo
    {
        public int ID { get; set; }

        [Required]
        [DisplayName("Horario")]
        [DataType(DataType.Time)]
        public DateTime llegada { get; set; }

        [Required]
        [DisplayName("Línea aérea")]
        [StringLength(10,MinimumLength = 3)]
        public string Linea { get; set; }
        
        [Required]
        [DisplayName("Código de vuelo")]
        [StringLength(6,MinimumLength = 6)]
        public string Codigo { get; set; }

        [Required]
        public Boolean Demorado { get; set; }
    }
}
