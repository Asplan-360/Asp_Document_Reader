using System;
using System.Collections.Generic;

namespace Asp_Document_Reader.Server.Data
{
    public partial class IntraPermisso
    {
        public int Id { get; set; }
        public int? IdUser { get; set; }
        public bool? PermComunicados { get; set; }
        public bool? PermJornal { get; set; }
        public bool? PermAfago { get; set; }
        public bool? PermTreinamento { get; set; }
        public bool? PermManual { get; set; }
        public bool? PermEstudos { get; set; }
        public bool? PermBeneficio { get; set; }
        public bool? PermFuncionario { get; set; }
        public bool? PermLink { get; set; }
        public bool? PermLogAcesso { get; set; }
        public bool? PermComite { get; set; }
        public bool? PermMercado { get; set; }
        public bool? PermClientes { get; set; }
        public bool? PermEnquete { get; set; }
        public bool? PermExterno { get; set; }
    }
}
