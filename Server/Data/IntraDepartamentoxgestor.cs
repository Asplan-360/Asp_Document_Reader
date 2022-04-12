using System;
using System.Collections.Generic;

namespace Asp_Document_Reader.Server.Data
{
    public partial class IntraDepartamentoxgestor
    {
        public int Id { get; set; }
        public int? Departamento { get; set; }
        public int? IdGestor { get; set; }

        public virtual IntraDepartamento? DepartamentoNavigation { get; set; }
    }
}
