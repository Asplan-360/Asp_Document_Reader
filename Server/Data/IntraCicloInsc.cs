using System;
using System.Collections.Generic;

namespace Asp_Document_Reader.Server.Data
{
    public partial class IntraCicloInsc
    {
        public int Id { get; set; }
        public int? Inscrito { get; set; }
        public int? IdUser { get; set; }
        public int? IdCurso { get; set; }
        public DateTime? Data { get; set; }
    }
}
