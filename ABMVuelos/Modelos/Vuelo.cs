using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ABMVuelos.Modelos
{
    public class Vuelo
    {
        public int ID { get; set; }
        
        [DataType(DataType.Time)]
        public DateTime llegada { get; set; }

        
        public string Linea { get; set; }

        
        public string Codigo { get; set; }
        
        public Boolean Demorado { get; set; }
    }
}
