using System;
using System.Collections.Generic;

namespace Asp_Document_Reader.Server.Data
{
    public partial class TbCursoData
    {
        public int Id { get; set; }
        public int? IdCurso { get; set; }
        public DateTime? Data { get; set; }
        public string? Status { get; set; }
        public int? Limite { get; set; }
        public string? Semana { get; set; }
    }
}
