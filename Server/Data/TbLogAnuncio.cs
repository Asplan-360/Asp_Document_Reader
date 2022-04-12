using System;
using System.Collections.Generic;

namespace Asp_Document_Reader.Server.Data
{
    public partial class TbLogAnuncio
    {
        public string? Anuncio { get; set; }
        public string? Ip { get; set; }
        public DateTime? Data { get; set; }
        public string? Origem { get; set; }
    }
}
