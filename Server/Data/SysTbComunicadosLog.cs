using System;
using System.Collections.Generic;

namespace Asp_Document_Reader.Server.Data
{
    public partial class SysTbComunicadosLog
    {
        public int IdUser { get; set; }
        public int? IdEmail { get; set; }
        public string? Data { get; set; }
        public int? Mes { get; set; }
    }
}
