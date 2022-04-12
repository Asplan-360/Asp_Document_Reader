using System;
using System.Collections.Generic;

namespace Asp_Document_Reader.Server.Data
{
    public partial class EfciLogMkt
    {
        public int Id { get; set; }
        public int? NumEmail { get; set; }
        public DateTime? Data { get; set; }
        public string? Email { get; set; }
        public string? Link { get; set; }
        public string? ImgEmail { get; set; }
    }
}
