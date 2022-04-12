using System;
using System.Collections.Generic;

namespace Asp_Document_Reader.Server.Data
{
    public partial class IntraFoto
    {
        public int Id { get; set; }
        public int? IdConteudo { get; set; }
        public string? Foto { get; set; }
        public string? Tipo { get; set; }
        public string? Link { get; set; }
        public string? Legenda { get; set; }
    }
}
