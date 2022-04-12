using System;
using System.Collections.Generic;

namespace Asp_Document_Reader.Server.Data
{
    public partial class TbMensagem
    {
        public int Id { get; set; }
        public string? Mensagem { get; set; }
        public string? Recomendacao { get; set; }
        public string? Descricao { get; set; }
        public string? Ordem { get; set; }
    }
}
