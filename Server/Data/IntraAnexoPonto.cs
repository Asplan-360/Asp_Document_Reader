using System;
using System.Collections.Generic;

namespace Asp_Document_Reader.Server.Data
{
    public partial class IntraAnexoPonto
    {
        public int Id { get; set; }
        public int? IdFuncionario { get; set; }
        public string? Data { get; set; }
        public string? Nome { get; set; }
        public int? Idponto { get; set; }
    }
}
