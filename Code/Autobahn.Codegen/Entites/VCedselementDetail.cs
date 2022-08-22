using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ScafoldADatabase.Entities
{
    [Table("CedselementDetail")]
    public partial class CedselementDetail
    {
        [Key]
        [Required]
        Guid Id { get; set; } = default(Guid);

        [StringLength(128)]
        public string TableName { get; set; } = null!;
        [StringLength(128)]
        public string? ColumnName { get; set; }
        [StringLength(128)]
        public string? DataType { get; set; }
        public int? MaxLength { get; set; }
        public int? ColumnPostion { get; set; }
        [Unicode(false)]
        public string? Description { get; set; }
        [Unicode(false)]
        public string? CedsElement { get; set; }
        [Unicode(false)]
        public string? Url { get; set; }
        [Unicode(false)]
        public string? GlobalId { get; set; }
    }
}
