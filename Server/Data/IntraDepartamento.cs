using System;
using System.Collections.Generic;

namespace Asp_Document_Reader.Server.Data
{
    public partial class IntraDepartamento
    {
        public IntraDepartamento()
        {
            IntraDepartamentoxgestors = new HashSet<IntraDepartamentoxgestor>();
        }

        public string? Departamento { get; set; }
        public decimal? IdGestor { get; set; }
        public int Id { get; set; }

        public virtual ICollection<IntraDepartamentoxgestor> IntraDepartamentoxgestors { get; set; }
    }
}
