using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Tech_Blazor.Models {
    public   class Solicitud {
        public int IdSolicitud { get; set; }
        public string Motivo { get; set; }
        public string Nombre { get; set; }
        public int DiasSolicitados { get; set; }
        public bool Status { get; set; }
    }
}
