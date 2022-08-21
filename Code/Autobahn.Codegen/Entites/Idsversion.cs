using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ScafoldADatabase.Entities
{
    [Table("IDSVersion")]
    public partial class Idsversion
    {
        [Key]
        [Column("IDSVersionId")]
        public int IdsversionId { get; set; }
        public bool CurrentVersion { get; set; }
        [Column("IDSVersionDate", TypeName = "datetime")]
        public DateTime IdsversionDate { get; set; }
        [Column("IDSVersionNumber")]
        [StringLength(10)]
        public string IdsversionNumber { get; set; } = null!;
    }
}
