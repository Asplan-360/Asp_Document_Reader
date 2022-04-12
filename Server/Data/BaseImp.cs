using System;
using System.Collections.Generic;

namespace Asp_Document_Reader.Server.Data
{
    public partial class BaseImp
    {
        public int Codi { get; set; }
        public string? Mode { get; set; }
        public string? Titulo { get; set; }
        public string? SubTitulo { get; set; }
        public string? Nome { get; set; }
        public bool Check { get; set; }
    }
}
