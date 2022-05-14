namespace authentication_service.AuthManager
{
    public interface IJwtAuthenticationManager
    {
        string Authenticate(string userName, string password);
    }
}
