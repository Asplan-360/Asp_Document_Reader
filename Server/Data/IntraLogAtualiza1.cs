using System;
using System.Collections.Generic;

namespace Asp_Document_Reader.Server.Data
{
    public partial class IntraLogAtualiza1
    {
        public int Id { get; set; }
        public string? Origem { get; set; }
        public int? IdOrigem { get; set; }
        public int? IdUsuario { get; set; }
        public DateTime? Data { get; set; }
        public string? Type { get; set; }
    }
}
