using System;
using System.Collections.Generic;

namespace Asp_Document_Reader.Server.Data
{
    public partial class TbLogTreinamento
    {
        public int Id { get; set; }
        public int? IdEmp { get; set; }
        public int? IdUser { get; set; }
        public int? Idtreina { get; set; }
        public DateTime? Data { get; set; }
    }
}
