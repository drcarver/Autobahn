﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Autobahn.Codegen.Models
{
    internal class CSVReferenceModel
    {
        public Guid id { get; set; } = Guid.NewGuid();
        public string Description { get; set; }
        public string Code { get; set; }
        public string Definition { get; set; }
        public decimal SortOrder { get; set; }
    }
}
