using System;
using System.ComponentModel.DataAnnotations;

namespace Autobahn.Entities
{
    public partial class RefCteNonTraditionalGenderStatu
    {
        [Key]
        public int RefCTENonTraditionalGenderStatusId { get; set; }

        [Required]
        [StringLength(150)]
        public string Description { get; set; }

        [StringLength(50)]
        public string Code { get; set; }

        [StringLength(4000)]
        public string Definition { get; set; }

        public int? RefJurisdictionId { get; set; }

        public decimal? SortOrder { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public virtual Organization Organization { get; set; }
    }
}
