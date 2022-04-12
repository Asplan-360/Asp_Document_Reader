using System;
using System.Collections.Generic;

namespace Asp_Document_Reader.Server.Data
{
    public partial class TbCurso
    {
        public int Id { get; set; }
        public string? Modulo { get; set; }
        public string? Nivel { get; set; }
        public string? Conteudo { get; set; }
        public decimal? Valor { get; set; }
        public int? Gratuito { get; set; }
        public int? Sts { get; set; }
    }
}
