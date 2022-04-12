using System;
using System.Collections.Generic;

namespace Asp_Document_Reader.Server.Data
{
    public partial class IntraEnqueteLog
    {
        public int Id { get; set; }
        public int? IdEnquete { get; set; }
        public int? Idfuncionario { get; set; }
        public string? Votado { get; set; }
        public DateTime? Data { get; set; }
    }
}
