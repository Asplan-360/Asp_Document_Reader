using System;
using System.Collections.Generic;

namespace Asp_Document_Reader.Server.Data
{
    public partial class IntraResciso
    {
        public int Id { get; set; }
        public int? Codigo { get; set; }
        public string? Empresa { get; set; }
        public DateTime? Data { get; set; }
        public string? Foto { get; set; }
        public string? Status { get; set; }
        public string? Deletado { get; set; }
        public int? Usuario { get; set; }
    }
}
