using System;
using System.Collections.Generic;

namespace Asp_Document_Reader.Server.Data
{
    public partial class IntraAdmLogalt
    {
        public int Id { get; set; }
        public int? IdUser { get; set; }
        public string? Acao { get; set; }
        public DateTime? Data { get; set; }
    }
}
