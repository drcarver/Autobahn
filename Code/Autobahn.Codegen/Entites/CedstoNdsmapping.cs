using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ScafoldADatabase.Entities
{
    [Keyless]
    [Table("_CEDStoNDSMapping")]
    [Index("GlobalId", "TableName", "ColumnName", "Version", Name = "IX_GlobalID_TableName_ColumnName_Version", IsUnique = true)]
    public partial class CedstoNdsmapping
    {
        [StringLength(20)]
        [Unicode(false)]
        public string GlobalID { get; set; } = null!;
        [StringLength(100)]
        [Unicode(false)]
        public string TableName { get; set; } = null!;
        [StringLength(100)]
        [Unicode(false)]
        public string? ColumnName { get; set; }
        [StringLength(20)]
        public string? Version { get; set; }
    }
}
