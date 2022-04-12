using System;
using System.Collections.Generic;

namespace Asp_Document_Reader.Server.Data
{
    public partial class SysTbComunicadosBodyMail
    {
        public int Id { get; set; }
        public string? Corpo { get; set; }
        public string? Situacao { get; set; }
        public string? Data { get; set; }
        public string? Enviado { get; set; }
        public string? Titulo { get; set; }
        public string? Status { get; set; }
        public string? Deletado { get; set; }
        public int? TotalEmail { get; set; }
        public int? Mes { get; set; }
    }
}
