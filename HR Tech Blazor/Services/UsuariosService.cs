using HR_Tech_Blazor.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Tech_Blazor.Services
{
    public class UsuariosService : IUsuariosService {
        private SQLiteAsyncConnection _dbConnection;

        public UsuariosService(){
            SetUpDb();
        }

        private async void SetUpDb() {
            if(_dbConnection == null) {
                string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Usuarios.db3");
                _dbConnection = new SQLiteAsyncConnection(dbPath);
                await _dbConnection.CreateTableAsync<Usuarios>();
            }
        }

        public async Task<int> AddUsuario(Usuarios usuario) {
            return await _dbConnection.InsertAsync(usuario);
        }

        public async Task<int> DeleteUsuario(Usuarios usuario) {
            return await _dbConnection.DeleteAsync(usuario);
        }

        public async Task<int> UpdateUsuario(Usuarios usuario) {
            return await _dbConnection.UpdateAsync(usuario);
        }

        public async Task<List<Usuarios>> GetAllUsuarios() {
            return await _dbConnection.Table<Usuarios>().ToListAsync();
        }
    }
}
