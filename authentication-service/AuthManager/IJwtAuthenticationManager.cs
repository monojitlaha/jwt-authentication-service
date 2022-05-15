using authentication_service.Model;

namespace authentication_service.AuthManager
{
    public interface IJwtAuthenticationManager
    {
        Response Authenticate(string userName, string password);
    }
}
