using HR_Tech_Blazor.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Tech_Blazor.Services
{
    public class EmpleadoService : IEmpleadoService {
        private SQLiteAsyncConnection _dbConnection;

        public EmpleadoService()
        {
            SetUpDb();
        }

        private async void SetUpDb() {
            if (_dbConnection == null) {
                string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Empleados.db3");
                _dbConnection = new SQLiteAsyncConnection(dbPath);
                await _dbConnection.CreateTableAsync<Empleados>();
            }
        }

        public async Task<int> AddEmpleado(Empleados empleado) {
            return await _dbConnection.InsertAsync(empleado);
        }

        public async Task<int> DeleteEmpleado(Empleados empleado) {
            return await _dbConnection.DeleteAsync(empleado);
        }

        public async Task<List<Empleados>> GetAllEmpleados() {
            return await _dbConnection.Table<Empleados>().ToListAsync();
        }

        public async Task<Empleados> GetEmpleadoById(int IdEmpleado) {
            var empleado = await _dbConnection.QueryAsync<Empleados>($"SELECT * FROM {nameof(Empleados)} WHERE IdEmpleado = {IdEmpleado} ");
            return empleado.FirstOrDefault();
        }

        public async Task<int> UpdateEmpleado(Empleados empleado) {
            return await _dbConnection.UpdateAsync(empleado);
        }
    }
}
