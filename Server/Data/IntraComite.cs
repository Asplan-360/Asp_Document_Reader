using System;
using System.Collections.Generic;

namespace Asp_Document_Reader.Server.Data
{
    public partial class IntraComite
    {
        public int Id { get; set; }
        public int? IdUser { get; set; }
        public string? Comite { get; set; }
        public string? Nome { get; set; }
        public string? Cargo { get; set; }
        public string? Descricao { get; set; }
        public string? Foto { get; set; }
        public int? Ordem { get; set; }
        public string? Empresa { get; set; }
        public string? Status { get; set; }
        public string? Deletado { get; set; }
    }
}
