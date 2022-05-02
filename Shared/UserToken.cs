using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Asp_Document_Reader.Shared
{
    public class UserToken
    {
        public string Token { get; set; } = string.Empty;
        public DateTime Expiration { get; set; }
        public string Message { get; set; } = string.Empty;




    }

    public class Login
    {
        public string usuarioCatalogoID { get; set; }
        [JsonIgnore]
        public string cnpj { get; set; }
        public string razaoSocial { get; set; }
        public string email { get; set; }
        [JsonIgnore]
        public string senha { get; set; }
        public string nomeUsuario { get; set; }
        public string merchantId { get; set; }
        public string merchantKey { get; set; }
        public string guidRelatorio { get; set; }
    }

    public class UserResponse
    {
        public Login login { get; set; }
    }
}
