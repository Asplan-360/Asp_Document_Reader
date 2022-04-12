using System;
using System.Collections.Generic;

namespace Asp_Document_Reader.Server.Data
{
    public partial class TbCadastroEmpresa
    {
        public int Id { get; set; }
        public string? Empresa { get; set; }
        public string? Fantasia { get; set; }
        public string? Fone { get; set; }
        public string? Fax { get; set; }
        public string? Login { get; set; }
        public string? Senha { get; set; }
        public string? Codigo { get; set; }
        public string? Cnpj { get; set; }
        public string? Responsavel { get; set; }
        public string? EmailResponsavel { get; set; }
        public string? InscEstadual { get; set; }
        public string? InscMunicipal { get; set; }
        public string? Observacao { get; set; }
        public string? Endereco { get; set; }
        public string? Contato { get; set; }
        public string? Status { get; set; }
    }
}
