using System;
using System.Collections.Generic;

namespace Asp_Document_Reader.Server.Data
{
    public partial class IntraMensagen
    {
        public int Id { get; set; }
        public string? Titulo { get; set; }
        public string? Texto { get; set; }
        public string? Destinatario { get; set; }
        public string? Rementente { get; set; }
        public DateTime? Data { get; set; }
    }
}
