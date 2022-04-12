using System;
using System.Collections.Generic;

namespace Asp_Document_Reader.Server.Data
{
    public partial class IntraCiclo
    {
        public int Id { get; set; }
        public string? Titulo { get; set; }
        public string? Titulo2 { get; set; }
        public DateTime? Data { get; set; }
        public string? Texto { get; set; }
        public string? Palestrante { get; set; }
        public string? Horario { get; set; }
        public string? Observacao { get; set; }
        public string? Local { get; set; }
        public string? Status { get; set; }
        public string? Deletado { get; set; }
    }
}
