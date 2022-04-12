using System;
using System.Collections.Generic;

namespace Asp_Document_Reader.Server.Data
{
    public partial class IntraBeneficio
    {
        public int Id { get; set; }
        public string? Foto { get; set; }
        public string? Titulo { get; set; }
        public string? Texto { get; set; }
        public string? Site { get; set; }
        public string? Categoria { get; set; }
        public int? Usuario { get; set; }
        public string? Status { get; set; }
        public string? Deletado { get; set; }
        public DateTime? Data { get; set; }
    }
}
