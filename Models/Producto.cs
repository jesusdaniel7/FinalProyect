using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProyect.Models
{
    public class Producto
    {
        public int productoID { get; set; }
        //public int caregoriaID { get; set; }
        public string nombre { get; set; }
        public int precio { get; set; }
        public string foto { get; set; }
        public int cantidad { get; set; }
        public int detalle { get; set; }
    }
}