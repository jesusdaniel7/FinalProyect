using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProyect.Models
{
    public class Direccion
    {
        public int direccionID { get; set; }         
        public string nombre { get; set; }         
        public string pais { get; set; }
        public string ciudad { get; set; }
        public string provincia { get; set; }
        public string codigoPostal { get; set; }
        public string numTelefono { get; set; }
    }
}
