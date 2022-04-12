using System;
using System.Collections.Generic;

namespace Asp_Document_Reader.Server.Data
{
    public partial class IntraAfago
    {
        public int Id { get; set; }
        public DateTime? Data { get; set; }
        public string? Titulo { get; set; }
        public string? Texto { get; set; }
        public string? Status { get; set; }
        public string? Deletado { get; set; }
        public int? IdUser { get; set; }
        public string? Remetente { get; set; }
        public int? Usuario { get; set; }
    }
}
