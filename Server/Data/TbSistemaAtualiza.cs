using System;
using System.Collections.Generic;

namespace Asp_Document_Reader.Server.Data
{
    public partial class TbSistemaAtualiza
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public DateTime? Data { get; set; }
        public string? Sistema { get; set; }
        public string? NomeSis { get; set; }
        public string? Versao { get; set; }
        public string? Email { get; set; }
        public string? Arquivo { get; set; }
        public string? Procedimento { get; set; }
        public string? Carta { get; set; }
        public string? Conteudo { get; set; }
    }
}
