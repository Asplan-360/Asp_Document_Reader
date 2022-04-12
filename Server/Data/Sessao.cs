using System;
using System.Collections.Generic;

namespace Asp_Document_Reader.Server.Data
{
    public partial class Sessao
    {
        public string? IdSessao { get; set; }
        public string? HoraInicial { get; set; }
        public string? HoraFinal { get; set; }
        public string? Ip { get; set; }
    }
}
