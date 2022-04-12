using System;
using System.Collections.Generic;

namespace Asp_Document_Reader.Server.Data
{
    public partial class IntraJornal
    {
        public int Id { get; set; }
        public string? Mes { get; set; }
        public string? Foto { get; set; }
        public DateTime? Data { get; set; }
        public string? Status { get; set; }
        public string? Deletado { get; set; }
        public string? Pag1 { get; set; }
        public string? Pag2 { get; set; }
        public string? Pag3 { get; set; }
        public string? Pag4 { get; set; }
        public string? Download { get; set; }
        public string? Topicos { get; set; }
        public int? Usuario { get; set; }
        public string? Pag5 { get; set; }
    }
}
