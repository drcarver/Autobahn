﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ScafoldADatabase.Entities
{
    [Keyless]
    public partial class VCedsmapping
    {
        [StringLength(128)]
        public string TableName { get; set; } = null!;
        [StringLength(128)]
        public string? ColumnName { get; set; }
        [Unicode(false)]
        public string? GlobalId { get; set; }
        [Unicode(false)]
        public string? ElementName { get; set; }
        [Column("URL")]
        [Unicode(false)]
        public string? Url { get; set; }
    }
}
