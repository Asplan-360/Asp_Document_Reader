using Newtonsoft.Json;
using System.Net;

namespace Asp_Document_Reader.Server.Services
{
    public class LoginService : ILoginService
    {
        public LoginService()
        {

        }
        public UserResponse Login(UserInfo user)
        {
            string url = "https://360awssrvapp01.asplan.com.br/login360/v1";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);

            String encoded = System.Convert.ToBase64String(System.Text.Encoding.GetEncoding("utf-8").GetBytes(user.Email + ":" + user.Password));
            request.Headers.Add("Authorization", "Basic " + encoded);
            request.ContentType = "application/json; charset=utf-8";

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            Stream resStream = response.GetResponseStream();

            string requestBody = new StreamReader(resStream).ReadLine();

            // Verifica se o content length é maior que 0, se sim é permitido o login
            if (response.ContentLength == 0)
            {
                return null;
            }

            UserResponse userResponse = JsonConvert.DeserializeObject<UserResponse>(requestBody);

            return userResponse;
        }
    }
}
