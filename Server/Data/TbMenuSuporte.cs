using System;
using System.Collections.Generic;

namespace Asp_Document_Reader.Server.Data
{
    public partial class TbMenuSuporte
    {
        public int Id { get; set; }
        public string? Titulo { get; set; }
        public string? Link { get; set; }
        public string? Ordem { get; set; }
        public string? Categoria { get; set; }
        public string? Conteudo { get; set; }
        public int? Sts { get; set; }
    }
}
