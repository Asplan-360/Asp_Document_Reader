using System;
using System.Collections.Generic;

namespace Asp_Document_Reader.Server.Data
{
    public partial class IntraEmpresaExterno
    {
        public int Id { get; set; }
        public int? Cod { get; set; }
        public string? Empresa { get; set; }
        public string? HEntradaDif { get; set; }
        public string? HoraDif { get; set; }
        public string? Status { get; set; }
        public string? Deletado { get; set; }
    }
}
