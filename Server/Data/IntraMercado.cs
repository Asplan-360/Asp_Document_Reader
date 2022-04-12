using System;
using System.Collections.Generic;

namespace Asp_Document_Reader.Server.Data
{
    public partial class IntraMercado
    {
        public int Id { get; set; }
        public int? Categoria { get; set; }
        public string? Titulo { get; set; }
        public string? Email { get; set; }
        public string? Descricao { get; set; }
        public int? IdUsuario { get; set; }
        public DateTime? Data { get; set; }
        public string? Telefone { get; set; }
        public DateTime? Validade { get; set; }
        public string? Valor { get; set; }
        public string? Produto { get; set; }
        public string? Foto1 { get; set; }
        public string? Status { get; set; }
        public string? Deletado { get; set; }
    }
}
