using System;
using System.Collections.Generic;

namespace Asp_Document_Reader.Server.Data
{
    public partial class ViewGerMenu
    {
        public int GerMenuId { get; set; }
        public string DescMenu { get; set; } = null!;
        public bool? Acesspadm { get; set; }
        public int? OrdemMenu { get; set; }
        public string? DescRotina { get; set; }
        public string? Icone { get; set; }
        public int GerRotinaId { get; set; }
        public string? Titulo { get; set; }
        public string? Janela { get; set; }
        public string? Descricao { get; set; }
        public string? Rota { get; set; }
        public string? Paramauxiliar { get; set; }
        public int? OrdemRotina { get; set; }
    }
}
