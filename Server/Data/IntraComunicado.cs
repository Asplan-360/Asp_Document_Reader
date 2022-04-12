using System;
using System.Collections.Generic;

namespace Asp_Document_Reader.Server.Data
{
    public partial class IntraComunicado
    {
        public int Id { get; set; }
        public string? Titulo { get; set; }
        public string? Texto { get; set; }
        public string? Foto { get; set; }
        public DateTime? Data { get; set; }
        public string? Fonte { get; set; }
        public int? Visitas { get; set; }
        public int? Usuario { get; set; }
        public string? Status { get; set; }
        public string? Deletado { get; set; }
    }
}
