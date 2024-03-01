using HR_Tech_Blazor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Tech_Blazor.Services
{
    public interface IEmpleadoService{
        Task<List<Empleados>> GetAllEmpleados();
        Task<Empleados> GetEmpleadoById(int IdEmpleado);
        Task<int> AddEmpleado(Empleados empleado);
        Task<int> UpdateEmpleado(Empleados empleado);
        Task<int> DeleteEmpleado(Empleados empleado);
    }
}
