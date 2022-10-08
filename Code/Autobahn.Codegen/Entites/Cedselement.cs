using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ScafoldADatabase.Entities
{
    [Table("_CEDSElements")]
    public partial class Cedselement
    {
        [StringLength(20)]
        [Unicode(false)]
        public string? GlobalID { get; set; }
        [StringLength(150)]
        [Unicode(false)]
        public string ElementName { get; set; } = null!;
        [StringLength(150)]
        [Unicode(false)]
        public string? AltName { get; set; }
        [Unicode(false)]
        public string Definition { get; set; } = null!;
        [StringLength(150)]
        [Unicode(false)]
        public string? Format { get; set; }
        public bool HasOptionSet { get; set; }
        [Unicode(false)]
        public string? UsageNotes { get; set; }
        [StringLength(512)]
        [Unicode(false)]
        public string? URL { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string? Version { get; set; }
        [Key]
        public int TermID { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string? ChangedInThisVersionInd { get; set; }
        [Unicode(false)]
        public string? ChangeNotes { get; set; }
    }
}
