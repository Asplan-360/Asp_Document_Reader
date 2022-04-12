using System;
using System.Collections.Generic;

namespace Asp_Document_Reader.Server.Data
{
    public partial class GerMenu
    {
        public int GerMenuId { get; set; }
        public string Descricao { get; set; } = null!;
        public int? Ordem { get; set; }
        public bool? Inativo { get; set; }
        public bool? Acesspadm { get; set; }
    }
}
