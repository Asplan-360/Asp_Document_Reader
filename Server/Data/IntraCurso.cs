using System;
using System.Collections.Generic;

namespace Asp_Document_Reader.Server.Data
{
    public partial class IntraCurso
    {
        public int Id { get; set; }
        public int? Participante { get; set; }
        public string? Curso { get; set; }
        public DateTime? DataI { get; set; }
        public DateTime? DataF { get; set; }
        public string? Situacao { get; set; }
        public int? Carga { get; set; }
        public double? Pontos { get; set; }
        public string? Certificado { get; set; }
        public string? Avaliacao { get; set; }
        public string? Status { get; set; }
    }
}
