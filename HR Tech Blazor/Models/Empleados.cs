using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Tech_Blazor.Models
{
    public class Empleados{
        [PrimaryKey, AutoIncrement]
        public int IdEmpleado { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? Puesto { get; set; }
        public string? Departamento { get; set; }
        public int DiasDeVacaciones { get; set; }
        public string? Usuario { get; set; }
        public string? Contraseña { get; set; }
    }
}
