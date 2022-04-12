using System;
using System.Collections.Generic;

namespace Asp_Document_Reader.Server.Data
{
    public partial class IntraVideo
    {
        public int Id { get; set; }
        public string? Titulo { get; set; }
        public string? Texto { get; set; }
        public DateTime? Data { get; set; }
        public string? Duracao { get; set; }
        public string? Video { get; set; }
        public string? Foto { get; set; }
    }
}
