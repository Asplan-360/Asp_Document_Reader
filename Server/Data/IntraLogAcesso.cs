﻿using System;
using System.Collections.Generic;

namespace Asp_Document_Reader.Server.Data
{
    public partial class IntraLogAcesso
    {
        public int Id { get; set; }
        public int? IdUser { get; set; }
        public DateTime? Data { get; set; }
    }
}
