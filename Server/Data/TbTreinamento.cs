using System;
using System.Collections.Generic;

namespace Asp_Document_Reader.Server.Data
{
    public partial class TbTreinamento
    {
        public int Id { get; set; }
        public string? Titulo { get; set; }
        public string? Pasta { get; set; }
        public string? Arquivo { get; set; }
        public string? Duracao { get; set; }
        public DateTime? Data { get; set; }
        public string? Busca { get; set; }
        public string? Destaque { get; set; }
        public bool? SysCtb { get; set; }
        public bool? SysFis { get; set; }
        public bool? SysFol { get; set; }
        public bool? SysFin { get; set; }
        public bool? SysNet { get; set; }
        public bool? SysXml { get; set; }
        public string? Acao { get; set; }
        public string? Status { get; set; }
        public string? Deletado { get; set; }
    }
}
