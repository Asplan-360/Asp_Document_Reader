using System;
using System.Collections.Generic;

namespace Asp_Document_Reader.Server.Data
{
    public partial class IntraAgendamento
    {
        public int Id { get; set; }
        public int? Idusuario { get; set; }
        public string? NomeUsuario { get; set; }
        public DateTime? Data { get; set; }
        public DateTime? DataSolicit { get; set; }
        public string? Pessoa { get; set; }
        public string? Tipo { get; set; }
        public string? Departamento { get; set; }
        public int? Status { get; set; }
        public int? Idperiodo { get; set; }
        public string? Periodo { get; set; }
        public string? Previa { get; set; }
    }
}
