using System;
using System.Collections.Generic;

namespace Asp_Document_Reader.Server.Data
{
    public partial class SysTbComunicado
    {
        public int Id { get; set; }
        public string? Titulo { get; set; }
        public string? Conteudo { get; set; }
        public string? Status { get; set; }
        public string? Deletado { get; set; }
        public DateTime? Data { get; set; }
        public string? Enviado { get; set; }
        public int? VisitasSite { get; set; }
        public string? Foto { get; set; }
        public string? Veiculo { get; set; }
    }
}
