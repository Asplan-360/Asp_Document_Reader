using System;
using System.Collections.Generic;

namespace Asp_Document_Reader.Server.Data
{
    public partial class TbDocumentacaoSub
    {
        public int Id { get; set; }
        public string? IdCategoria { get; set; }
        public string? Descricao { get; set; }
        public string? Arquivo { get; set; }
        public string? Ordem { get; set; }
    }
}
