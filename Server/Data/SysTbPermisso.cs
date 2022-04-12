using System;
using System.Collections.Generic;

namespace Asp_Document_Reader.Server.Data
{
    public partial class SysTbPermisso
    {
        public int Id { get; set; }
        public int? IdUser { get; set; }
        public int? Permissao { get; set; }
    }
}
