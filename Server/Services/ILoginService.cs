namespace Asp_Document_Reader.Server.Services
{
    public interface ILoginService
    {
        public UserResponse Login(UserInfo user);
    }
}
