using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProyect.Models
{
    public class Estado
    {
        public int estadoID { get; set; }
        public string proceso { get; set; }
        public string enviado { get; set; }
        public string completado { get; set; }
    }
}   