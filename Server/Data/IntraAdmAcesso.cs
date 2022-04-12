using System;
using System.Collections.Generic;

namespace Asp_Document_Reader.Server.Data
{
    public partial class IntraAdmAcesso
    {
        public int Id { get; set; }
        public int? IdUser { get; set; }
        public DateTime? Data { get; set; }
        public string? Ip { get; set; }
    }
}
