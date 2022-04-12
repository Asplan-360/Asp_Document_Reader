using System;
using System.Collections.Generic;

namespace Asp_Document_Reader.Server.Data
{
    public partial class IntraConvenio
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Texto { get; set; }
        public string? Foto { get; set; }
        public string? Endereco { get; set; }
        public string? Telefone { get; set; }
        public string? Status { get; set; }
        public string? Deletado { get; set; }
        public string? Resumo { get; set; }
        public DateTime? Data { get; set; }
    }
}
