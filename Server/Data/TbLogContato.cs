using System;
using System.Collections.Generic;

namespace Asp_Document_Reader.Server.Data
{
    public partial class TbLogContato
    {
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public string? Empresa { get; set; }
        public string? Anuncio { get; set; }
        public DateTime? Data { get; set; }
        public string? Mensagem { get; set; }
        public string? Origem { get; set; }
        public bool? EmailMkt { get; set; }
    }
}
