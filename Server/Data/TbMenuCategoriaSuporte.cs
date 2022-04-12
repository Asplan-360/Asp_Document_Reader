using System;
using System.Collections.Generic;

namespace Asp_Document_Reader.Server.Data
{
    public partial class TbMenuCategoriaSuporte
    {
        public int Id { get; set; }
        public string? Titulo { get; set; }
        public string? Link { get; set; }
        public int? Ordem { get; set; }
    }
}
