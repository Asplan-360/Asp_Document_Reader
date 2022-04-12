using System;
using System.Collections.Generic;

namespace Asp_Document_Reader.Server.Data
{
    public partial class SysTbLogin
    {
        public int Id { get; set; }
        public string Nome { get; set; } = null!;
        public string? Departamento { get; set; }
        public string? Login { get; set; }
        public string? Senha { get; set; }
        public string? Email { get; set; }
        public DateTime? Acesso { get; set; }
        public string? Status { get; set; }
        public string? Deletado { get; set; }
        public string? PermPlanews { get; set; }
        public string? PermImporta { get; set; }
        public string? PermUsuarios { get; set; }
        public string? PermAtualizacao { get; set; }
        public string? PermTreinamentos { get; set; }
        public string? PermConsultoria { get; set; }
        public string? PermCurso { get; set; }
    }
}
