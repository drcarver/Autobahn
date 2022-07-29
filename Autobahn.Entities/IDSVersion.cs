using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("IDSVersion")]
    public partial class IDSVersion
    {
        public int IDSVersionId { get; set; }

        public bool CurrentVersion { get; set; }

        public DateTime IDSVersionDate { get; set; }

        [Required]
        [StringLength(10)]
        public string IDSVersionNumber { get; set; }
    }
}
