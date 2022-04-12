using System;
using System.Collections.Generic;

namespace Asp_Document_Reader.Server.Data
{
    public partial class GerRotina
    {
        public int GerRotinaId { get; set; }
        public int GerMenuId { get; set; }
        public string? Titulo { get; set; }
        public string? Janela { get; set; }
        public string? Descricao { get; set; }
        public string? Rota { get; set; }
        public string? Icone { get; set; }
        public string? Paramauxiliar { get; set; }
        public int? Ordem { get; set; }
        public bool? Inativo { get; set; }
    }
}
