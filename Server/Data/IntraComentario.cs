using System;
using System.Collections.Generic;

namespace Asp_Document_Reader.Server.Data
{
    public partial class IntraComentario
    {
        public int Id { get; set; }
        public int? IdFuncionario { get; set; }
        public int? IdConteudo { get; set; }
        public string? Tipo { get; set; }
        public string? Comentario { get; set; }
        public DateTime? Data { get; set; }
        public string? Status { get; set; }
        public string? Deletado { get; set; }
    }
}
