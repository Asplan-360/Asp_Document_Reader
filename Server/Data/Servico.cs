using System;
using System.Collections.Generic;

namespace Asp_Document_Reader.Server.Data
{
    public partial class Servico
    {
        public int Codi { get; set; }
        public string? CodConsult { get; set; }
        public string? Nome { get; set; }
        public DateTime? Data { get; set; }
        public string? NumOs { get; set; }
        public string? Empresa { get; set; }
        public string? Responsavel { get; set; }
        public string? HoraI { get; set; }
        public string? HoraF { get; set; }
        public string? Obs { get; set; }
        public string? ChSelect { get; set; }
    }
}
