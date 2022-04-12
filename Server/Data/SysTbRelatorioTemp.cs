using System;
using System.Collections.Generic;

namespace Asp_Document_Reader.Server.Data
{
    public partial class SysTbRelatorioTemp
    {
        public int Id { get; set; }
        public int? IdUser { get; set; }
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public string? Data { get; set; }
    }
}
