using System;
using System.Collections.Generic;

namespace Asp_Document_Reader.Server.Data
{
    public partial class TbPlanewsFoto
    {
        public int Id { get; set; }
        public int? IdPlanews { get; set; }
        public string? Foto { get; set; }
    }
}
