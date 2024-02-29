using HR_Tech_Blazor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Tech_Blazor.Services
{
    public interface IUsuariosService {
        Task<List<Usuarios>> GetAllUsuarios();
        Task<int> AddUsuario(Usuarios usuario);
        Task<int> UpdateUsuario(Usuarios usuario);
        Task<int> DeleteUsuario(Usuarios usuario);
    }
}
