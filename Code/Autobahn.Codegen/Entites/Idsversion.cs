using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ScafoldADatabase.Entities
{
    [Table("IDSVersion")]
    public partial class IDSVersion
    {
        [Key]
        public int IDSVersionId { get; set; }
        public bool CurrentVersion { get; set; }
        public DateTime IDSVersionDate { get; set; }
        [StringLength(10)]
        public string IDSVersionNumber { get; set; } = null!;
    }
}
