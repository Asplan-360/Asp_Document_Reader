using System;
using System.Collections.Generic;

namespace Asp_Document_Reader.Server.Data
{
    public partial class TbConsultoriaUser
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Login { get; set; }
        public string? Email { get; set; }
        public string? Senha { get; set; }
        public int? Adm { get; set; }
        public string? Acesso { get; set; }
        public string? Status { get; set; }
        public string? Deletado { get; set; }
    }
}
