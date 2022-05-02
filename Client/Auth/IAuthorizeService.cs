namespace Asp_Document_Reader.Client.Auth;

public interface IAuthorizeService
{
    Task Login(string email);
    Task Logout();
}
