using System;
using System.Collections.Generic;

namespace Asp_Document_Reader.Server.Data
{
    public partial class IntraExterno
    {
        public int Id { get; set; }
        public int? IdFunc { get; set; }
        public string? Cliente { get; set; }
        public DateTime? Data { get; set; }
        public string? HEntrada { get; set; }
        public string? HSaida { get; set; }
        public string? HAlmoco { get; set; }
        public string? HRetorno { get; set; }
        public string? Atividades { get; set; }
        public string? Pendencias { get; set; }
        public string? Comentarios { get; set; }
        public int? Sessao { get; set; }
        public int? Finalizado { get; set; }
        public DateTime? HLog { get; set; }
    }
}
