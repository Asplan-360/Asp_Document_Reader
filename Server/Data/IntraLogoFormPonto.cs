using System;
using System.Collections.Generic;

namespace Asp_Document_Reader.Server.Data
{
    public partial class IntraLogoFormPonto
    {
        public int Id { get; set; }
        public int? IdFuncionario { get; set; }
        public int? IdGestor { get; set; }
        public string? Data { get; set; }
        public string? Just1 { get; set; }
        public string? Periodo { get; set; }
        public string? Horas { get; set; }
        public string? Just2 { get; set; }
        public string? Outros { get; set; }
        public string? Diaria { get; set; }
    }
}
