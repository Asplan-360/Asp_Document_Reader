using System;
using System.Collections.Generic;

namespace Asp_Document_Reader.Server.Data
{
    public partial class IntraFrase
    {
        public int Id { get; set; }
        public string? Frase { get; set; }
        public string? Autor { get; set; }
        public string? Status { get; set; }
        public string? Deletado { get; set; }
    }
}
