using System;
using System.Collections.Generic;

namespace Asp_Document_Reader.Server.Data
{
    public partial class SysTbEmailComunicado
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public int? Enviado { get; set; }
        public int? Status { get; set; }
        public int? Deletado { get; set; }
    }
}
