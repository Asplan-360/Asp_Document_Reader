using System;
using System.Collections.Generic;

namespace Asp_Document_Reader.Server.Data
{
    public partial class IntraLink
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public string? Categoria { get; set; }
        public string? Link { get; set; }
        public string? Foto { get; set; }
        public int? Usuario { get; set; }
        public string? Status { get; set; }
        public string? Deletado { get; set; }
    }
}
