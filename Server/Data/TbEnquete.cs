using System;
using System.Collections.Generic;

namespace Asp_Document_Reader.Server.Data
{
    public partial class TbEnquete
    {
        public int Id { get; set; }
        public string? Pergunta { get; set; }
        public string? Status { get; set; }
        public string? Deletado { get; set; }
        public string? Resposta1 { get; set; }
        public string? Resposta2 { get; set; }
        public string? Resposta3 { get; set; }
        public string? Resposta4 { get; set; }
        public int? Votos1 { get; set; }
        public int? Votos2 { get; set; }
        public int? Votos3 { get; set; }
        public int? Votos4 { get; set; }
        public DateTime? Data { get; set; }
    }
}
