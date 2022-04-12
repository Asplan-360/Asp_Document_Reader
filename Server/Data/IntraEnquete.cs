using System;
using System.Collections.Generic;

namespace Asp_Document_Reader.Server.Data
{
    public partial class IntraEnquete
    {
        public int Id { get; set; }
        public string? Pergunta { get; set; }
        public string? Opcao1 { get; set; }
        public string? Opcao2 { get; set; }
        public string? Opcao3 { get; set; }
        public string? Opcao4 { get; set; }
        public string? Opcao5 { get; set; }
        public int? Resultado1 { get; set; }
        public int? Resultado2 { get; set; }
        public int? Resultado3 { get; set; }
        public int? Resultado4 { get; set; }
        public int? Resultado5 { get; set; }
        public DateTime? Data { get; set; }
        public string? Status { get; set; }
        public int? Deletado { get; set; }
        public int? Usuario { get; set; }
        public string? Tipo { get; set; }
    }
}
