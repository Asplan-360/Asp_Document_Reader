using System;
using System.Collections.Generic;

namespace Asp_Document_Reader.Server.Data
{
    public partial class IntraVaga
    {
        public int Id { get; set; }
        public string? Titulo { get; set; }
        public string? Status { get; set; }
        public string? Deletado { get; set; }
        public string? Descricao { get; set; }
    }
}
