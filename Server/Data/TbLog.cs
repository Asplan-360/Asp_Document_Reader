using System;
using System.Collections.Generic;

namespace Asp_Document_Reader.Server.Data
{
    public partial class TbLog
    {
        public int Id { get; set; }
        public int? IdUsuario { get; set; }
        public int? IdEmpresa { get; set; }
        public DateTime? Data { get; set; }
        public string? Act { get; set; }
    }
}
