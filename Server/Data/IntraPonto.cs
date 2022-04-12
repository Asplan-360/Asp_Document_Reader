using System;
using System.Collections.Generic;

namespace Asp_Document_Reader.Server.Data
{
    public partial class IntraPonto
    {
        public int Id { get; set; }
        public int? IdFuncionario { get; set; }
        public int? IdGestor { get; set; }
        public string? Data { get; set; }
        public string? Item { get; set; }
        public string? PeriodoDe { get; set; }
        public string? PeriodoAte { get; set; }
        public string? Horas { get; set; }
        public string? Justificativa { get; set; }
        public int? Status { get; set; }
        public string? MotivoRecusado { get; set; }
        public string? Nivel1 { get; set; }
        public string? Nivel2 { get; set; }
        public string? Nivel3 { get; set; }
        public DateTime? DtAprovacaoNivel3 { get; set; }
        public DateTime? DtAprovacaoNivel2 { get; set; }
        public DateTime? DtAprovacaoNivel1 { get; set; }
        public DateTime? DtInclusao { get; set; }
    }
}
