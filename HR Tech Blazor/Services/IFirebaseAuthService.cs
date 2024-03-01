namespace HR_Tech_Blazor.Services {
    public interface IFirebaseAuthService {
        Task<string?> SignUp(string email, string password);
        Task<string?> Login(string email, string password);
    }
}